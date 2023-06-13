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
    public partial class updatePassword : Form
    {
        public updatePassword()
        {
            InitializeComponent();
        }

        private void updatePassword_Load(object sender, EventArgs e)
        {
            this.Text = "Cập nhập thông tin tài khoản";


            var rs = new DataProvider().Select("selectAllAccountAdmin");
            // MessageBox.Show(r[0].ToString());
            textBox1.Text = rs["taikhoan"].ToString();
            textBox2.Text = rs["matkhau"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql = "";
            string taikhoan = textBox1.Text;
            string matkhau = textBox2.Text;
            sql = "updateAccountAdmin";
            List<CustomPameters> lstPara = new List<CustomPameters>();


            lstPara.Add(new CustomPameters()
            {
                key = "@tentaikhoan",
                value = taikhoan
            });

            lstPara.Add(new CustomPameters()
            {
                key = "@matkhau",
                value = matkhau
            });
            var rs = new DataProvider().ExeCute(sql, lstPara);
            if (rs == 1)
            {



                MessageBox.Show("Cập nhập thông tin tài khoản thành công");

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
