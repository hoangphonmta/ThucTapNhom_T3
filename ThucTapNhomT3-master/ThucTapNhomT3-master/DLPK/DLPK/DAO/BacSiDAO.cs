using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLPK.Entity;

namespace DLPK.DAO
{
    public class BacSiDAO
    {
        private static BacSiDAO instance;

        public static BacSiDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BacSiDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public BacSiDAO() { }
        public List<BacSi> BacSi_Select(ChuyenKhoa chuyenKhoa)
        {
            List<BacSi> ListBacSi = new List<BacSi>();
            string query = "BacSi_Select_Khoa '"+chuyenKhoa.TenKhoa+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                BacSi Bacsi = new BacSi(item);
                ListBacSi.Add(Bacsi);
            }
            return ListBacSi;
        }
    }
}
