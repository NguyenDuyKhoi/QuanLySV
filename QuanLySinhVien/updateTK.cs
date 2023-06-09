using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLySinhVien
{
    public partial class updateTK : Form
    {
        public updateTK(string msd)
        {
            InitializeComponent();
            this.msd = msd;
        }
        private string msd;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void updateTK_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msd))
            {
                this.Text = "Thêm mới tài khoản";

            }
            else
            {
                this.Text = "Cập nhập thông tin tài khoản";
                var r = new DataProvider().Select("selectAccount '" + msd + "'");
                // MessageBox.Show(r[0].ToString());
                textBox1.Text = r["tentaikhoan"].ToString();
                textBox2.Text = r["matkhau"].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            string tentaikhoan = textBox1.Text;
            string matkhau = textBox2.Text;
            List<CustomPameters> lstPara = new List<CustomPameters>();
            if (string.IsNullOrEmpty(msd))
            {
                sql = "ThemMoiAccount";

            }
            else
            {
                sql = "updateAccount";
                lstPara.Add(new CustomPameters()
                {
                    key = "@mataikhoan",
                    value = msd
                });
            }
            lstPara.Add(new CustomPameters()
            {
                key = "@tentaikhoan",
                value = tentaikhoan
            });
            lstPara.Add(new CustomPameters()
            {
                key = "@matkhau",
                value = matkhau
            });

            var rs = new DataProvider().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msd))
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhập thông tin sinh viên thành công");
                }
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
