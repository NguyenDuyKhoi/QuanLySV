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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmAccount_Load(object sender, EventArgs e)
        {

        }
        private void LoadDDSV()
        {
            List<CustomPameters> lstPara = new List<CustomPameters>();
            dataGridView1.DataSource = new DataProvider().SelectData("SelectAccount", lstPara);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msd = dataGridView1.Rows[e.RowIndex].Cells["tentaikhoan"].Value.ToString();
                new updateTK(msd).ShowDialog();
                LoadDDSV();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new updateTK(null).ShowDialog();
            LoadDDSV();
        }
    }
}
