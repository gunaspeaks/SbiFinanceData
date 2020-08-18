namespace SbiFinanceData.Reports
{
    partial class ScriptwisePLForm
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
            this.gvPLData = new System.Windows.Forms.DataGridView();
            this.btnRetrieveData = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvPLData)).BeginInit();
            this.SuspendLayout();
            // 
            // gvPLData
            // 
            this.gvPLData.AllowUserToAddRows = false;
            this.gvPLData.AllowUserToDeleteRows = false;
            this.gvPLData.AllowUserToResizeRows = false;
            this.gvPLData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvPLData.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gvPLData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPLData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvPLData.Location = new System.Drawing.Point(20, 55);
            this.gvPLData.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gvPLData.MultiSelect = false;
            this.gvPLData.Name = "gvPLData";
            this.gvPLData.ReadOnly = true;
            this.gvPLData.Size = new System.Drawing.Size(889, 485);
            this.gvPLData.TabIndex = 2;
            this.gvPLData.Visible = false;
            // 
            // btnRetrieveData
            // 
            this.btnRetrieveData.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRetrieveData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrieveData.Location = new System.Drawing.Point(20, 15);
            this.btnRetrieveData.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetrieveData.Name = "btnRetrieveData";
            this.btnRetrieveData.Size = new System.Drawing.Size(149, 31);
            this.btnRetrieveData.TabIndex = 7;
            this.btnRetrieveData.Text = "&Retrieve Data";
            this.btnRetrieveData.UseVisualStyleBackColor = true;
            this.btnRetrieveData.Click += new System.EventHandler(this.RetrieveDataButton_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Yellow;
            this.btnClose.Location = new System.Drawing.Point(884, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 22);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ScriptwisePLForm
            // 
            this.AcceptButton = this.btnRetrieveData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(923, 554);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRetrieveData);
            this.Controls.Add(this.gvPLData);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ScriptwisePLForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script-wise Profit & Loss";
            this.Shown += new System.EventHandler(this.ScriptwisePLForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gvPLData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPLData;
        private System.Windows.Forms.Button btnRetrieveData;
        private System.Windows.Forms.Button btnClose;
    }
}