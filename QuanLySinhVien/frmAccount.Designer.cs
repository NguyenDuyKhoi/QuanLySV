namespace QuanLySinhVien
{
    partial class frmAccount
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
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            mataikhoan = new DataGridViewTextBoxColumn();
            tentaikhoan = new DataGridViewTextBoxColumn();
            matkhau = new DataGridViewTextBoxColumn();
            btnDelete = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(315, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(473, 66);
            panel1.TabIndex = 2;
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
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { mataikhoan, tentaikhoan, matkhau, btnDelete });
            dataGridView1.Location = new Point(12, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(774, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // mataikhoan
            // 
            mataikhoan.DataPropertyName = "mataikhoan";
            mataikhoan.HeaderText = "Mã tài khoản";
            mataikhoan.MinimumWidth = 6;
            mataikhoan.Name = "mataikhoan";
            mataikhoan.Width = 125;
            // 
            // tentaikhoan
            // 
            tentaikhoan.DataPropertyName = "tentaikhoan";
            tentaikhoan.HeaderText = "Tên đăng nhập";
            tentaikhoan.MinimumWidth = 6;
            tentaikhoan.Name = "tentaikhoan";
            tentaikhoan.Width = 150;
            // 
            // matkhau
            // 
            matkhau.DataPropertyName = "matkhau";
            matkhau.HeaderText = "Mật khẩu";
            matkhau.MinimumWidth = 6;
            matkhau.Name = "matkhau";
            matkhau.Width = 125;
            // 
            // btnDelete
            // 
            btnDelete.HeaderText = "Xóa";
            btnDelete.MinimumWidth = 6;
            btnDelete.Name = "btnDelete";
            btnDelete.Resizable = DataGridViewTriState.True;
            btnDelete.SortMode = DataGridViewColumnSortMode.Automatic;
            btnDelete.Text = "Xóa";
            btnDelete.UseColumnTextForButtonValue = true;
            btnDelete.Width = 125;
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "frmAccount";
            Text = "frmAccount";
            Load += frmAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn mataikhoan;
        private DataGridViewTextBoxColumn tentaikhoan;
        private DataGridViewTextBoxColumn matkhau;
        private DataGridViewButtonColumn btnDelete;
    }
}