using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserHTML {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();

            notifyIcon1.Visible = false;
            this.notifyIcon1.MouseDoubleClick += new MouseEventHandler(notifyIcon1_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) {
            Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private string GetHTML(string urlAddress) {
            string result = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK) {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null) {
                    readStream = new StreamReader(receiveStream);
                } else {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                result = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }

            return result;
        }

        private HtmlDocument GetHtmlDocument(string html) {
            WebBrowser browser = new WebBrowser();
            browser.ScriptErrorsSuppressed = true;
            browser.DocumentText = html;
            browser.Document.OpenNew(true);
            browser.Document.Write(html);
            browser.Refresh();
            return browser.Document;
        }

        private List<HtmlElement> GetListElementsByClass(HtmlElementCollection list, string className) {
            List<HtmlElement> result = new List<HtmlElement>();
            foreach (HtmlElement e in list)
                if (e.GetAttribute("className") == className)
                    result.Add(e);
            return result;
        }

        private void btnStart_Click(object sender, EventArgs e) {
            StartOrStopTime();
        }

        private void StartOrStopTime() {
            if (timerMain.Enabled) {
                timerMain.Enabled = false;
                btnStart.Text = "Запустить робота";
            } else {
                timerMain.Enabled = true;
                btnStart.Text = "Остановить робота";
                GetData();
            }
        }

        private void GetData() {
            List<List<string>> result = new List<List<string>>();

            btnStart.Enabled = false;

            int key = 0;
            foreach (DataGridViewRow row_data_view in dataGridResult.Rows) {
                if (row_data_view.Cells["Key"].Value != null && !string.IsNullOrEmpty(row_data_view.Cells["Key"].Value.ToString())) {
                    int max = int.Parse(row_data_view.Cells["Key"].Value.ToString());
                    if (key < max) key = max;
                }
            }

            string url = txtURL.Text;
            double disered_price = double.Parse(txtPrice.Text);

            string data = GetHTML(url);

            var doc = GetHtmlDocument(data);

            var list = GetListElementsByClass(doc.All, "description");

            foreach (var item in list) {
                var href = item.GetElementsByTagName("a");
                var inner_doc = GetHtmlDocument(item.InnerHtml);

                var list_a = GetListElementsByClass(inner_doc.All, "item-description-title-link");
                if (list_a.Count > 0 && list_a[0].InnerText.ToLower().Contains(txtContains.Text.ToLower())) {
                    var price_list = GetListElementsByClass(inner_doc.All, "about");
                    if (price_list.Count > 0 && !string.IsNullOrEmpty(price_list[0].InnerText)) {
                        double price_page = double.Parse(price_list[0].InnerText.Replace("руб.", "").Replace(" ", ""));

                        if (price_page <= disered_price) {
                            string before = "https://www.avito.ru";
                            string[] row = {
                                list_a[0].InnerText.ToString(),
                                price_list[0].InnerText,
                                before + list_a[0].GetAttribute("href").ToString().Replace("about:", ""),
                                ""
                            };

                            bool flag = true;

                            foreach (DataGridViewRow row_data_view in dataGridResult.Rows) {
                                if (row_data_view.Cells[0].Value != null &&
                                    row_data_view.Cells[1].Value != null &&
                                    row_data_view.Cells[2].Value != null) {

                                    if (row_data_view.Cells[0].Value.ToString() == row[0] &&
                                        row_data_view.Cells[1].Value.ToString() == row[1] &&
                                        row_data_view.Cells[2].Value.ToString() == row[2]) {

                                        flag = false;
                                        break;
                                    }
                                }
                            }
                            if (flag) {
                                key++;
                                row[3] = key.ToString();
                                dataGridResult.Rows.Add(row);
                                result.Add(row.ToList());
                            }
                        }
                    }
                }
                dataGridResult.Sort(dataGridResult.Columns["Key"], ListSortDirection.Descending);
            }

            StringBuilder builder = new StringBuilder();
            foreach (var row in result) {
                builder.Append(row[1] + " " + row[0]);
                builder.Append(Environment.NewLine);
            }

            if(result.Count > 0)
                notifyIcon1.ShowBalloonTip(5000, "Нашел " + txtContains.Text, builder.ToString(), ToolTipIcon.Info);

            btnStart.Enabled = true;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
            if (e.KeyChar == 44) {
                e.Handled = false;
                foreach (char item in txtPrice.Text) {
                    if (44 == item) {
                        e.Handled = true;
                    }
                }
            }
        }

        private void dataGridResult_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == dataGridResult.Columns["Link"].Index && e.RowIndex != -1) {
                string url = dataGridResult.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Process.Start(url);
            }
        }

        private void Form1_Resize(object sender, EventArgs e) {
            if (WindowState == FormWindowState.Minimized) {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void timerMain_Tick(object sender, EventArgs e) {
            GetData();
        }
    }
}
