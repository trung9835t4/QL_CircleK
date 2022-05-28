using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class BLL_NhanVien
    {
        DAL_NhanVien DAL = new DAL_NhanVien();
        QL_CircleKDataContext ql = new QL_CircleKDataContext();
        public BLL_NhanVien()
        { 
        
        }
        public int DangNhap(string pMaNV, string pPass)
        {
            return DAL.DangNhap(pMaNV, pPass);
        }
        public NhanVien load1NV(String pManv)
        {
            return DAL.load1NV(pManv);
        }
    }
}
