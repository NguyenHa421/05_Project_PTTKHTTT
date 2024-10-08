use master
go
IF EXISTS (SELECT * FROM sys.databases WHERE name = 'QL5_HoSoUngTuyenABC')
BEGIN
    ALTER DATABASE QL5_HoSoUngTuyenABC
    SET SINGLE_USER 
    WITH ROLLBACK IMMEDIATE;

    DROP DATABASE QL5_HoSoUngTuyenABC;
END 

drop database if exists QL5_HoSoUngTuyenABC

create database QL5_HoSoUngTuyenABC
go
use QL5_HoSoUngTuyenABC

--Tao bang
create table DoanhNghiep
(
	MaDoanhNghiep char(10) unique not null,
	TenDoanhNghiep nvarchar(100) not null,
	MaSoThue varchar(15) unique not null,
	NguoiDaiDien nvarchar(50) not null,
	DiaChi nvarchar(200) not null,
	Email varchar(100) not null,
	primary key(MaDoanhNghiep)
)
create table NhanVien
(
	MaNhanVien char(10) unique not null,
	TenNhanVien nvarchar(50) not null,
	NgaySinh date not null,
	DienThoai varchar(15) not null,
	DiaChi nvarchar(100) not null,
	Email varchar(100) not null,
	primary key(MaNhanVien)
)
create table PhieuDangKyQuangCao
(
	MaDangKy char(10) unique not null,
	ThoiGianDangKy date not null,
	MaDoanhNghiep char(10) not null,
	NhanVienTiepNhan char(10) not null,
	primary key(MaDangKy)
)
create table HoaDon
(
	MaDangKy char(10) not null,
	TongChiPhi money not null,
	SoDot int not null,
	SoThuTuDot int,
	ThuNgan char(10) not null,
	primary key(MaDangKy, SoThuTuDot)
)
create table HinhThucDangTuyen
(
	MaHinhThuc char(10) unique not null,
	TenHinhThuc nvarchar(100) unique not null,
	DonViTinh nvarchar(50) not null,
	DonGia money not null,
	primary key(MaHinhThuc)
)
create table BaiDang
(
	MaDangKy char(10) not null,
	MaHinhThuc char(10) not null,
	NoiDung nvarchar(1000) not null,
	NgayDang date not null,
	TrangThai nvarchar(50) not null,
	NhanVienThucHien char(10) not null,
	primary key(MaDangKy)
)
create table DanhSachGiaHan
(
	MaDanhSach char(10) unique not null,
	NgayLap date,
	NhanVienLap char(10) not null,
	primary key(MaDanhSach)
)
create table ChiTietGiaHan
(
	MaDanhSach char(10) not null,
	MaDangKy char(10) not null,
	NgayHetHan date,
	ThongTinUuDai nvarchar(100),
	primary key (MaDanhSach, MaDangKy)
)
create table ThongTinDangTuyen
(
	MaDangKy char(10),
	TenViTri nvarchar(100) not null,
	SoLuong int,
	TieuChi nvarchar(500) not null,
	primary key(MaDangKy, TenViTri)
)
create table ThanhVien
(
	MaThanhVien char(10) unique not null,
	HoTen nvarchar(50) not null,
	NamSinh int,
	SoDienThoai varchar(15) not null,
	DiaChi nvarchar(100) not null,
	Email varchar(100) not null,
	primary key(MaThanhVien)
)
create table HoSo
(
	MaHoSo char(10) unique not null,
	MaThanhVien char(10) not null,
	MaDangKy char(10) not null,
	TenViTri nvarchar(100) not null,
	TrangThai nvarchar(50) not null,
	primary key(MaHoSo)
)
create table ChiTietBangCap
(	
	MaHoSo char(10) not null,
	TenBangCap nvarchar(100) not null,
	primary key(MaHoSo, TenBangCap)
)
--Khoa ngoai
alter table PhieuDangKyQuangCao
add constraint FK_PDKQC_DN
foreign key(MaDoanhNghiep)
references DoanhNghiep(MaDoanhNghiep)

alter table PhieuDangKyQuangCao
add constraint FK_DKQC_NV
foreign key(NhanVienTiepNhan)
references NhanVien(MaNhanVien)

alter table HoaDon
add constraint FK_HD_PDKQC
foreign key(MaDangKy)
references PhieuDangKyQuangCao(MaDangKy)

alter table HoaDon
add constraint FK_HD_NV
foreign key(ThuNgan)
references NhanVien(MaNhanVien)

alter table BaiDang
add constraint FK_BD_PDKQC
foreign key(MaDangKy)
references PhieuDangKyQuangCao(MaDangKy)

alter table BaiDang
add constraint FK_BD_HTDT
foreign key(MaHinhThuc)
references HinhThucDangTuyen(MaHinhThuc)

alter table BaiDang
add constraint FK_BD_NV
foreign key(NhanVienThucHien)
references NhanVien(MaNhanVien)

alter table DanhSachGiaHan
add constraint FK_DSGH_NV
foreign key(NhanVienLap)
references NhanVien(MaNhanVien)

alter table ChiTietGiaHan
add constraint FK_CTGH_DSGH
foreign key(MaDanhSach)
references DanhSachGiaHan(MaDanhSach)

alter table ChiTietGiaHan
add constraint FK_CTGH_PDKQC
foreign key(MaDangKy)
references PhieuDangKyQuangCao(MaDangKy)

alter table ThongTinDangTuyen
add constraint FK_TTDT_PDKQC
foreign key(MaDangKy)
references PhieuDangKyQuangCao(MaDangKy)

alter table HoSo
add constraint FK_HS_TV
foreign key(MaThanhVien)
references ThanhVien(MaThanhVien)

alter table HoSo
add constraint FK_HS_TTDT
foreign key(MaDangKy, TenViTri)
references ThongTinDangTuyen(MaDangKy, TenViTri)

alter table ChiTietBangCap
add constraint FK_CTBC_HS
foreign key(MaHoSo)
references HoSo(MaHoSo)

