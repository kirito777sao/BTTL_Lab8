namespace _21103100849_TranDucHoan
{
    partial class Form1
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
            this.btTTKH_0849 = new System.Windows.Forms.ToolStripMenuItem();
            this.btTTMH_0849 = new System.Windows.Forms.ToolStripMenuItem();
            this.btCTBH_0849 = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btTKKH_0849 = new System.Windows.Forms.ToolStripMenuItem();
            this.btTKMH_0849 = new System.Windows.Forms.ToolStripMenuItem();
            this.btTKBH_0849 = new System.Windows.Forms.ToolStripMenuItem();
            this.btThoat_0849 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btTTKH_0849,
            this.btTTMH_0849,
            this.btCTBH_0849,
            this.tìmKiếmToolStripMenuItem,
            this.btThoat_0849});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btTTKH_0849
            // 
            this.btTTKH_0849.Name = "btTTKH_0849";
            this.btTTKH_0849.Size = new System.Drawing.Size(142, 20);
            this.btTTKH_0849.Text = "Thông Tin Khách Hàng";
            this.btTTKH_0849.Click += new System.EventHandler(this.btTTKH_0849_Click);
            // 
            // btTTMH_0849
            // 
            this.btTTMH_0849.Name = "btTTMH_0849";
            this.btTTMH_0849.Size = new System.Drawing.Size(130, 20);
            this.btTTMH_0849.Text = "Thông Tin Mặt Hàng";
            this.btTTMH_0849.Click += new System.EventHandler(this.btTTMH_0849_Click);
            // 
            // btCTBH_0849
            // 
            this.btCTBH_0849.Name = "btCTBH_0849";
            this.btCTBH_0849.Size = new System.Drawing.Size(115, 20);
            this.btCTBH_0849.Text = "Chi Tiết Bán Hàng";
            this.btCTBH_0849.Click += new System.EventHandler(this.btCTBH_0849_Click);
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btTKKH_0849,
            this.btTKMH_0849,
            this.btTKBH_0849});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm Kiếm";
            // 
            // btTKKH_0849
            // 
            this.btTKKH_0849.Name = "btTKKH_0849";
            this.btTKKH_0849.Size = new System.Drawing.Size(193, 22);
            this.btTKKH_0849.Text = "Tìm Kiếm Khách Hàng";
            this.btTKKH_0849.Click += new System.EventHandler(this.btTKKH_0849_Click);
            // 
            // btTKMH_0849
            // 
            this.btTKMH_0849.Name = "btTKMH_0849";
            this.btTKMH_0849.Size = new System.Drawing.Size(193, 22);
            this.btTKMH_0849.Text = "Tìm Kiếm Mặt Hàng";
            this.btTKMH_0849.Click += new System.EventHandler(this.btTKMH_0849_Click);
            // 
            // btTKBH_0849
            // 
            this.btTKBH_0849.Name = "btTKBH_0849";
            this.btTKBH_0849.Size = new System.Drawing.Size(193, 22);
            this.btTKBH_0849.Text = "Tìm Kiếm Bán Hàng";
            this.btTKBH_0849.Click += new System.EventHandler(this.btTKBH_0849_Click);
            // 
            // btThoat_0849
            // 
            this.btThoat_0849.Name = "btThoat_0849";
            this.btThoat_0849.Size = new System.Drawing.Size(50, 20);
            this.btThoat_0849.Text = "Thoát";
            this.btThoat_0849.Click += new System.EventHandler(this.btThoat_0849_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_21103100849_TranDucHoan.Properties.Resources._464622534_538443725791892_1110756144527758650_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btTTKH_0849;
        private System.Windows.Forms.ToolStripMenuItem btTTMH_0849;
        private System.Windows.Forms.ToolStripMenuItem btCTBH_0849;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btTKKH_0849;
        private System.Windows.Forms.ToolStripMenuItem btTKMH_0849;
        private System.Windows.Forms.ToolStripMenuItem btThoat_0849;
        private System.Windows.Forms.ToolStripMenuItem btTKBH_0849;
    }
}

