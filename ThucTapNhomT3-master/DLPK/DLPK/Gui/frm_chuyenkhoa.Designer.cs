namespace DLPK.Gui
{
    partial class frm_chuyenkhoa
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
            this.pnl_head = new System.Windows.Forms.Panel();
            this.pnl_mainCK = new System.Windows.Forms.Panel();
            this.menu_head = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dànhChoBệnhNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dànhChoBácSĩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_danhsachBSCK = new System.Windows.Forms.Panel();
            this.pnl_thongtinCK = new System.Windows.Forms.Panel();
            this.pnl_head.SuspendLayout();
            this.pnl_mainCK.SuspendLayout();
            this.menu_head.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnl_head.Controls.Add(this.menu_head);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(800, 53);
            this.pnl_head.TabIndex = 0;
            // 
            // pnl_mainCK
            // 
            this.pnl_mainCK.Controls.Add(this.pnl_thongtinCK);
            this.pnl_mainCK.Controls.Add(this.pnl_danhsachBSCK);
            this.pnl_mainCK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_mainCK.Location = new System.Drawing.Point(0, 53);
            this.pnl_mainCK.Name = "pnl_mainCK";
            this.pnl_mainCK.Size = new System.Drawing.Size(800, 397);
            this.pnl_mainCK.TabIndex = 1;
            // 
            // menu_head
            // 
            this.menu_head.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_head.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.dànhChoBệnhNhânToolStripMenuItem,
            this.dànhChoBácSĩToolStripMenuItem});
            this.menu_head.Location = new System.Drawing.Point(234, 9);
            this.menu_head.Name = "menu_head";
            this.menu_head.Size = new System.Drawing.Size(315, 24);
            this.menu_head.TabIndex = 0;
            this.menu_head.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.trangChủToolStripMenuItem.Text = "Trang Chủ";
            // 
            // dànhChoBệnhNhânToolStripMenuItem
            // 
            this.dànhChoBệnhNhânToolStripMenuItem.Name = "dànhChoBệnhNhânToolStripMenuItem";
            this.dànhChoBệnhNhânToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.dànhChoBệnhNhânToolStripMenuItem.Text = "Dành cho bệnh nhân";
            // 
            // dànhChoBácSĩToolStripMenuItem
            // 
            this.dànhChoBácSĩToolStripMenuItem.Name = "dànhChoBácSĩToolStripMenuItem";
            this.dànhChoBácSĩToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.dànhChoBácSĩToolStripMenuItem.Text = "Dành cho Bác sĩ";
            // 
            // pnl_danhsachBSCK
            // 
            this.pnl_danhsachBSCK.BackColor = System.Drawing.Color.White;
            this.pnl_danhsachBSCK.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_danhsachBSCK.Location = new System.Drawing.Point(0, 0);
            this.pnl_danhsachBSCK.Name = "pnl_danhsachBSCK";
            this.pnl_danhsachBSCK.Size = new System.Drawing.Size(549, 397);
            this.pnl_danhsachBSCK.TabIndex = 0;
            // 
            // pnl_thongtinCK
            // 
            this.pnl_thongtinCK.BackColor = System.Drawing.Color.White;
            this.pnl_thongtinCK.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_thongtinCK.Location = new System.Drawing.Point(592, 0);
            this.pnl_thongtinCK.Name = "pnl_thongtinCK";
            this.pnl_thongtinCK.Size = new System.Drawing.Size(208, 397);
            this.pnl_thongtinCK.TabIndex = 1;
            // 
            // frm_chuyenkhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_mainCK);
            this.Controls.Add(this.pnl_head);
            this.MainMenuStrip = this.menu_head;
            this.Name = "frm_chuyenkhoa";
            this.Text = "Form3";
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.pnl_mainCK.ResumeLayout(false);
            this.menu_head.ResumeLayout(false);
            this.menu_head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_head;
        private System.Windows.Forms.MenuStrip menu_head;
        private System.Windows.Forms.Panel pnl_mainCK;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dànhChoBệnhNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dànhChoBácSĩToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_thongtinCK;
        private System.Windows.Forms.Panel pnl_danhsachBSCK;
    }
}