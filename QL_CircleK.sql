-- use master drop database QL_CircleK
go
create database QL_CircleK

go
use QL_CircleK

go
CREATE FUNCTION AUTO_IDNhanVien()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaNV) FROM NhanVien) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaNV, 3)) FROM NhanVien
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'NV00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'NV0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
go
CREATE FUNCTION AUTO_IDHangHoa()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaHang) FROM HangHoa) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaHang, 3)) FROM HangHoa
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'MH00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'MH0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
go
--drop FUNCTION AUTO_IDHoaDon
CREATE FUNCTION AUTO_IDHoaDon()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(MaHD) FROM HOADON) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(MaHD, 3)) FROM HOADON
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'HD00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'HD0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
go
create table NhanVien
(
	MaNV varchar (20) not null ,--CONSTRAINT IDNV DEFAULT DBO.AUTO_IDNhanVien(),
	HoTen nvarchar (50),
	GioiTinh Nvarchar (3),
	NgaySinh Date,
	DiaChi nvarchar(50),
	MatKhau varchar(20),
	CONSTRAINT PK_NhanVien PRIMARY KEY (MaNV)
)
create table LoaiHang
(
	MaLoai varchar (20) NOT NULL PRIMARY KEY,
	TenLoai nvarchar (50),
)
create table HangHoa
(
	MaHang varchar (20) NOT NULL PRIMARY KEY, --CONSTRAINT IDHangHoa DEFAULT DBO.AUTO_IDHangHoa(),
	TenHang nvarchar (50),
	DVT NVARCHAR (20),
	DonGia INT,
	MaLoai VARCHAR (20)
	CONSTRAINT FK_TD_L FOREIGN KEY(MALOAI) REFERENCES LoaiHang(MALOAI)
)
create table HOADON
(
	MaHD varchar (20) NOT NULL PRIMARY KEY, --CONSTRAINT IDHOADON DEFAULT DBO.AUTO_IDHangHoa(),
	NgayTao DATE,
	MaNV varchar (20),
	TongTien int,
	
	CONSTRAINT FK_HD_NV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
)
--drop table HOADON,  drop table HangHoa, drop table loaihang
create table CHITIETHOADON
(
	MaHD varchar (20) ,
	MaHang varchar (20),
	SoLuong INT,
	
	CONSTRAINT PK_CTHD PRIMARY KEY(MaHD,MaHang),
	CONSTRAINT FK_CTHD_HD FOREIGN KEY(MAHD) REFERENCES HOADON(MAHD),
	CONSTRAINT FK_CTHD_TD FOREIGN KEY(MaHang) REFERENCES HangHoa(MaHang),
	
)

--insert into HangHoa(TenHang,DVT,DonGia,MaLoai) values (N'Test',N'Cái',1000,'LH001')