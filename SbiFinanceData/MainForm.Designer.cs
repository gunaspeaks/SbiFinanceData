namespace SbiFinanceData
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.scriptsMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageScriptsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dematTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalContractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllContractsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewContractMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scriptwiseProfitLossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentHoldingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gvHoldings = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoldings)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptsMasterToolStripMenuItem,
            this.dematTransactionsToolStripMenuItem,
            this.digitalContractToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // scriptsMasterToolStripMenuItem
            // 
            this.scriptsMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageScriptsMenu});
            this.scriptsMasterToolStripMenuItem.Name = "scriptsMasterToolStripMenuItem";
            this.scriptsMasterToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.scriptsMasterToolStripMenuItem.Text = "&Scripts";
            // 
            // manageScriptsMenu
            // 
            this.manageScriptsMenu.Name = "manageScriptsMenu";
            this.manageScriptsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.manageScriptsMenu.Size = new System.Drawing.Size(187, 22);
            this.manageScriptsMenu.Text = "Manage";
            this.manageScriptsMenu.Click += new System.EventHandler(this.ManageScriptsMenu_Click);
            // 
            // dematTransactionsToolStripMenuItem
            // 
            this.dematTransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSummaryToolStripMenuItem,
            this.manageTransactionsToolStripMenuItem});
            this.dematTransactionsToolStripMenuItem.Name = "dematTransactionsToolStripMenuItem";
            this.dematTransactionsToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.dematTransactionsToolStripMenuItem.Text = "&Transactions";
            // 
            // viewSummaryToolStripMenuItem
            // 
            this.viewSummaryToolStripMenuItem.Name = "viewSummaryToolStripMenuItem";
            this.viewSummaryToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.viewSummaryToolStripMenuItem.Text = "View Summary";
            // 
            // manageTransactionsToolStripMenuItem
            // 
            this.manageTransactionsToolStripMenuItem.Name = "manageTransactionsToolStripMenuItem";
            this.manageTransactionsToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.manageTransactionsToolStripMenuItem.Text = "Manage Transactions";
            this.manageTransactionsToolStripMenuItem.Click += new System.EventHandler(this.ManageDematTransactionsMenu_Click);
            // 
            // digitalContractToolStripMenuItem
            // 
            this.digitalContractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllContractsMenu,
            this.addNewContractMenu});
            this.digitalContractToolStripMenuItem.Name = "digitalContractToolStripMenuItem";
            this.digitalContractToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.digitalContractToolStripMenuItem.Text = "&Contracts";
            // 
            // viewAllContractsMenu
            // 
            this.viewAllContractsMenu.Name = "viewAllContractsMenu";
            this.viewAllContractsMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.viewAllContractsMenu.Size = new System.Drawing.Size(188, 22);
            this.viewAllContractsMenu.Text = "View All";
            this.viewAllContractsMenu.Click += new System.EventHandler(this.ViewAllContractsMenu_Click);
            // 
            // addNewContractMenu
            // 
            this.addNewContractMenu.Name = "addNewContractMenu";
            this.addNewContractMenu.Size = new System.Drawing.Size(188, 22);
            this.addNewContractMenu.Text = "Add New";
            this.addNewContractMenu.Click += new System.EventHandler(this.AddNewContractMenu_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scriptwiseProfitLossToolStripMenuItem,
            this.currentHoldingsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.reportsToolStripMenuItem.Text = "&Reports";
            // 
            // scriptwiseProfitLossToolStripMenuItem
            // 
            this.scriptwiseProfitLossToolStripMenuItem.Name = "scriptwiseProfitLossToolStripMenuItem";
            this.scriptwiseProfitLossToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.scriptwiseProfitLossToolStripMenuItem.Text = "Script-wise Profit && Loss";
            this.scriptwiseProfitLossToolStripMenuItem.Click += new System.EventHandler(this.ScriptwiseProfitLossMenu_Click);
            // 
            // currentHoldingsToolStripMenuItem
            // 
            this.currentHoldingsToolStripMenuItem.Name = "currentHoldingsToolStripMenuItem";
            this.currentHoldingsToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.currentHoldingsToolStripMenuItem.Text = "Current Holdings";
            this.currentHoldingsToolStripMenuItem.Click += new System.EventHandler(this.CurrentHoldingsMenu_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F5";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.refreshToolStripMenuItem.Text = "&Refresh";
            this.refreshToolStripMenuItem.ToolTipText = "Refresh ";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.RefreshMenuItem_Click);
            // 
            // gvHoldings
            // 
            this.gvHoldings.AllowUserToAddRows = false;
            this.gvHoldings.AllowUserToDeleteRows = false;
            this.gvHoldings.AllowUserToResizeRows = false;
            this.gvHoldings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvHoldings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvHoldings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvHoldings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvHoldings.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvHoldings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvHoldings.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gvHoldings.Location = new System.Drawing.Point(0, 212);
            this.gvHoldings.Margin = new System.Windows.Forms.Padding(4);
            this.gvHoldings.MultiSelect = false;
            this.gvHoldings.Name = "gvHoldings";
            this.gvHoldings.ReadOnly = true;
            this.gvHoldings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvHoldings.ShowCellErrors = false;
            this.gvHoldings.ShowCellToolTips = false;
            this.gvHoldings.ShowEditingIcon = false;
            this.gvHoldings.ShowRowErrors = false;
            this.gvHoldings.Size = new System.Drawing.Size(1200, 342);
            this.gvHoldings.TabIndex = 1;
            this.gvHoldings.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 554);
            this.Controls.Add(this.gvHoldings);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "SBI Financial Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHoldings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem digitalContractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllContractsMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewContractMenu;
        private System.Windows.Forms.ToolStripMenuItem scriptsMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageScriptsMenu;
        private System.Windows.Forms.ToolStripMenuItem dematTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridView gvHoldings;
        private System.Windows.Forms.ToolStripMenuItem scriptwiseProfitLossToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentHoldingsToolStripMenuItem;
    }
}

