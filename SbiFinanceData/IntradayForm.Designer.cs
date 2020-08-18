namespace SbiFinanceData
{
    partial class IntradayForm
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
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSRate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSBrokerage = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBBrokerage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cmbScript = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gvIntraOrders = new System.Windows.Forms.DataGridView();
            this.lblContractNo = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvIntraOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(12, 367);
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
            this.panel2.Controls.Add(this.btnAddTransaction);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSRate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtSBrokerage);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtBBrokerage);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtBRate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.cmbScript);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 80);
            this.panel2.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Yellow;
            this.btnClose.Location = new System.Drawing.Point(964, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 22);
            this.btnClose.TabIndex = 23;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Location = new System.Drawing.Point(832, 25);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(142, 33);
            this.btnAddTransaction.TabIndex = 6;
            this.btnAddTransaction.Text = "&Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Sell Rate";
            // 
            // txtSRate
            // 
            this.txtSRate.Location = new System.Drawing.Point(499, 35);
            this.txtSRate.MaxLength = 20;
            this.txtSRate.Name = "txtSRate";
            this.txtSRate.Size = new System.Drawing.Size(82, 23);
            this.txtSRate.TabIndex = 3;
            this.txtSRate.TextChanged += new System.EventHandler(this.SRate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "S. Brokerage";
            // 
            // txtSBrokerage
            // 
            this.txtSBrokerage.Location = new System.Drawing.Point(714, 35);
            this.txtSBrokerage.MaxLength = 20;
            this.txtSBrokerage.Name = "txtSBrokerage";
            this.txtSBrokerage.Size = new System.Drawing.Size(105, 23);
            this.txtSBrokerage.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(588, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "B. Brokerage";
            // 
            // txtBBrokerage
            // 
            this.txtBBrokerage.Location = new System.Drawing.Point(592, 35);
            this.txtBBrokerage.MaxLength = 20;
            this.txtBBrokerage.Name = "txtBBrokerage";
            this.txtBBrokerage.Size = new System.Drawing.Size(111, 23);
            this.txtBBrokerage.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Buy Rate";
            // 
            // txtBRate
            // 
            this.txtBRate.Location = new System.Drawing.Point(406, 35);
            this.txtBRate.MaxLength = 20;
            this.txtBRate.Name = "txtBRate";
            this.txtBRate.Size = new System.Drawing.Size(82, 23);
            this.txtBRate.TabIndex = 2;
            this.txtBRate.TextChanged += new System.EventHandler(this.BRate_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(319, 35);
            this.txtQty.MaxLength = 20;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(76, 23);
            this.txtQty.TabIndex = 1;
            this.txtQty.TextChanged += new System.EventHandler(this.Qty_TextChanged);
            // 
            // cmbScript
            // 
            this.cmbScript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScript.FormattingEnabled = true;
            this.cmbScript.Location = new System.Drawing.Point(21, 35);
            this.cmbScript.Name = "cmbScript";
            this.cmbScript.Size = new System.Drawing.Size(287, 24);
            this.cmbScript.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Script";
            // 
            // gvIntraOrders
            // 
            this.gvIntraOrders.AllowUserToAddRows = false;
            this.gvIntraOrders.AllowUserToDeleteRows = false;
            this.gvIntraOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvIntraOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gvIntraOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvIntraOrders.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvIntraOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvIntraOrders.Location = new System.Drawing.Point(12, 98);
            this.gvIntraOrders.MultiSelect = false;
            this.gvIntraOrders.Name = "gvIntraOrders";
            this.gvIntraOrders.ReadOnly = true;
            this.gvIntraOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvIntraOrders.ShowCellErrors = false;
            this.gvIntraOrders.ShowCellToolTips = false;
            this.gvIntraOrders.ShowEditingIcon = false;
            this.gvIntraOrders.ShowRowErrors = false;
            this.gvIntraOrders.Size = new System.Drawing.Size(991, 257);
            this.gvIntraOrders.TabIndex = 10;
            this.gvIntraOrders.TabStop = false;
            // 
            // lblContractNo
            // 
            this.lblContractNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContractNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContractNo.Location = new System.Drawing.Point(151, 367);
            this.lblContractNo.Name = "lblContractNo";
            this.lblContractNo.Size = new System.Drawing.Size(216, 25);
            this.lblContractNo.TabIndex = 11;
            this.lblContractNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(930, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 33);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // IntradayForm
            // 
            this.AcceptButton = this.btnAddTransaction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1013, 402);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblContractNo);
            this.Controls.Add(this.gvIntraOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IntradayForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intraday Orders";
            this.Load += new System.EventHandler(this.BuyOrdersForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvIntraOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cmbScript;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBBrokerage;
        private System.Windows.Forms.DataGridView gvIntraOrders;
        private System.Windows.Forms.Label lblContractNo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSBrokerage;
        private System.Windows.Forms.Button btnClose;
    }
}