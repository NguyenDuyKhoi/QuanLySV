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
    public partial class frmDangKyMonHoc : Form
    {
        public frmDangKyMonHoc(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
        private string msv;
        private void frmDangKyMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSDK();
        }
        private void LoadDSDK()
        {
            List<CustomPameters> lstPara = new List<CustomPameters>();
            lstPara.Add(new CustomPameters()
            {
                key = "@masinhvien",
                value = msv,
            });
            dataGridView1.DataSource = new DataProvider().SelectData("MonHocChuaDangKy", lstPara);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Index>=0)
            {
                if(
                    DialogResult.Yes==
                    MessageBox.Show(
                        "Bạn muốn đăng ký học phần[" + dataGridView1.Rows[e.RowIndex].Cells["temmonhoc"].Value.ToString()+"]?",
                        "Xác nhận đăng ký",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question))
                {
                    List<CustomPameters> lstPara=new List<CustomPameters>();
                    lstPara.Add(new CustomPameters()
                    {
                        key = "@masinhvien",
                        value = msv,
                    });
                    lstPara.Add(new CustomPameters()
                    {
                        key = "@mamonhoc",
                        value=dataGridView1.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString()
                    });
                    var rs = new DataProvider().ExeCute("đkyhoc", lstPara);
                    if(rs==-1)
                    {
                        MessageBox.Show("Học phần này bạn đã đăng ký ", "Cảnh báo!!!");
                        return;
                    }
                    if (rs == 1) 
                    {
                        MessageBox.Show("Đã đăng ký học phần thành công ", "Cảnh báo!!!");
                        LoadDSDK();
                    }
                }    

            }    
        }
    }
}
