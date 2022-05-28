namespace QL_CircleK
{
    partial class frm_BanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.dataGridView_HoaDon = new System.Windows.Forms.DataGridView();
            this.dataGridView_DsMatHang = new System.Windows.Forms.DataGridView();
            this.txt_TenHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaHang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.btn_Xoa1SP = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.cbo_LoaiHang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.lbl_TongTien = new System.Windows.Forms.Label();
            this.lbl_TenNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.col_MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHangDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cHITIETHOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_MaHoaDon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DsMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.Location = new System.Drawing.Point(9, 9);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(35, 13);
            this.lbl_MaNV.TabIndex = 0;
            this.lbl_MaNV.Text = "label1";
            // 
            // dataGridView_HoaDon
            // 
            this.dataGridView_HoaDon.AllowUserToAddRows = false;
            this.dataGridView_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_HoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaHD,
            this.col_MaHang,
            this.col_SoLuong});
            this.dataGridView_HoaDon.Location = new System.Drawing.Point(749, 87);
            this.dataGridView_HoaDon.Name = "dataGridView_HoaDon";
            this.dataGridView_HoaDon.Size = new System.Drawing.Size(377, 214);
            this.dataGridView_HoaDon.TabIndex = 1;
            // 
            // dataGridView_DsMatHang
            // 
            this.dataGridView_DsMatHang.AutoGenerateColumns = false;
            this.dataGridView_DsMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DsMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangDataGridViewTextBoxColumn1,
            this.tenHangDataGridViewTextBoxColumn,
            this.dVTDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn});
            this.dataGridView_DsMatHang.DataSource = this.hangHoaBindingSource;
            this.dataGridView_DsMatHang.Location = new System.Drawing.Point(12, 149);
            this.dataGridView_DsMatHang.Name = "dataGridView_DsMatHang";
            this.dataGridView_DsMatHang.Size = new System.Drawing.Size(394, 227);
            this.dataGridView_DsMatHang.TabIndex = 1;
            // 
            // txt_TenHang
            // 
            this.txt_TenHang.Location = new System.Drawing.Point(85, 61);
            this.txt_TenHang.Name = "txt_TenHang";
            this.txt_TenHang.Size = new System.Drawing.Size(321, 20);
            this.txt_TenHang.TabIndex = 2;
            this.txt_TenHang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenHang_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hàng";
            // 
            // txt_MaHang
            // 
            this.txt_MaHang.Location = new System.Drawing.Point(85, 87);
            this.txt_MaHang.Name = "txt_MaHang";
            this.txt_MaHang.Size = new System.Drawing.Size(321, 20);
            this.txt_MaHang.TabIndex = 2;
            this.txt_MaHang.TextChanged += new System.EventHandler(this.txt_MaHang_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Hàng";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(12, 382);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(394, 65);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(741, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hóa Đơn";
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(744, 379);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(382, 65);
            this.btn_ThanhToan.TabIndex = 3;
            this.btn_ThanhToan.Text = "Thanh Toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // btn_Xoa1SP
            // 
            this.btn_Xoa1SP.Location = new System.Drawing.Point(744, 333);
            this.btn_Xoa1SP.Name = "btn_Xoa1SP";
            this.btn_Xoa1SP.Size = new System.Drawing.Size(147, 40);
            this.btn_Xoa1SP.TabIndex = 4;
            this.btn_Xoa1SP.Text = "Xóa sản phẩm";
            this.btn_Xoa1SP.UseVisualStyleBackColor = true;
            this.btn_Xoa1SP.Click += new System.EventHandler(this.btn_Xoa1SP_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(995, 333);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(126, 40);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // cbo_LoaiHang
            // 
            this.cbo_LoaiHang.FormattingEnabled = true;
            this.cbo_LoaiHang.Location = new System.Drawing.Point(85, 113);
            this.cbo_LoaiHang.Name = "cbo_LoaiHang";
            this.cbo_LoaiHang.Size = new System.Drawing.Size(321, 21);
            this.cbo_LoaiHang.TabIndex = 5;
            this.cbo_LoaiHang.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiHang_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại Hàng";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(802, 307);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(319, 20);
            this.txt_TongTien.TabIndex = 2;
            // 
            // lbl_TongTien
            // 
            this.lbl_TongTien.AutoSize = true;
            this.lbl_TongTien.Location = new System.Drawing.Point(741, 310);
            this.lbl_TongTien.Name = "lbl_TongTien";
            this.lbl_TongTien.Size = new System.Drawing.Size(56, 13);
            this.lbl_TongTien.TabIndex = 0;
            this.lbl_TongTien.Text = "Tổng Tiền";
            // 
            // lbl_TenNV
            // 
            this.lbl_TenNV.AutoSize = true;
            this.lbl_TenNV.Location = new System.Drawing.Point(11, 33);
            this.lbl_TenNV.Name = "lbl_TenNV";
            this.lbl_TenNV.Size = new System.Drawing.Size(57, 13);
            this.lbl_TenNV.TabIndex = 0;
            this.lbl_TenNV.Text = "lbl_TenNV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số Lượng";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(466, 113);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(224, 20);
            this.txt_SoLuong.TabIndex = 7;
            this.txt_SoLuong.Text = "1";
            this.txt_SoLuong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoLuong_KeyPress);
            // 
            // col_MaHD
            // 
            this.col_MaHD.HeaderText = "Mã hóa đơn";
            this.col_MaHD.Name = "col_MaHD";
            // 
            // col_MaHang
            // 
            this.col_MaHang.HeaderText = "Mã hàng";
            this.col_MaHang.Name = "col_MaHang";
            // 
            // col_SoLuong
            // 
            this.col_SoLuong.HeaderText = "Số lượng";
            this.col_SoLuong.Name = "col_SoLuong";
            // 
            // maHangDataGridViewTextBoxColumn1
            // 
            this.maHangDataGridViewTextBoxColumn1.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn1.HeaderText = "MaHang";
            this.maHangDataGridViewTextBoxColumn1.Name = "maHangDataGridViewTextBoxColumn1";
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "DVT";
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataSource = typeof(DTO.HangHoa);
            // 
            // cHITIETHOADONBindingSource
            // 
            this.cHITIETHOADONBindingSource.DataSource = typeof(DTO.CHITIETHOADON);
            // 
            // lbl_MaHoaDon
            // 
            this.lbl_MaHoaDon.AutoSize = true;
            this.lbl_MaHoaDon.Location = new System.Drawing.Point(841, 61);
            this.lbl_MaHoaDon.Name = "lbl_MaHoaDon";
            this.lbl_MaHoaDon.Size = new System.Drawing.Size(68, 13);
            this.lbl_MaHoaDon.TabIndex = 0;
            this.lbl_MaHoaDon.Text = "Mã Hóa Đơn";
            // 
            // frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 473);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_LoaiHang);
            this.Controls.Add(this.btn_Xoa1SP);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.txt_MaHang);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.txt_TenHang);
            this.Controls.Add(this.dataGridView_DsMatHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_TongTien);
            this.Controls.Add(this.lbl_MaHoaDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_HoaDon);
            this.Controls.Add(this.lbl_TenNV);
            this.Controls.Add(this.lbl_MaNV);
            this.Name = "frm_BanHang";
            this.Text = "frm_BanHang";
            this.Load += new System.EventHandler(this.frm_BanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_HoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DsMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHITIETHOADONBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.DataGridView dataGridView_HoaDon;
        private System.Windows.Forms.DataGridView dataGridView_DsMatHang;
        private System.Windows.Forms.TextBox txt_TenHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaHang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Button btn_Xoa1SP;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.ComboBox cbo_LoaiHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label lbl_TongTien;
        private System.Windows.Forms.Label lbl_TenNV;
        private System.Windows.Forms.BindingSource cHITIETHOADONBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuong;
        private System.Windows.Forms.Label lbl_MaHoaDon;
    }
}