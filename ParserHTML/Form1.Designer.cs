namespace ParserHTML {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.txtContains = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dataGridResult = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.groupBoxMail = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMailPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxUseMAIL = new System.Windows.Forms.CheckBox();
            this.toolTipContains = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).BeginInit();
            this.groupBoxMain.SuspendLayout();
            this.groupBoxMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.Location = new System.Drawing.Point(12, 383);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Запустить робота";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtContains
            // 
            this.txtContains.Location = new System.Drawing.Point(78, 45);
            this.txtContains.Name = "txtContains";
            this.txtContains.Size = new System.Drawing.Size(159, 20);
            this.txtContains.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contains";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Стоимость";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(78, 70);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(159, 20);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // dataGridResult
            // 
            this.dataGridResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Price,
            this.Link,
            this.Key});
            this.dataGridResult.Location = new System.Drawing.Point(12, 147);
            this.dataGridResult.Name = "dataGridResult";
            this.dataGridResult.Size = new System.Drawing.Size(601, 230);
            this.dataGridResult.TabIndex = 6;
            this.dataGridResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridResult_CellContentClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.Name = "Link";
            this.Link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Link.Width = 300;
            // 
            // Key
            // 
            this.Key.HeaderText = "Key";
            this.Key.Name = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(10, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "URL";
            this.label3.DoubleClick += new System.EventHandler(this.label3_DoubleClick);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(78, 19);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(159, 20);
            this.txtURL.TabIndex = 1;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AVITO Parser";
            this.notifyIcon1.Visible = true;
            // 
            // timerMain
            // 
            this.timerMain.Interval = 30000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.txtURL);
            this.groupBoxMain.Controls.Add(this.label3);
            this.groupBoxMain.Controls.Add(this.txtPrice);
            this.groupBoxMain.Controls.Add(this.label1);
            this.groupBoxMain.Controls.Add(this.label2);
            this.groupBoxMain.Controls.Add(this.txtContains);
            this.groupBoxMain.Location = new System.Drawing.Point(12, 38);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(259, 103);
            this.groupBoxMain.TabIndex = 9;
            this.groupBoxMain.TabStop = false;
            // 
            // groupBoxMail
            // 
            this.groupBoxMail.Controls.Add(this.txtPassword);
            this.groupBoxMail.Controls.Add(this.label7);
            this.groupBoxMail.Controls.Add(this.txtTo);
            this.groupBoxMail.Controls.Add(this.label5);
            this.groupBoxMail.Controls.Add(this.txtMailPrice);
            this.groupBoxMail.Controls.Add(this.label6);
            this.groupBoxMail.Controls.Add(this.txtFrom);
            this.groupBoxMail.Controls.Add(this.label4);
            this.groupBoxMail.Enabled = false;
            this.groupBoxMail.Location = new System.Drawing.Point(295, 12);
            this.groupBoxMail.Name = "groupBoxMail";
            this.groupBoxMail.Size = new System.Drawing.Size(218, 129);
            this.groupBoxMail.TabIndex = 10;
            this.groupBoxMail.TabStop = false;
            this.groupBoxMail.Text = "посылать на MAIL";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(77, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(133, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Password";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(58, 43);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(152, 20);
            this.txtTo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "To";
            // 
            // txtMailPrice
            // 
            this.txtMailPrice.Location = new System.Drawing.Point(77, 92);
            this.txtMailPrice.Name = "txtMailPrice";
            this.txtMailPrice.Size = new System.Drawing.Size(135, 20);
            this.txtMailPrice.TabIndex = 8;
            this.txtMailPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Стоимость";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(58, 19);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(152, 20);
            this.txtFrom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "From";
            // 
            // checkBoxUseMAIL
            // 
            this.checkBoxUseMAIL.AutoSize = true;
            this.checkBoxUseMAIL.Location = new System.Drawing.Point(153, 12);
            this.checkBoxUseMAIL.Name = "checkBoxUseMAIL";
            this.checkBoxUseMAIL.Size = new System.Drawing.Size(118, 17);
            this.checkBoxUseMAIL.TabIndex = 4;
            this.checkBoxUseMAIL.Text = "посылать на MAIL";
            this.checkBoxUseMAIL.UseVisualStyleBackColor = true;
            this.checkBoxUseMAIL.CheckedChanged += new System.EventHandler(this.checkBoxUseMAIL_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 418);
            this.Controls.Add(this.checkBoxUseMAIL);
            this.Controls.Add(this.groupBoxMail);
            this.Controls.Add(this.groupBoxMain);
            this.Controls.Add(this.dataGridResult);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парсер";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResult)).EndInit();
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            this.groupBoxMail.ResumeLayout(false);
            this.groupBoxMail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtContains;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dataGridResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn Key;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.Windows.Forms.GroupBox groupBoxMail;
        private System.Windows.Forms.CheckBox checkBoxUseMAIL;
        private System.Windows.Forms.TextBox txtMailPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTipContains;
    }
}

