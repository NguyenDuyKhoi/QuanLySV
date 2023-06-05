using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QuanLySinhVien
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien(string msv)
        {
            InitializeComponent();
            this.msv = msv;
        }
        private string msv;
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Thêm mới sinh viên";

            }
            else
            {
                this.Text = "Cập nhập thông tin sinh viên";
                var r = new DataProvider().Select("selectSV '" + msv + "'");
                // MessageBox.Show(r[0].ToString());
                textBox1.Text = r["ho"].ToString();
                textBox2.Text = r["tendem"].ToString();
                textBox8.Text = r["ten"].ToString();
                maskedTextBox1.Text = r["ngsinh"].ToString();
                if (int.Parse(r["gioitinh"].ToString()) == 1)
                {
                    radioButton1.Checked = true;
                }
                else { radioButton2.Checked = true; }
                textBox4.Text = r["quequan"].ToString();
                textBox5.Text = r["diachi"].ToString();
                textBox6.Text = r["dienthoai"].ToString();
                textBox7.Text = r["email"].ToString();
            }
        }






        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            string ho = textBox1.Text;
            string tendem = textBox2.Text;
            string ten = textBox8.Text;
            DateTime ngaysinh;
            try
            {
                ngaysinh = DateTime.ParseExact(maskedTextBox1.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
            ;
            }
            catch (Exception)
            {
                MessageBox.Show("Ngày sinh không hợp lệ:");
                maskedTextBox1.Select();
                return;
            }
            string gioitinh = radioButton1.Checked ? "1" : "0";
            string quequan = textBox4.Text;
            string diachi = textBox5.Text;
            string dienthoai = textBox6.Text;
            string email = textBox7.Text;
            List<CustomPameters> lstPara = new List<CustomPameters>();
            if (string.IsNullOrEmpty(msv))
            {
                sql = "ThemMoiSV";

            }
            else
            {
                sql = "updateSV";
                lstPara.Add(new CustomPameters()
                {
                    key = "@masinhvien",
                    value = msv
                });
            }
            lstPara.Add(new CustomPameters()
            {
                key = "@ho",
                value = ho
            });
            lstPara.Add(new CustomPameters()
            {
                key = "@tendem",
                value = tendem
            });
            lstPara.Add(new CustomPameters()
            {
                key = "@ten",
                value = ten
            });
            lstPara.Add(new CustomPameters()
            {
                key = "@ngaysinh",
                value = ngaysinh.ToString("yyyy-MM-dd")
            });
            lstPara.Add(new CustomPameters()
            {
                key = "@gioitinh",
                value = gioitinh
            });
            lstPara.Add(new CustomPameters()
            {
                key = "@quequan",
                value = quequan
            });
            lstPara.Add(new CustomPameters()
            {
                key = "@diachi",
                value = diachi
            });
            lstPara.Add(new CustomPameters()
            {
                key = "@dienthoai",
                value = dienthoai
            });
            lstPara.Add(new CustomPameters()
            {
                key = "@email",
                value = email
            });
            var rs = new DataProvider().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msv))
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
