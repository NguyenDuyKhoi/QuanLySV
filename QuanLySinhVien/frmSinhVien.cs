using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
