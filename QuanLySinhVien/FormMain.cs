namespace QuanLySinhVien
{
    public partial class FormMain : Form
    {
        public FormMain()
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
            dgvData.Columns["masinhvien"].HeaderText = "Mã SV";
            dgvData.Columns["hoten"].HeaderText = "Họ và tên";
            dgvData.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvData.Columns["gt"].HeaderText = "Giới tính";
            dgvData.Columns["quequan"].HeaderText = "Quê quán";
            dgvData.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvData.Columns["dienthoai"].HeaderText = "Số điện thoại";
            dgvData.Columns["email"].HeaderText = "Email";
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
    }
}