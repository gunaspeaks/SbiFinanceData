namespace SbiFinanceData
{
    partial class DigitalContractForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContractNoteNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTradedDate = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtContractNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOtherTaxes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGst = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEtc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrokerage = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lnkBuyOrders = new System.Windows.Forms.LinkLabel();
            this.lnkSellOrders = new System.Windows.Forms.LinkLabel();
            this.lnkIOrders = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contract Note No";
            // 
            // txtContractNoteNo
            // 
            this.txtContractNoteNo.Location = new System.Drawing.Point(21, 37);
            this.txtContractNoteNo.MaxLength = 20;
            this.txtContractNoteNo.Name = "txtContractNoteNo";
            this.txtContractNoteNo.Size = new System.Drawing.Size(287, 23);
            this.txtContractNoteNo.TabIndex = 0;
            this.txtContractNoteNo.TextChanged += new System.EventHandler(this.ContractNoteNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Traded Date";
            // 
            // dtTradedDate
            // 
            this.dtTradedDate.Location = new System.Drawing.Point(334, 37);
            this.dtTradedDate.Name = "dtTradedDate";
            this.dtTradedDate.Size = new System.Drawing.Size(287, 23);
            this.dtTradedDate.TabIndex = 1;
            this.dtTradedDate.ValueChanged += new System.EventHandler(this.TradedDate_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.txtContractNo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtStt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtOtherTaxes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtGst);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEtc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBrokerage);
            this.panel1.Controls.Add(this.dtTradedDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtContractNoteNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 227);
            this.panel1.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Yellow;
            this.btnClose.Location = new System.Drawing.Point(612, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 22);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // txtContractNo
            // 
            this.txtContractNo.Location = new System.Drawing.Point(179, 181);
            this.txtContractNo.MaxLength = 20;
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.ReadOnly = true;
            this.txtContractNo.Size = new System.Drawing.Size(284, 23);
            this.txtContractNo.TabIndex = 16;
            this.txtContractNo.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Contract Number";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(546, 163);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(176, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "STT";
            // 
            // txtStt
            // 
            this.txtStt.Location = new System.Drawing.Point(179, 110);
            this.txtStt.MaxLength = 20;
            this.txtStt.Name = "txtStt";
            this.txtStt.Size = new System.Drawing.Size(129, 23);
            this.txtStt.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Other Taxes";
            // 
            // txtOtherTaxes
            // 
            this.txtOtherTaxes.Location = new System.Drawing.Point(21, 181);
            this.txtOtherTaxes.MaxLength = 20;
            this.txtOtherTaxes.Name = "txtOtherTaxes";
            this.txtOtherTaxes.Size = new System.Drawing.Size(129, 23);
            this.txtOtherTaxes.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "GST";
            // 
            // txtGst
            // 
            this.txtGst.Location = new System.Drawing.Point(492, 110);
            this.txtGst.MaxLength = 20;
            this.txtGst.Name = "txtGst";
            this.txtGst.Size = new System.Drawing.Size(129, 23);
            this.txtGst.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(331, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "ETC";
            // 
            // txtEtc
            // 
            this.txtEtc.Location = new System.Drawing.Point(334, 110);
            this.txtEtc.MaxLength = 20;
            this.txtEtc.Name = "txtEtc";
            this.txtEtc.Size = new System.Drawing.Size(129, 23);
            this.txtEtc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Brokerage";
            // 
            // txtBrokerage
            // 
            this.txtBrokerage.Location = new System.Drawing.Point(21, 110);
            this.txtBrokerage.MaxLength = 20;
            this.txtBrokerage.Name = "txtBrokerage";
            this.txtBrokerage.Size = new System.Drawing.Size(129, 23);
            this.txtBrokerage.TabIndex = 2;
            // 
            // lnkBuyOrders
            // 
            this.lnkBuyOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnkBuyOrders.Enabled = false;
            this.lnkBuyOrders.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkBuyOrders.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkBuyOrders.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lnkBuyOrders.Location = new System.Drawing.Point(325, 250);
            this.lnkBuyOrders.Name = "lnkBuyOrders";
            this.lnkBuyOrders.Size = new System.Drawing.Size(162, 24);
            this.lnkBuyOrders.TabIndex = 10;
            this.lnkBuyOrders.TabStop = true;
            this.lnkBuyOrders.Text = "&Buy Orders";
            this.lnkBuyOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkBuyOrders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BuyOrders_LinkClicked);
            // 
            // lnkSellOrders
            // 
            this.lnkSellOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnkSellOrders.Enabled = false;
            this.lnkSellOrders.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkSellOrders.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkSellOrders.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lnkSellOrders.Location = new System.Drawing.Point(493, 250);
            this.lnkSellOrders.Name = "lnkSellOrders";
            this.lnkSellOrders.Size = new System.Drawing.Size(163, 24);
            this.lnkSellOrders.TabIndex = 11;
            this.lnkSellOrders.TabStop = true;
            this.lnkSellOrders.Text = "Sell &Orders";
            this.lnkSellOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkSellOrders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SellOrders_LinkClicked);
            // 
            // lnkIOrders
            // 
            this.lnkIOrders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lnkIOrders.Enabled = false;
            this.lnkIOrders.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkIOrders.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkIOrders.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lnkIOrders.Location = new System.Drawing.Point(88, 250);
            this.lnkIOrders.Name = "lnkIOrders";
            this.lnkIOrders.Size = new System.Drawing.Size(233, 24);
            this.lnkIOrders.TabIndex = 12;
            this.lnkIOrders.TabStop = true;
            this.lnkIOrders.Text = "&Intraday Transactions ";
            this.lnkIOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkIOrders.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IntradayOrders_LinkClicked);
            // 
            // DigitalContractForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(662, 283);
            this.Controls.Add(this.lnkIOrders);
            this.Controls.Add(this.lnkSellOrders);
            this.Controls.Add(this.lnkBuyOrders);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DigitalContractForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Contract Details";
            this.Load += new System.EventHandler(this.DigitalContractForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContractNoteNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTradedDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOtherTaxes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEtc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrokerage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel lnkBuyOrders;
        private System.Windows.Forms.LinkLabel lnkSellOrders;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtContractNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lnkIOrders;
        private System.Windows.Forms.Button btnClose;
    }
}