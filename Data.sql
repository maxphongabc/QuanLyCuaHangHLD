﻿create database QLCUAHANG
CREATE TABLE NHANVIEN
(
	MANV int identity  NOT NULL PRIMARY KEY,
	HOTEN NVARCHAR(20),
	DCHI NVARCHAR(20),
	CHUCVU NVARCHAR(20),
	PHAI NVARCHAR(20),
	LUONG float,
	TRANGTHAI BIT default 0,
	TAIKHOAN VARCHAR(16),
	MATKHAU VARCHAR(30)	
)
CREATE TABLE KHACHHANG
(
	MAKH int IDENTITY not null primary key,         
	HOTEN NVARCHAR(20),
	DCHI NVARCHAR(20),
	SDT NVARCHAR(11),
	CMND NVARCHAR(15),
	TRANGTHAI BIT DEFAULT 0
)
CREATE TABLE SANPHAM
(
	MASP int identity  NOT NULL PRIMARY KEY,
	TENSP NVARCHAR(20),
	GIA FLOAT,
	HINH NVARCHAR(100),
	GIAMGIA float,
	SOLUONG int,
	LOAISP VARCHAR(20),
	TRANGTHAI BIT default 0
)

CREATE TABLE HOADON
(
	MAHD INT IDENTITY NOT NULL PRIMARY KEY,
	MAKH INT not null,
	MANV INT not null,
	MASP INT NOT NULL,
	TONGTIEN FLOAT,
	TRANGTHAI BIT default 0
)
CREATE TABLE CTHD
(
	MAHD INT NOT NULL,
	MASP INT NOT NULL,
	SOLUONG INT,
	DONGIA FLOAT,
	TENSP NVARCHAR(20),
	TONGTIEN FLOAT,
	TRANGTHAI BIT DEFAULT 0,
	CONSTRAINT PK_CTHD PRIMARY KEY(MAHD,MASP) 
)

CREATE TABLE LSP
(
	MALSP VARCHAR(20) PRIMARY KEY,
	TENLOAISP NVARCHAR(50),
	TRANGTHAI BIT DEFAULT 0
)

--KHOA NGOAI CHO BANG SAN PHAM
ALTER TABLE SANPHAM
ADD CONSTRAINT FK_SP_LSP FOREIGN KEY(LOAISP)
REFERENCES LSP(MALSP)

--KHOA NGOAI CHO BANG HOADON
ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_KH FOREIGN KEY(MAKH) 
REFERENCES KHACHHANG(MAKH) 

ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_KM FOREIGN KEY(GIAMGIA)
REFERENCES KHUYENMAI(MAKM)

ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_NV FOREIGN KEY(MANV)
REFERENCES NHANVIEN(MANV)

ALTER TABLE HOADON
ADD CONSTRAINT FK_HD_SP FOREIGN KEY (MASP)
REFERENCES SANPHAM(MASP)

--KHOA NGOAI CHO BANG CTHD
ALTER TABLE CTHD
ADD CONSTRAINT FK_CTHD_HD FOREIGN KEY(MAHD)
REFERENCES HOADON(MAHD)
ALTER TABLE CTHD
ADD CONSTRAINT FK_CTHD_SP FOREIGN KEY(MASP)
REFERENCES SANPHAM(MASP)