using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLPK.DAO;
using DLPK.Entity;
namespace DLPK.BLL
{
    public class BacSiBLL
    {
        private static BacSiBLL instance;

        public static BacSiBLL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BacSiBLL();
                return instance;
            }
            private set { instance = value; }
        }
        public BacSiBLL() { }
        BacSiDAO Bacsi = new BacSiDAO();
        public List<BacSi> BacSi_Select(ChuyenKhoa chuyenKhoa)
        {
            return Bacsi.BacSi_Select(chuyenKhoa);
        }
    }
}
