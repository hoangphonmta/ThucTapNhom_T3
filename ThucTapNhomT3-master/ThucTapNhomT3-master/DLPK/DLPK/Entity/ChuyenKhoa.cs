using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLPK.Entity
{
    public class ChuyenKhoa
    {
        private int _MaKhoa;
        private string _TenKhoa;
        public ChuyenKhoa()
        {
            _MaKhoa = -1;
            _TenKhoa = "";
        }
        public ChuyenKhoa(DataRow row)
        {
            this._MaKhoa = (int)row["MaKhoa"];
            this._TenKhoa = row["TenKhoa"].ToString();
        }
        public ChuyenKhoa(int MaKhoa, string TenKhoa)
        {
            this._MaKhoa = MaKhoa;
            this._TenKhoa = TenKhoa;
        }
        public int MaKhoa
        {
            set
            {
                this._MaKhoa = value;
            }
            get
            {
                return this._MaKhoa;
            }
        }
        public string TenKhoa
        {
            set
            {
                this._TenKhoa = value;
            }
            get
            {
                return this._TenKhoa;
            }
        }
    }
}
