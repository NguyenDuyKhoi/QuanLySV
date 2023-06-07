using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string matkhau = "";
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản!!!");
                textBox1.Select();
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!!!");
                textBox2.Select();
                return;
            }
            tendangnhap = textBox1.Text;

            List<CustomPameters> lst = new List<CustomPameters>()
            {
                new CustomPameters()
                {
                    key="@taikhoan",
                    value=textBox1.Text,
                },
                 new CustomPameters()
                {
                    key="@matkhau",
                    value=textBox2.Text,
                },
            };
            var rs = new DataProvider().SelectData("dangnhap", lst);
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                frmMain f = new frmMain();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tài khoản hoặc mật khẩu", "Tài khoản hoặc mật khẩu không hợp lệ");
            }

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
