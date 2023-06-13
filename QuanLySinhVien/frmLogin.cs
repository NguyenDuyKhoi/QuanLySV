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
        public string tentaikhoan = "";

        public string loaitk;

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            #region ktra
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }
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
            #endregion
            tentaikhoan = textBox1.Text;
            loaitk = "";
            #region swtk
            switch (comboBox1.Text)
            {
                case "Quản trị viên":
                    loaitk = "admin";
                    break;

                case "Giáo viên":
                    loaitk = "gv";
                    break;

            }
            #endregion


            List<CustomPameters> lst = new List<CustomPameters>()
            {
                 new CustomPameters()
                {
                    key="@loaitaikhoan",
                    value=loaitk
                },
                new CustomPameters()
                {
                    key="@tentaikhoan",
                    value=textBox1.Text
                },
                 new CustomPameters()
                {
                    key="@matkhau",
                    value=textBox2.Text
                },
            };
            var rs = new DataProvider().SelectData("dangnhap", lst);
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");

                this.Hide();

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
