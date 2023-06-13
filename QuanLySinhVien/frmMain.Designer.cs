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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            dSSinhViênToolStripMenuItem = new ToolStripMenuItem();
            dSTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thayToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 615);
            panel1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1176, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dSSinhViênToolStripMenuItem, dSTàiKhoảnToolStripMenuItem, thayToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(60, 24);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // dSSinhViênToolStripMenuItem
            // 
            dSSinhViênToolStripMenuItem.Name = "dSSinhViênToolStripMenuItem";
            dSSinhViênToolStripMenuItem.Size = new Size(177, 26);
            dSSinhViênToolStripMenuItem.Text = "DS Sinh Viên";
            dSSinhViênToolStripMenuItem.Click += dSSinhViênToolStripMenuItem_Click;
            // 
            // dSTàiKhoảnToolStripMenuItem
            // 
            dSTàiKhoảnToolStripMenuItem.Name = "dSTàiKhoảnToolStripMenuItem";
            dSTàiKhoảnToolStripMenuItem.Size = new Size(224, 26);
            dSTàiKhoảnToolStripMenuItem.Text = "DS Tài khoảnGV";
            dSTàiKhoảnToolStripMenuItem.Click += dSTàiKhoảnToolStripMenuItem_Click;
            // 
            // thayToolStripMenuItem
            // 
            thayToolStripMenuItem.Name = "thayToolStripMenuItem";
            thayToolStripMenuItem.Size = new Size(177, 26);
            thayToolStripMenuItem.Text = "Thay đổi";
            thayToolStripMenuItem.Click += thayToolStripMenuItem_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 701);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            MainMenuStrip = menuStrip1;
            Name = "frmMain";
            Text = "Menu";
            Load += frmMain_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem dSSinhViênToolStripMenuItem;
        private ToolStripMenuItem dSTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thayToolStripMenuItem;
    }
}