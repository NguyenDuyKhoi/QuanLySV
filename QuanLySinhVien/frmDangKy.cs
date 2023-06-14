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
    public partial class frmDangKy : Form
    {
        private string masv;
        public frmDangKy(string masv)
        {
            InitializeComponent();
            this.masv = masv;
        }

        private void frmDangKy_Load(object sender, EventArgs e)
        {
            LoadMonDangKy();
        }
        private void LoadMonDangKy()
        {
            List<CustomPameters> lst = new List<CustomPameters>()
            {
                new CustomPameters()
                {
                     key="@masinhvien",
                     value=masv
                }
            };
            dataGridView1.DataSource = new DataProvider().SelectData("MonDangKy", lst);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var f= new frmDangKyMonHoc(masv); f.ShowDialog();
            LoadMonDangKy();
        }
    }
}
