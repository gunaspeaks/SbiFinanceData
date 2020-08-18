namespace SbiFinanceData
{
    partial class BuyOrdersForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.txtBrokerage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.cmbScript = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gvBuyOrders = new System.Windows.Forms.DataGridView();
            this.lblContractNo = new System.Windows.Forms.Label();
            this.lblBuyOrderNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBuyOrders)).BeginInit();
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
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtBrokerage);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtRate);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtQty);
            this.panel2.Controls.Add(this.cmbScript);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 80);
            this.panel2.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Yellow;
            this.btnClose.Location = new System.Drawing.Point(767, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 22);
            this.btnClose.TabIndex = 22;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTransaction.Location = new System.Drawing.Point(638, 25);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(142, 33);
            this.btnAddTransaction.TabIndex = 21;
            this.btnAddTransaction.Text = "&Add Transaction";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.AddTransactionButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(523, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "Brokerage";
            // 
            // txtBrokerage
            // 
            this.txtBrokerage.Location = new System.Drawing.Point(526, 35);
            this.txtBrokerage.MaxLength = 20;
            this.txtBrokerage.Name = "txtBrokerage";
            this.txtBrokerage.Size = new System.Drawing.Size(93, 23);
            this.txtBrokerage.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(426, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(429, 35);
            this.txtRate.MaxLength = 20;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(82, 23);
            this.txtRate.TabIndex = 16;
            this.txtRate.TextChanged += new System.EventHandler(this.Rate_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(331, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quantity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(334, 35);
            this.txtQty.MaxLength = 20;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(76, 23);
            this.txtQty.TabIndex = 15;
            this.txtQty.TextChanged += new System.EventHandler(this.Qty_TextChanged);
            // 
            // cmbScript
            // 
            this.cmbScript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScript.FormattingEnabled = true;
            this.cmbScript.Location = new System.Drawing.Point(21, 35);
            this.cmbScript.Name = "cmbScript";
            this.cmbScript.Size = new System.Drawing.Size(287, 24);
            this.cmbScript.TabIndex = 7;
            this.cmbScript.SelectedIndexChanged += new System.EventHandler(this.Script_SelectedIndexChanged);
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
            // gvBuyOrders
            // 
            this.gvBuyOrders.AllowUserToAddRows = false;
            this.gvBuyOrders.AllowUserToDeleteRows = false;
            this.gvBuyOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvBuyOrders.BackgroundColor = System.Drawing.Color.Green;
            this.gvBuyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvBuyOrders.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvBuyOrders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvBuyOrders.Location = new System.Drawing.Point(12, 98);
            this.gvBuyOrders.MultiSelect = false;
            this.gvBuyOrders.Name = "gvBuyOrders";
            this.gvBuyOrders.ReadOnly = true;
            this.gvBuyOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvBuyOrders.ShowCellErrors = false;
            this.gvBuyOrders.ShowCellToolTips = false;
            this.gvBuyOrders.ShowEditingIcon = false;
            this.gvBuyOrders.ShowRowErrors = false;
            this.gvBuyOrders.Size = new System.Drawing.Size(794, 257);
            this.gvBuyOrders.TabIndex = 10;
            this.gvBuyOrders.TabStop = false;
            // 
            // lblContractNo
            // 
            this.lblContractNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContractNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblContractNo.Location = new System.Drawing.Point(151, 367);
            this.lblContractNo.Name = "lblContractNo";
            this.lblContractNo.Size = new System.Drawing.Size(216, 25);
            this.lblContractNo.TabIndex = 11;
            this.lblContractNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBuyOrderNo
            // 
            this.lblBuyOrderNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBuyOrderNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuyOrderNo.Location = new System.Drawing.Point(483, 368);
            this.lblBuyOrderNo.Name = "lblBuyOrderNo";
            this.lblBuyOrderNo.Size = new System.Drawing.Size(223, 25);
            this.lblBuyOrderNo.TabIndex = 13;
            this.lblBuyOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(376, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Buy Order No";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(734, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 33);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // BuyOrdersForm
            // 
            this.AcceptButton = this.btnAddTransaction;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(819, 402);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblBuyOrderNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContractNo);
            this.Controls.Add(this.gvBuyOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BuyOrdersForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy Orders";
            this.Load += new System.EventHandler(this.BuyOrdersForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvBuyOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.ComboBox cmbScript;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBrokerage;
        private System.Windows.Forms.DataGridView gvBuyOrders;
        private System.Windows.Forms.Label lblContractNo;
        private System.Windows.Forms.Label lblBuyOrderNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
    }
}