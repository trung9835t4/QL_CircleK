using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLL_HangHoa
    {
        QL_CircleKDataContext ql = new QL_CircleKDataContext();
        DAL_HangHoa DAL = new DAL_HangHoa();
        public BLL_HangHoa()
        { 
        
        }
        public List<HangHoa> timkiem_HangHoa_Ma(String pMaHang)
        {
            return DAL.timKiem_HangHoa_Ma(pMaHang);
        }
        public List<HangHoa> timkiem_HangHoa_Ten(String pTenHang)
        {
            return DAL.timKiem_HangHoa_Ten(pTenHang);
        }
        public List<LoaiHang> load_LoaiHang()
        {
            return DAL.load_Loaihang();
        }
        public List<HangHoa> timKiem_HangHoa_Loai(String pLoaiHang)
        {

            return DAL.timKiem_HangHoa_Loai(pLoaiHang);
        }
        public HangHoa load1Hang(String pMaHang)
        {
            return DAL.load1Hang(pMaHang);
        }
    }
}
