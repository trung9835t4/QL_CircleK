using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAL_NhanVien
    {
        QL_CircleKDataContext ql = new QL_CircleKDataContext();
        public DAL_NhanVien()
        { }
        public int DangNhap(String pManv, String pMatKhau)
        {
            List<NhanVien> lst = ql.NhanViens.Where(t => t.MaNV == pManv).Where(p=>p.MatKhau==pMatKhau).ToList();
            if (lst.Count() == 0)
            {
                return 0;//user ko ton tai
            }
            return 1;
        }
        public NhanVien load1NV(String pManv)
        {
            
            return ql.NhanViens.Where(nv => nv.MaNV == pManv).FirstOrDefault();

        }
    }
}
