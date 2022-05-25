
namespace src
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outcomeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revenueReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.createToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.filesToolStripMenuItem.Text = "&Files";
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiveNoteToolStripMenuItem,
            this.deliveryNoteToolStripMenuItem});
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.createToolStripMenuItem.Text = "&Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // receiveNoteToolStripMenuItem
            // 
            this.receiveNoteToolStripMenuItem.Name = "receiveNoteToolStripMenuItem";
            this.receiveNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.receiveNoteToolStripMenuItem.Text = "&Receive Note";
            this.receiveNoteToolStripMenuItem.Click += new System.EventHandler(this.receiveNoteToolStripMenuItem_Click);
            // 
            // deliveryNoteToolStripMenuItem
            // 
            this.deliveryNoteToolStripMenuItem.Name = "deliveryNoteToolStripMenuItem";
            this.deliveryNoteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deliveryNoteToolStripMenuItem.Text = "&Delivery Note";
            this.deliveryNoteToolStripMenuItem.Click += new System.EventHandler(this.deliveryNoteToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incomeReportToolStripMenuItem,
            this.outcomeReportToolStripMenuItem,
            this.revenueReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "&Report";
            this.reportToolStripMenuItem.Click += new System.EventHandler(this.reportToolStripMenuItem_Click);
            // 
            // incomeReportToolStripMenuItem
            // 
            this.incomeReportToolStripMenuItem.Name = "incomeReportToolStripMenuItem";
            this.incomeReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.incomeReportToolStripMenuItem.Text = "&Income report";
            this.incomeReportToolStripMenuItem.Click += new System.EventHandler(this.incomeReportToolStripMenuItem_Click);
            // 
            // outcomeReportToolStripMenuItem
            // 
            this.outcomeReportToolStripMenuItem.Name = "outcomeReportToolStripMenuItem";
            this.outcomeReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.outcomeReportToolStripMenuItem.Text = "&Outcome report";
            this.outcomeReportToolStripMenuItem.Click += new System.EventHandler(this.outcomeReportToolStripMenuItem_Click);
            // 
            // revenueReportToolStripMenuItem
            // 
            this.revenueReportToolStripMenuItem.Name = "revenueReportToolStripMenuItem";
            this.revenueReportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.revenueReportToolStripMenuItem.Text = "&Revenue report";
            this.revenueReportToolStripMenuItem.Click += new System.EventHandler(this.revenueReportToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 548);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiveNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outcomeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revenueReportToolStripMenuItem;
    }
}