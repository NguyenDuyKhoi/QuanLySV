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

        private void FormMain_Load_1(object sender, EventArgs e)
        {

            dgvData.DataSource = new DataProvider().SelectData("exec SelectAllSinhVien");
            dgvData.Columns["masinhvien"].HeaderText = "Mã SV";
            dgvData.Columns["hoten"].HeaderText = "Họ và tên";
            dgvData.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvData.Columns["gt"].HeaderText = "Giới tính";
            dgvData.Columns["quequan"].HeaderText = "Quê quán";
            dgvData.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvData.Columns["dienthoai"].HeaderText = "Số điện thoại";
            dgvData.Columns["email"].HeaderText = "Email";
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvData.Rows[e.RowIndex].Cells["masinhvien"].Value.ToString();
                new frmSinhVien(msv).ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmSinhVien(null).ShowDialog();
        }
    }
}