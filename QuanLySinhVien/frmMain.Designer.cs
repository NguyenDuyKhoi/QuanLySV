namespace QuanLySinhVien
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
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            dSSinhViênToolStripMenuItem = new ToolStripMenuItem();
            dSTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1176, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dSSinhViênToolStripMenuItem, dSTàiKhoảnToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // dSSinhViênToolStripMenuItem
            // 
            dSSinhViênToolStripMenuItem.Name = "dSSinhViênToolStripMenuItem";
            dSSinhViênToolStripMenuItem.Size = new Size(179, 26);
            dSSinhViênToolStripMenuItem.Text = "DS Sinh Viên";
            dSSinhViênToolStripMenuItem.Click += dSSinhViênToolStripMenuItem_Click;
            // 
            // dSTàiKhoảnToolStripMenuItem
            // 
            dSTàiKhoảnToolStripMenuItem.Name = "dSTàiKhoảnToolStripMenuItem";
            dSTàiKhoảnToolStripMenuItem.Size = new Size(179, 26);
            dSTàiKhoảnToolStripMenuItem.Text = "DS Tài Khoản";
            dSTàiKhoảnToolStripMenuItem.Click += dSTàiKhoảnToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 673);
            panel1.TabIndex = 1;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 701);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem dSSinhViênToolStripMenuItem;
        private ToolStripMenuItem dSTàiKhoảnToolStripMenuItem;
        private Panel panel1;
    }
}