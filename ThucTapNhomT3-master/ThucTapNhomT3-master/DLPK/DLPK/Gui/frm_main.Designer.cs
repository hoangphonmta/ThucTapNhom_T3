namespace DLPK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_gktq = new System.Windows.Forms.Button();
            this.btn_bvpk = new System.Windows.Forms.Button();
            this.btn_bs = new System.Windows.Forms.Button();
            this.btn_ck = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.Location = new System.Drawing.Point(782, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 450);
            this.vScrollBar1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(44)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.btn_gktq);
            this.panel3.Controls.Add(this.btn_bvpk);
            this.panel3.Controls.Add(this.btn_bs);
            this.panel3.Controls.Add(this.btn_ck);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 450);
            this.panel3.TabIndex = 5;
            // 
            // btn_gktq
            // 
            this.btn_gktq.Location = new System.Drawing.Point(609, 282);
            this.btn_gktq.Name = "btn_gktq";
            this.btn_gktq.Size = new System.Drawing.Size(119, 108);
            this.btn_gktq.TabIndex = 0;
            this.btn_gktq.Text = "Chọn gói khám tổng quát";
            this.btn_gktq.UseVisualStyleBackColor = true;
            // 
            // btn_bvpk
            // 
            this.btn_bvpk.Location = new System.Drawing.Point(239, 282);
            this.btn_bvpk.Name = "btn_bvpk";
            this.btn_bvpk.Size = new System.Drawing.Size(119, 108);
            this.btn_bvpk.TabIndex = 0;
            this.btn_bvpk.Text = "Chọn Bệnh viện, Phòng khám";
            this.btn_bvpk.UseVisualStyleBackColor = true;
            // 
            // btn_bs
            // 
            this.btn_bs.Location = new System.Drawing.Point(420, 282);
            this.btn_bs.Name = "btn_bs";
            this.btn_bs.Size = new System.Drawing.Size(119, 108);
            this.btn_bs.TabIndex = 0;
            this.btn_bs.Text = "Chọn Bác sĩ";
            this.btn_bs.UseVisualStyleBackColor = true;
            this.btn_bs.Click += new System.EventHandler(this.btn_bs_Click);
            // 
            // btn_ck
            // 
            this.btn_ck.AutoSize = true;
            this.btn_ck.Location = new System.Drawing.Point(58, 282);
            this.btn_ck.Name = "btn_ck";
            this.btn_ck.Size = new System.Drawing.Size(119, 108);
            this.btn_ck.TabIndex = 0;
            this.btn_ck.Text = "Chọn Chuyên Khoa";
            this.btn_ck.UseVisualStyleBackColor = true;
            this.btn_ck.Click += new System.EventHandler(this.btn_ck_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.vScrollBar1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_gktq;
        private System.Windows.Forms.Button btn_bvpk;
        private System.Windows.Forms.Button btn_bs;
        private System.Windows.Forms.Button btn_ck;
    }
}

