using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace QL_CircleK
{
    public partial class frm_BanHang : Form
    {
        QL_CircleKDataContext ql = new QL_CircleKDataContext();
        NhanVien NhanVien = new NhanVien();
        BLL_HangHoa bll_hanghoa = new BLL_HangHoa();
        HOADON hoadonMoi = new HOADON();

        public frm_BanHang(NhanVien nv)
        {
            InitializeComponent();
            NhanVien = nv;
            lbl_TenNV.Text = NhanVien.HoTen.ToString();
            lbl_MaNV.Text = NhanVien.MaNV.ToString();
        }

        private void txt_TenHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView_DsMatHang.DataSource = bll_hanghoa.timkiem_HangHoa_Ten(txt_TenHang.Text);
        }

        private void txt_MaHang_TextChanged(object sender, EventArgs e)
        {
            dataGridView_DsMatHang.DataSource = bll_hanghoa.timkiem_HangHoa_Ma(txt_MaHang.Text);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            dataGridView_DsMatHang.DataSource = bll_hanghoa.timkiem_HangHoa_Ma(txt_MaHang.Text);
        }

        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            cbo_LoaiHang.DataSource = bll_hanghoa.load_LoaiHang();
            cbo_LoaiHang.ValueMember = "MaLoai";
            cbo_LoaiHang.DisplayMember = "TenLoai";
            //
            dataGridView_DsMatHang.DataSource = bll_hanghoa.timKiem_HangHoa_Loai(cbo_LoaiHang.SelectedValue.ToString());
            //




        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        { 
            int tongTien=0;
            foreach (DataGridViewRow r in dataGridView_HoaDon.Rows)
	        {
                HangHoa hh = bll_hanghoa.load1Hang(r.Cells["col_MaHang"].Value.ToString());
                int a = int.Parse(hh.DonGia.Value.ToString());
                tongTien += a;

                CHITIETHOADON chitietHD = new CHITIETHOADON() { MaHD = r.Cells["col_MaHD"].Value.ToString(), MaHang = r.Cells["col_MaHang"].Value.ToString(), SoLuong =int.Parse( r.Cells["col_SoLuong"].Value.ToString()) };
	        }
            txt_TongTien.Text=tongTien.ToString();
            string mahd = hoadonMoi.MaHD.ToString();
            if (string.IsNullOrEmpty(mahd))
            {
                MessageBox.Show("Xin hãy chọn món" );
                return;
            }
            hoadonMoi.TongTien = tongTien;
            ql.SubmitChanges();
            

            DialogResult kq;
            kq = MessageBox.Show("Bạn muốn thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                MessageBox.Show("Thanh Toán Thành Công");
                dataGridView_HoaDon.Rows.Clear();
            }

        }

        private void cbo_LoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView_DsMatHang.DataSource = bll_hanghoa.timKiem_HangHoa_Loai(cbo_LoaiHang.SelectedValue.ToString());

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string a = "";
            String maHang = dataGridView_DsMatHang.CurrentRow.Cells[0].Value.ToString();
            String soLuong = txt_SoLuong.Text;
            if (dataGridView_HoaDon.Rows.Count ==0)
            {
                a = ql.AUTO_IDHoaDon();
                hoadonMoi = new HOADON() { MaHD = a, MaNV = NhanVien.MaNV, NgayTao = DateTime.Today };
                ql.HOADONs.InsertOnSubmit(hoadonMoi);
                //ql.SubmitChanges();
            }
            else
            {
                var id = dataGridView_HoaDon.Rows[0];
                a = id.Cells[0].Value.ToString();
            }
            if (dataGridView_HoaDon.Rows.Count > 0)
            {
                int flag = 0;
                foreach (DataGridViewRow r in dataGridView_HoaDon.Rows)
                {

                    if (r.Cells["col_MaHang"].Value.ToString() == maHang)
                    {
                        
                        r.Cells["col_SoLuong"].Value = int.Parse(soLuong) + int.Parse(r.Cells["col_SoLuong"].Value.ToString());
                        flag++;
                    }
                }
                if (flag==0)
                {
                int rowIndex = dataGridView_HoaDon.Rows.Add();
                var row = dataGridView_HoaDon.Rows[rowIndex];
                row.Cells["col_MaHD"].Value = a;
                row.Cells["col_MaHang"].Value = maHang;
                row.Cells["col_SoLuong"].Value = soLuong;                
                }

            }
            else
            {
                int rowIndex = dataGridView_HoaDon.Rows.Add();
                var row = dataGridView_HoaDon.Rows[rowIndex];
                row.Cells["col_MaHD"].Value = a;
                row.Cells["col_MaHang"].Value = maHang;
                row.Cells["col_SoLuong"].Value = soLuong;
            }
            lbl_MaHoaDon.Text = a;

        }

        private void btn_TimKiem_Ten_Click(object sender, EventArgs e)
        {
            dataGridView_DsMatHang.DataSource = bll_hanghoa.timkiem_HangHoa_Ten(txt_TenHang.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btn_Xoa1SP_Click(object sender, EventArgs e)
        {
            dataGridView_HoaDon.Rows.Remove(dataGridView_HoaDon.CurrentRow);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            string mahd = hoadonMoi.MaHD.ToString();
            if (mahd!=string.Empty)
            {
                ql.HOADONs.DeleteOnSubmit(hoadonMoi);
            }
            dataGridView_HoaDon.Rows.Clear();
        }
    }
}
