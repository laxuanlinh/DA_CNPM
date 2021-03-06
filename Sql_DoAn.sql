﻿create database QL_Thu_Vien;
go
use QL_Thu_Vien;

create table tbl_nhanvien(
	manv int primary key identity,
	tennv nvarchar(50),
	diachi nvarchar(50),
	dienthoai varchar(11),
	email varchar(50),
	chucvu nvarchar(100),
	tuoi int,
	taikhoan varchar(50),
	matkhau nvarchar(50)
)

create table tbl_linhvuc(
	malinhvuc int primary key identity,
	tenlinhvuc nvarchar(100)
)


create table tbl_tacgia(
	matg int identity primary key,
	tentg nvarchar(50),
	gioitinh nvarchar(3),
	diachi nvarchar(100)
)

create table tbl_nxb(
	manxb int primary key identity,
	tennxb nvarchar(100),
	diachi nvarchar(200),
	sdt varchar(11)
)

create table tbl_docgia(
	madg int primary key  identity,
	tendg nvarchar(50),
	ngaysinh varchar(50),
	gioitinh nvarchar(3),
	lop varchar(10),
	diachi nvarchar(100),
	email varchar(50)
)

create table tbl_sach(
	masach int primary key identity,
	tensach nvarchar(100),
	matg int foreign key references tbl_tacgia(matg),
	manxb int foreign key references tbl_nxb(manxb),
	malv int foreign key references tbl_linhvuc(malinhvuc),
	sotrang int,
	soluong int,
	ngaynhap varchar(50)
)

create table tbl_phieumuon_tra(
	sophieumuon int primary key identity,
	madg int foreign key references tbl_docgia(madg),
	manv int foreign key references tbl_nhanvien(manv),
	ngaymuon varchar(50),
	ngaytra varchar(50),
	xacnhantra bit,
	ghichu nvarchar(300)
)

create table tbl_chitietphieu(
	sophieumuon int foreign key references tbl_phieumuon_tra(sophieumuon),
	masach int foreign key references tbl_sach(masach),
	trangthaisach nvarchar(50),
	constraint PK_chitietphieu primary key(sophieumuon, masach)
)

insert into tbl_nhanvien(tennv, diachi, dienthoai, email, chucvu, tuoi, taikhoan, matkhau) values(N'Nguyễn Văn Toàn', N'Hà Nội', '0987491230', 'toannvnuce@gmail.com', N'Thủ thư', 22, 'admin', 'admin');