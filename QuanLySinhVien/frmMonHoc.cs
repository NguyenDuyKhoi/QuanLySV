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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSSMH();

        }
        private string tukhoa = "";
        private void LoadDSSMH()
        {
            List<CustomPameters> lstPara = new List<CustomPameters>();
            lstPara.Add(new CustomPameters()
            {
                key = "@tukhoa1",
                value = tukhoa
            });
            dataGridView1.DataSource = new DataProvider().SelectData("selectAllMonHoc", lstPara);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamh = dataGridView1.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                new updateMH(mamh).ShowDialog();
                LoadDSSMH();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDSSMH();
            tukhoa = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new updateMH(null).ShowDialog();
            LoadDSSMH();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dataGridView1.Columns["btnDelete"].Index)
                {
                    if (
                        MessageBox.Show(
                            "Bạn có chắc chắn muốn xóa sinh viên:" + dataGridView1.Rows[e.RowIndex].Cells["temmonhoc"].Value.ToString() + "?"
                            , "Xác nhận xóa!!!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var maSV = dataGridView1.Rows[e.RowIndex].Cells["mamonhoc"].Value.ToString();
                        var sql = "deleteMH";
                        var lstPara = new List<CustomPameters>()
                    {
                        new CustomPameters
                        {
                            key="@mamonhoc",
                            value= maSV
                        }
                    };
                        var result = new DataProvider().ExeCute(sql, lstPara);
                        if (result == 1)
                        {
                            MessageBox.Show("Xóa sinh viên thành công");
                            LoadDSSMH();
                        }

                    }
                }
            }
        }
    }
}
