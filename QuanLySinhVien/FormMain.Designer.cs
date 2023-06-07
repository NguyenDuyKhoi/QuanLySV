namespace QuanLySinhVien
{
    partial class frmDDSV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            btnDelete = new DataGridViewButtonColumn();
            email = new DataGridViewTextBoxColumn();
            dienthoai = new DataGridViewTextBoxColumn();
            diachi = new DataGridViewTextBoxColumn();
            quequan = new DataGridViewTextBoxColumn();
            gt = new DataGridViewTextBoxColumn();
            ngaysinh = new DataGridViewTextBoxColumn();
            hoten = new DataGridViewTextBoxColumn();
            masinhvien = new DataGridViewTextBoxColumn();
            dgvData = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(680, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 66);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(377, 16);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Thêm mới";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(277, 14);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.Enter += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(71, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 18);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Từ khóa";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1178, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.Text = "Xóa";
            btnDelete.UseColumnTextForButtonValue = true;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // dienthoai
            // 
            dienthoai.DataPropertyName = "dienthoai";
            dienthoai.HeaderText = "Điện thoại";
            dienthoai.MinimumWidth = 6;
            dienthoai.Name = "dienthoai";
            // 
            // diachi
            // 
            diachi.DataPropertyName = "diachi";
            diachi.HeaderText = "Địa chỉ";
            diachi.MinimumWidth = 6;
            diachi.Name = "diachi";
            // 
            // quequan
            // 
            quequan.DataPropertyName = "quequan";
            quequan.HeaderText = "Quê quán";
            quequan.MinimumWidth = 6;
            quequan.Name = "quequan";
            // 
            // gt
            // 
            gt.DataPropertyName = "gt";
            gt.HeaderText = "Giới tính";
            gt.MinimumWidth = 6;
            gt.Name = "gt";
            // 
            // ngaysinh
            // 
            ngaysinh.DataPropertyName = "ngaysinh";
            ngaysinh.HeaderText = "Ngày sinh";
            ngaysinh.MinimumWidth = 6;
            ngaysinh.Name = "ngaysinh";
            // 
            // hoten
            // 
            hoten.DataPropertyName = "hoten";
            hoten.HeaderText = "Họ và tên";
            hoten.MinimumWidth = 6;
            hoten.Name = "hoten";
            // 
            // masinhvien
            // 
            masinhvien.DataPropertyName = "masinhvien";
            masinhvien.HeaderText = "Mã sinh viên";
            masinhvien.MinimumWidth = 6;
            masinhvien.Name = "masinhvien";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { masinhvien, hoten, ngaysinh, gt, quequan, diachi, dienthoai, email, btnDelete });
            dgvData.Location = new Point(-10, 110);
            dgvData.Name = "dgvData";
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(1188, 748);
            dgvData.TabIndex = 0;
            dgvData.CellClick += dgvData_CellClick;
            dgvData.CellContentClick += dgvData_CellContentClick;
            dgvData.CellDoubleClick += dgvData_CellDoubleClick;
            // 
            // frmDDSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 701);
            Controls.Add(dgvData);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmDDSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private MenuStrip menuStrip1;
        private DataGridViewButtonColumn btnDelete;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn dienthoai;
        private DataGridViewTextBoxColumn diachi;
        private DataGridViewTextBoxColumn quequan;
        private DataGridViewTextBoxColumn gt;
        private DataGridViewTextBoxColumn ngaysinh;
        private DataGridViewTextBoxColumn hoten;
        private DataGridViewTextBoxColumn masinhvien;
        private DataGridView dgvData;
    }
}