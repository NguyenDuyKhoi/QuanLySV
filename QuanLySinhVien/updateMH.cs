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
    public partial class updateMH : Form
    {
        public updateMH(string mamh)
        {
            InitializeComponent();
            this.mamh = mamh;
        }
        private string mamh;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void updateMH_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mamh))
            {
                this.Text = "Thêm mới môn học";
            }
            else
            {
                this.Text = "Cập nhập môn học";
                var r = new DataProvider().Select("selectMonHoc '" + mamh + "'");
                // MessageBox.Show(r[0].ToString());
                textBox1.Text = r["temmonhoc"].ToString();
                textBox2.Text = r["sotinchi"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var stc=int.Parse(textBox2.Text);
                if (stc <= 0)
                {
                    MessageBox.Show("Số tín chỉ phải lớn hơn 0 ");
                    textBox2.Select();
                    return;
                }
            }
            catch 
            {
                MessageBox.Show("Số tín chỉ phải là kiểu số nguyên ");
                textBox2.Select();
                return;
            }
            if(string.IsNullOrEmpty(textBox1.Text)) 
            {
                MessageBox.Show("Tên học không được để trống");
                textBox2.SelectAll(); 
                return;
            }
            string sql = "";
            List<CustomPameters> lstPara = new List<CustomPameters>();
            if (string.IsNullOrEmpty(mamh))
            {
                sql = "insertMonHoc";
            }
            else
            {
                sql = "updateMH";
                lstPara.Add(new CustomPameters()
                {
                    key = "@mamonhoc",
                    value = mamh
                });
            }
            lstPara.Add(new CustomPameters()
            {
                key = "@tenmonhoc",
                value = textBox1.Text
            });
            lstPara.Add(new CustomPameters()
            {
                key = "@sotinchi",
                value = textBox2.Text
            });
            var rs = new DataProvider().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mamh))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhập môn học thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }
    }
}
