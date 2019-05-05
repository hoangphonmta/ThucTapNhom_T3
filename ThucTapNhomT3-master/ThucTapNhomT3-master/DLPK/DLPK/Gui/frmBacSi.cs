using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DLPK.BLL;
using DLPK.Entity;

namespace DLPK.Gui
{
    
    public partial class frmBacSi : Form
    {
        private string _TenKhoa;
        BacSiBLL Bacsi = new BacSiBLL();
        public frmBacSi()
        {
            InitializeComponent();
            Load_BacSi();
        }
        void Load_BacSi()
        {
            ChuyenKhoa chuyenKhoa = new ChuyenKhoa(-1, _TenKhoa);
            List<BacSi> ListBacSi = Bacsi.BacSi_Select(chuyenKhoa);
            foreach (BacSi item in ListBacSi)
            {
                lsvBacSi.Items.Add(item.TenBS);
            }
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
        public frmBacSi(string TenKhoa) : this()
        {
            _TenKhoa = TenKhoa;
        }
    }
}
