create database QL_Thu_Vien;
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
)

create table tbl_linhvuc(
	malinhvuc int primary key identity,
	tenlinhvuc nvarchar(100)
)


create table tbl_tacgia(
	matg int identity primary key,
	tentg nvarchar(50),
	gioitinh nvarchar(3) check (gioitinh IN(N'Nam', N'Nữ')),
	diachi nvarchar(100)
)

create table tbl_nxb(
	manxb int primary key identity,
	tennxb varchar(100),
	diachi nvarchar(200),
	sdt varchar(11)
)

create table tbl_docgia(
	madg int primary key  identity,
	tendg nvarchar(50),
	ngaysinh date,
	gioitinh nvarchar(3) check (gioitinh IN(N'Nam', N'Nữ')),
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
	ngaynhap date
)

create table tbl_phieumuon_tra(
	sophieumuon int primary key identity,
	madg int foreign key references tbl_docgia(madg),
	masach int foreign key references tbl_sach(masach),
	ngaymuon date,
	ngaytra date,
	xacnhantra bit
)

insert into tbl_nhanvien(tennv, diachi, dienthoai, email, chucvu, tuoi) values('admin', N'Hà Nội', '0987491230', 'toannvnuce@gmail.com', N'Thủ thư', 22);