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
    public class ChuyenKhoaBLL
    {
        private static ChuyenKhoaBLL istance;

        public static ChuyenKhoaBLL Istance
        {
            get
            {
                if (istance == null)
                    istance = new ChuyenKhoaBLL();
                return istance;
            }
            private set { istance = value; }
        }
        public ChuyenKhoaBLL() { }
        public ChuyenKhoaDAO Chuyenkhoa = new ChuyenKhoaDAO();
        
        public List<ChuyenKhoa> ChuyenKhoa_Select()
        {
            return Chuyenkhoa.ChuyenKhoa_Select();
        }
    }
}
