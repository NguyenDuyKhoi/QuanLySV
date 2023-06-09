using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLySinhVien
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }
        private string tukhoa = "";
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadDDSV();
        }
        private void LoadDDSV()
        {
            List<CustomPameters> lstPara = new List<CustomPameters>();
            lstPara.Add(new CustomPameters()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dataGridView1.DataSource = new DataProvider().SelectData("SelectAllAccount", lstPara);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msd = dataGridView1.Rows[e.RowIndex].Cells["mataikhoan"].Value.ToString();
                new updateTK(msd).ShowDialog();
                LoadDDSV();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new updateTK(null).ShowDialog();
            LoadDDSV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDDSV();
            tukhoa = textBox1.Text;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index)
                {
                    if (
                        MessageBox.Show(
                            "Bạn có chắc chắn muốn xóa sinh viên:" + dataGridView1.Rows[e.RowIndex].Cells["tentaikhoan"].Value.ToString() + "?"
                            , "Xác nhận xóa!!!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var maSV = dataGridView1.Rows[e.RowIndex].Cells["mataikhoan"].Value.ToString();
                        var sql = "deleteAccount";
                        var lstPara = new List<CustomPameters>()
                    {
                        new CustomPameters
                        {
                            key="@mataikhoan",
                            value= maSV
                        }
                    };
                        var result = new DataProvider().ExeCute(sql, lstPara);
                        if (result == 1)
                        {
                            MessageBox.Show("Xóa sinh viên thành công");
                            LoadDDSV();
                        }

                    }
                }
            }
        }
    }
}
