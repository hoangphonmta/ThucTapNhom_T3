using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLPK.Entity;
using DLPK.BLL;
namespace DLPK.Gui
{
    
    public partial class frm_chuyenkhoa : Form
    {
        BindingSource Khoa = new BindingSource();
        ChuyenKhoaBLL chuyenkhoaBLL = new ChuyenKhoaBLL();
        BacSiBLL bacSi = new BacSiBLL();
        public frm_chuyenkhoa()
        {
            InitializeComponent();
            LoadChuyenKhoa();
        }
        public void LoadChuyenKhoa()
        {
            List<ChuyenKhoa> ListChuyenKhoa = chuyenkhoaBLL.ChuyenKhoa_Select();
            foreach(ChuyenKhoa item in ListChuyenKhoa)
            {
                lvChuyenKhoa.Items.Add(item.TenKhoa);
            }
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            this.Close();
        }

        private void lvChuyenKhoa_MouseClick(object sender, MouseEventArgs e)
        {
            string TenKhoa = lvChuyenKhoa.SelectedItems[0].Text;
            frmBacSi bacSi = new frmBacSi(TenKhoa);
            bacSi.Show();
            //MessageBox.Show(lvChuyenKhoa.SelectedItems[0].Text);
        }
    }
}
