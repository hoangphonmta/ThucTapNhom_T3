using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DLPK.Entity
{
    public class BacSi
    {
        private int _MaBS;
        private string _TenBS;
        private string _ChucVu;
        private int _GiaTien;
        private int _MaPK;
        private int _MaKhoa;
        private string _GhiChu;
        private string _TenKhoa;
        public BacSi()
        {
            _MaBS = -1;
            _TenBS = "";
            _ChucVu = "";
            _GiaTien = -1;
            _MaPK = -1;
            _MaKhoa = -1;
            _GhiChu = "";
            _TenKhoa = "";
        }
        public BacSi(int MaBS,string TenBS,string ChucVu,int GiaTien,int MaPK,int MaKhoa,string GhiChu,string TenKhoa)
        {
            this._MaBS = MaBS;
            this._TenBS = TenBS;
            this._ChucVu = ChucVu;
            this._GiaTien = GiaTien;
            this._MaPK = MaPK;
            this._MaKhoa = MaKhoa;
            this._GhiChu = GhiChu;
            this._TenKhoa = TenKhoa;
        }
        public BacSi(DataRow row)
        {
            this._TenBS = row["TenBS"].ToString();
            this._TenKhoa = row["TenKhoa"].ToString();
        }
        public int MaBS
        {
            set
            {
                this._MaBS = value;
            }
            get
            {
                return this._MaBS;
            }
        }
        public string TenBS
        {
            set
            {
                this._TenBS = value;
            }
            get
            {
                return this._TenBS;
            }
        }
        public string ChucVu
        {
            set
            {
                this._ChucVu = value;
            }
            get
            {
                return this._ChucVu;
            }
        }
        public int GiaTien
        {
            set
            {
                this._GiaTien = value;
            }
            get
            {
                return this._GiaTien;
            }
        }
        public int MaPK
        {
            set
            {
                this._MaPK = value;
            }
            get
            {
                return this._MaPK;
            }
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
        public string GhiChu
        {
            set
            {
                this._GhiChu = value;
            }
            get
            {
                return this._GhiChu;
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
