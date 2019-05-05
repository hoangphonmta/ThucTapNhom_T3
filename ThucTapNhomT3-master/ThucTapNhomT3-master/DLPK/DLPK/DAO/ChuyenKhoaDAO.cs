using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DLPK.Entity;

namespace DLPK.DAO
{
    public class ChuyenKhoaDAO
    {
        private static ChuyenKhoaDAO instance;

        public static ChuyenKhoaDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ChuyenKhoaDAO();
                return instance;
            }
            private set { instance = value; }
        }
        public ChuyenKhoaDAO() { }
        public List<ChuyenKhoa> ChuyenKhoa_Select()
        {
            List<ChuyenKhoa> ListChuyenKhoa = new List<ChuyenKhoa>();
            string query = "sp_SelectChuyenKhoa";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in result.Rows)
            {
                ChuyenKhoa chuyenKhoa = new ChuyenKhoa(item);
                ListChuyenKhoa.Add(chuyenKhoa);
            }
            return ListChuyenKhoa;
        }
    }
}
