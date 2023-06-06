namespace QuanLySinhVien
{
    partial class FormMain
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
            dgvData = new DataGridView();
            masinhvien = new DataGridViewTextBoxColumn();
            hoten = new DataGridViewTextBoxColumn();
            ngaysinh = new DataGridViewTextBoxColumn();
            gt = new DataGridViewTextBoxColumn();
            quequan = new DataGridViewTextBoxColumn();
            diachi = new DataGridViewTextBoxColumn();
            dienthoai = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(572, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 66);
            panel1.TabIndex = 1;
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
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Từ khóa";
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Columns.AddRange(new DataGridViewColumn[] { masinhvien, hoten, ngaysinh, gt, quequan, diachi, dienthoai, email, btnDelete });
            dgvData.Location = new Point(-2, 84);
            dgvData.Name = "dgvData";
            dgvData.ReadOnly = true;
            dgvData.RowHeadersWidth = 51;
            dgvData.RowTemplate.Height = 29;
            dgvData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvData.Size = new Size(1180, 371);
            dgvData.TabIndex = 0;
            dgvData.CellClick += dgvData_CellClick;
            dgvData.CellDoubleClick += dgvData_CellDoubleClick;
            // 
            // masinhvien
            // 
            masinhvien.DataPropertyName = "masinhvien";
            masinhvien.HeaderText = "Mã sinh vien";
            masinhvien.MinimumWidth = 6;
            masinhvien.Name = "masinhvien";
            masinhvien.ReadOnly = true;
            masinhvien.Width = 125;
            // 
            // hoten
            // 
            hoten.DataPropertyName = "hoten";
            hoten.HeaderText = "Họ và tên";
            hoten.MinimumWidth = 6;
            hoten.Name = "hoten";
            hoten.ReadOnly = true;
            hoten.Width = 125;
            // 
            // ngaysinh
            // 
            ngaysinh.DataPropertyName = "ngaysinh";
            ngaysinh.HeaderText = "Ngày sinh";
            ngaysinh.MinimumWidth = 6;
            ngaysinh.Name = "ngaysinh";
            ngaysinh.ReadOnly = true;
            ngaysinh.Width = 125;
            // 
            // gt
            // 
            gt.DataPropertyName = "gt";
            gt.HeaderText = "Giới tính";
            gt.MinimumWidth = 6;
            gt.Name = "gt";
            gt.ReadOnly = true;
            gt.Width = 125;
            // 
            // quequan
            // 
            quequan.DataPropertyName = "quequan";
            quequan.HeaderText = "Quê quán";
            quequan.MinimumWidth = 6;
            quequan.Name = "quequan";
            quequan.ReadOnly = true;
            quequan.Width = 125;
            // 
            // diachi
            // 
            diachi.DataPropertyName = "diachi";
            diachi.HeaderText = "Địa chỉ";
            diachi.MinimumWidth = 6;
            diachi.Name = "diachi";
            diachi.ReadOnly = true;
            diachi.Width = 125;
            // 
            // dienthoai
            // 
            dienthoai.DataPropertyName = "dienthoai";
            dienthoai.HeaderText = "Điện thoại";
            dienthoai.MinimumWidth = 6;
            dienthoai.Name = "dienthoai";
            dienthoai.ReadOnly = true;
            dienthoai.Width = 125;
            // 
            // email
            // 
            email.DataPropertyName = "email";
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 125;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.ReadOnly = true;
            btnDelete.Text = "Xóa";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 125;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1201, 450);
            Controls.Add(dgvData);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private DataGridView dgvData;
        private DataGridViewTextBoxColumn masinhvien;
        private DataGridViewTextBoxColumn hoten;
        private DataGridViewTextBoxColumn ngaysinh;
        private DataGridViewTextBoxColumn gt;
        private DataGridViewTextBoxColumn quequan;
        private DataGridViewTextBoxColumn diachi;
        private DataGridViewTextBoxColumn dienthoai;
        private DataGridViewTextBoxColumn email;
        private DataGridViewButtonColumn btnDelete;
    }
}