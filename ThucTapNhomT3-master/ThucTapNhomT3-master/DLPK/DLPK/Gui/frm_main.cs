using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLPK.Gui;
namespace DLPK
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btn_ck_Click(object sender, EventArgs e)
        {
            frm_chuyenkhoa ck = new frm_chuyenkhoa();
            this.Hide();
            ck.ShowDialog();
            this.Show();
        }

        private void btn_bs_Click(object sender, EventArgs e)
        {
            frmBacSi bacsi = new frmBacSi();
            this.Hide();
            bacsi.ShowDialog();
            this.Show();
        }
    }
}
