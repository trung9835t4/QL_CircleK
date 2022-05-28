using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_HangHoa
    {
        QL_CircleKDataContext ql = new QL_CircleKDataContext();
        public DAL_HangHoa()
        { 
        
        }
        public List<HangHoa> timKiem_HangHoa_Ma(String pMaHang)
        {
            return ql.HangHoas.Where(h => h.MaHang.Contains(pMaHang) ).ToList<HangHoa>();
        }
        public List<HangHoa> timKiem_HangHoa_Ten(String pTenHang)
        {
            return ql.HangHoas.Where(h => h.TenHang.Contains(pTenHang)).ToList<HangHoa>();
        }
        public List<HangHoa> timKiem_HangHoa_Loai(String pLoaiHang)
        {
            
            return ql.HangHoas.Where(h=>h.MaLoai==pLoaiHang).ToList<HangHoa>();
        }
        public List<LoaiHang> load_Loaihang()
        {
            return ql.LoaiHangs.Select(t => t).ToList();
        }
        public HangHoa load1Hang(String pMaHang)
        {
            return ql.HangHoas.Where(h => h.MaHang == pMaHang).FirstOrDefault();
        }
        //public List<HangHoa> load_HangHoa(string pMaHang, string pTenHang, string pLoaiHang)
        //{

        //}

    }
}
