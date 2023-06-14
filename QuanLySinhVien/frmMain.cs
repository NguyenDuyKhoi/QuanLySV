using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private string loaitk;
        private string taikhoan;
        private void frmMain_Load(object sender, EventArgs e)
        {
            var fn = new frmLogin();
            fn.ShowDialog();
            var button = fn.button1_Click;
            taikhoan = fn.tentaikhoan;
            loaitk = fn.loaitk;
            
            if (loaitk.Equals("admin"))
            {

                dSSinhViênToolStripMenuItem.Visible = false;
                dSMônHọcToolStripMenuItem.Visible = false;
            }
            else
            {
                dSTàiKhoảnToolStripMenuItem.Visible = false;
                thayToolStripMenuItem.Visible = false;
                if (loaitk.Equals("gv"))
                {

                }
                else
                {
                    dSSinhViênToolStripMenuItem.Visible = false;
                    dSMônHọcToolStripMenuItem.Visible = false;
                }
            }
           








        }
        private void AddForm(Form f)
        {
            this.panel1.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(f);
            f.Show();
        }





        private void dSSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDDSV f = new frmDDSV();
            AddForm(f);
        }

        private void dSTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount f = new frmAccount();
            AddForm(f);
        }

        private void thayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updatePassword f = new updatePassword();
            f.ShowDialog();

        }

        private void dSMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc f = new frmMonHoc();
            AddForm(f);
        }

        private void ĐăngKýStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new frmDangKy(taikhoan);
            AddForm(f);
        }


    }
}
