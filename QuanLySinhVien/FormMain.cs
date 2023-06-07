using System.Security.Cryptography;

namespace QuanLySinhVien
{
    public partial class frmDDSV : Form
    {
        public frmDDSV()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {


        }
        private string tukhoa = "";
        private void FormMain_Load_1(object sender, EventArgs e)
        {

            LoadDSSV();

        }

        private void LoadDSSV()
        {
            List<CustomPameters> lstPara = new List<CustomPameters>();
            lstPara.Add(new CustomPameters()
            {
                key = "@tukhoa",
                value = tukhoa
            });


            dgvData.DataSource = new DataProvider().SelectData("SelectAllSinhVien", lstPara);

        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvData.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                new frmSinhVien(msv).ShowDialog();
                LoadDSSV();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();
            LoadDSSV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDSSV();
            tukhoa = textBox1.Text;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvData.Columns["btnDelete"].Index)
                {
                    if (
                        MessageBox.Show(
                            "Bạn có chắc chắn muốn xóa sinh viên:" + dgvData.Rows[e.RowIndex].Cells["hoten"].Value.ToString() + "?"
                            , "Xác nhận xóa!!!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var maSV = dgvData.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                        var sql = "deleteSV";
                        var lstPara = new List<CustomPameters>()
                    {
                        new CustomPameters
                        {
                            key="@masinhvien",
                            value= maSV
                        }
                    };
                        var result = new DataProvider().ExeCute(sql, lstPara);
                        if (result == 1)
                        {
                            MessageBox.Show("Xóa sinh viên thành công");
                            LoadDSSV();
                        }

                    }
                }
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}