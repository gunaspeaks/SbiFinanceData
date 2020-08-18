namespace SbiFinanceData
{
    partial class SellOrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lnkScripts = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuyRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAvailableQty = new System.Windows.Forms.TextBox();
            this.cmbBuyOrders = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBrokerage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSoldRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoldQty = new System.Windows.Forms.TextBox();
            this.cmbScript = new System.Windows.Forms.ComboBox();
            this.gvSellOrders = new System.Windows.Forms.DataGridView();
            this.lblContractNo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSellOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 456);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contract Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.lnkScripts);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtBuyRate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAvailableQty);
            this.panel2.Controls.Add(this.cmbBuyOrders);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtBrokerage);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSoldRate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtSoldQty);
            this.panel2.Controls.Add(this.cmbScript);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 137);
            this.panel2.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Yellow;
            this.btnClose.Location = new System.Drawing.Point(726, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 22);
            this.btnClose.TabIndex = 29;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lnkScripts
            // 
            this.lnkScripts.AutoSize = true;
            this.lnkScripts.Location = new System.Drawing.Point(18, 17);
            this.lnkScripts.Name = "lnkScripts";
            this.lnkScripts.Size = new System.Drawing.Size(58, 16);
            this.lnkScripts.TabIndex = 28;
            this.lnkScripts.TabStop = true;
            this.lnkScripts.Text = "Scripts";
            this.lnkScripts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Scripts_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Buy Rate";
            // 
            // txtBuyRate
            // 
            this.txtBuyRate.Location = new System.Drawing.Point(449, 97);
            this.txtBuyRate.MaxLength = 20;
            this.txtBuyRate.Name = "txtBuyRate";
            this.txtBuyRate.ReadOnly = true;
            this.txtBuyRate.Size = new System.Drawing.Size(109, 23);
            this.txtBuyRate.TabIndex = 26;
            this.txtBuyRate.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Available Qty";
            // 
            // txtAvailableQty
            // 
            this.txtAvailableQty.Location = new System.Drawing.Point(324, 97);
            this.txtAvailableQty.MaxLength = 20;
            this.txtAvailableQty.Name = "txtAvailableQty";
            this.txtAvailableQty.ReadOnly = true;
            this.txtAvailableQty.Size = new System.Drawing.Size(109, 23);
            this.txtAvailableQty.TabIndex = 24;
            this.txtAvailableQty.TabStop = false;
            // 
            // cmbBuyOrders
            // 
            this.cmbBuyOrders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuyOrders.FormattingEnabled = true;
            this.cmbBuyOrders.Location = new System.Drawing.Point(21, 96);
            this.cmbBuyOrders.Name = "cmbBuyOrders";
            this.cmbBuyOrders.Size = new System.Drawing.Size(287, 24);
            this.cmbBuyOrders.TabIndex = 1;
            this.cmbBuyOrders.SelectedIndexChanged += new System.EventHandler(this.BuyOrders_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Buy Orders";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(577, 88);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 32);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Add Transaction";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(574, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Brokerage";
            // 
            // txtBrokerage
            // 
            this.txtBrokerage.Location = new System.Drawing.Point(577, 36);
            this.txtBrokerage.MaxLength = 20;
            this.txtBrokerage.Name = "txtBrokerage";
            this.txtBrokerage.Size = new System.Drawing.Size(150, 23);
            this.txtBrokerage.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sold Rate";
            // 
            // txtSoldRate
            // 
            this.txtSoldRate.Location = new System.Drawing.Point(449, 36);
            this.txtSoldRate.MaxLength = 20;
            this.txtSoldRate.Name = "txtSoldRate";
            this.txtSoldRate.Size = new System.Drawing.Size(109, 23);
            this.txtSoldRate.TabIndex = 3;
            this.txtSoldRate.TextChanged += new System.EventHandler(this.SoldRate_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Sold Quantity";
            // 
            // txtSoldQty
            // 
            this.txtSoldQty.Location = new System.Drawing.Point(324, 36);
            this.txtSoldQty.MaxLength = 20;
            this.txtSoldQty.Name = "txtSoldQty";
            this.txtSoldQty.Size = new System.Drawing.Size(109, 23);
            this.txtSoldQty.TabIndex = 2;
            this.txtSoldQty.TextChanged += new System.EventHandler(this.SoldQty_TextChanged);
            // 
            // cmbScript
            // 
            this.cmbScript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScript.FormattingEnabled = true;
            this.cmbScript.Location = new System.Drawing.Point(21, 35);
            this.cmbScript.Name = "cmbScript";
            this.cmbScript.Size = new System.Drawing.Size(287, 24);
            this.cmbScript.TabIndex = 0;
            this.cmbScript.SelectedIndexChanged += new System.EventHandler(this.Script_SelectedIndexChanged);
            // 
            // gvSellOrders
            // 
            this.gvSellOrders.AllowUserToAddRows = false;
            this.gvSellOrders.AllowUserToDeleteRows = false;
            this.gvSellOrders.AllowUserToResizeRows = false;
            this.gvSellOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvSellOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gvSellOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSellOrders.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvSellOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvSellOrders.Location = new System.Drawing.Point(12, 165);
            this.gvSellOrders.MultiSelect = false;
            this.gvSellOrders.Name = "gvSellOrders";
            this.gvSellOrders.ReadOnly = true;
            this.gvSellOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSellOrders.ShowCellErrors = false;
            this.gvSellOrders.ShowCellToolTips = false;
            this.gvSellOrders.ShowEditingIcon = false;
            this.gvSellOrders.ShowRowErrors = false;
            this.gvSellOrders.Size = new System.Drawing.Size(753, 284);
            this.gvSellOrders.TabIndex = 10;
            // 
            // lblContractNo
            // 
            this.lblContractNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContractNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContractNo.Location = new System.Drawing.Point(151, 456);
            this.lblContractNo.Name = "lblContractNo";
            this.lblContractNo.Size = new System.Drawing.Size(214, 25);
            this.lblContractNo.TabIndex = 11;
            this.lblContractNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(692, 455);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 28);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SellOrdersForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(780, 492);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblContractNo);
            this.Controls.Add(this.gvSellOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SellOrdersForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sell Orders";
            this.Load += new System.EventHandler(this.SellOrdersForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSellOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSoldRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoldQty;
        private System.Windows.Forms.ComboBox cmbScript;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBrokerage;
        private System.Windows.Forms.DataGridView gvSellOrders;
        private System.Windows.Forms.Label lblContractNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuyRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAvailableQty;
        private System.Windows.Forms.ComboBox cmbBuyOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.LinkLabel lnkScripts;
        private System.Windows.Forms.Button btnClose;
    }
}