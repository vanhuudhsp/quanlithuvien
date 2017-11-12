Create database QLTHUVIEN
Go
use QLTHUVIEN
Go

-- Tạo cấu trúc bảng
--Tao Bang NHANVIEN
CREATE TABLE NHANVIEN(
	MaNV varchar(4) NOT NULL,
	TenNV nvarchar(30) NULL,
	GioiTinh bit NULL,
	NgaySinh date NULL,
	DiaChi nvarchar(100) NULL,
	SoDT varchar(12) NULL,
	Email varchar(50) NULL,
 CONSTRAINT PK_NhanVien PRIMARY KEY (MaNV)
)
GO

--Tao Bang TAIKHOAN
Create TABLE TAIKHOAN(
	MaTK int  NOT NULL,
	TenTK nvarchar(30) NULL,
	MatKhau nvarchar(30) NULL,
	MaNV varchar(4) NULL,
	MaLTK int,
	CONSTRAINT PK_TAIKHOAN PRIMARY KEY (MaTK)
)
GO

--Tao Bang LoaiTK
CREATE TABLE LOAITK(
	MaLTK int NOT NULL,
	TenLTK nvarchar(30) NULL,
	CONSTRAINT PK_LOAITK PRIMARY KEY (MaLTK)
)
GO



--Drop table NHAXUATBAN
Create table NHAXUATBAN
(
	MaNXB varchar(4) not null,
	TenNXB nvarchar(100) not null,
	constraint PRK_NHAXUATBAN primary key (MaNXB)
)
--Drop table THELOAI
Create table THELOAI
(
	MaTL varchar(2) not null,
	TenTL nvarchar(100) not null,
	constraint PRK_THELOAI primary key (MaTL)
)
--Drop table SACH
Create table SACH
(
	MaSach varchar(6) not null,
	TuaDe nvarchar(100) not null,
	MaNXB varchar(4) not null,
	TacGia nVarchar(100),
	SoLuong int,
	NgayNhap Datetime,
	MaTL varchar(2) 
	constraint PRK_SACH primary key (MaSach)
)
--Drop table BANDOC
Create table BANDOC
(
	MaThe varchar(6) not null,
	TenBanDoc nvarchar(100) not null,
	DiaChi nvarchar(100),
	SoDT varchar(10)
	constraint PRK_BANDOC primary key (MaThe)
)
--Drop table MUONSACH
Create table MUONSACH
(
	MaThe varchar(6) not null,
	MaSach varchar(6) not null,
	MaNV varchar(4),
	NgayMuon datetime,
	NgayTra datetime
	constraint PRK_MUONSACH primary key (MaThe,MaSach, NgayMuon)
)
-- Tạo liên kết
alter table TAIKHOAN   
add  Constraint FK_TAIKHOAN_NHANVIEN FOREIGN KEY(MaNV) REFERENCES NHANVIEN (MaNV)
GO

/****** Object:  ForeignKey FK_TaiKhoan_LoaiTK   Script Date: 04/05/2016 14:01:49 ******/
alter table TAIKHOAN  
add  constraint FK_TAIKHOAN_LOAITK FOREIGN KEY(MaLTK) REFERENCES LOAITK (MaLTK)
GO


alter table SACH
add 
	constraint FRK_SACH_NHAXUATBAN foreign key (MaNXB) references NHAXUATBAN(MaNXB),
	constraint FRK_SACH_THELOAI foreign key (MaTL) references THELOAI(MaTL)

alter table MUONSACH
add 
	constraint FRK_MUONSACH_BANDOC foreign key (MaThe) references BANDOC(MaThe),
	constraint FRK_MUONSACH_SACH foreign key (MaSach) references SACH(MaSach),
	constraint FRK_MUONSACH_NHANVIEN foreign key (MaNV) references NHANVIEN(MaNV)
--Nhập dữ liệu
insert into NHAXUATBAN values('N001', N'Giáo dục')
insert into NHAXUATBAN values('N002', N'Khoa học kỹ thuật')
insert into NHAXUATBAN values('N003', N'Thống kê')
--
insert into THELOAI values('TH', N'Tin học')
insert into THELOAI values('HH', N'Hóa học')
insert into THELOAI values('KT', N'Kinh tế')
insert into THELOAI values('TN', N'Toán học')
--
insert into BANDOC values('050001', N'Trần Xuân', N'17 Yersin', '858936')
insert into BANDOC values('050002', N'Lê Nam', N'5 Hai Bà Trưng', '845623')
insert into BANDOC values('060001', N'Nguyễn Năm', N'10 Lý Tự Trọng', '823456')
insert into BANDOC values('060002', N'Trần Hùng', N'20 Trần Phú', '841256')
--
insert into SACH values('TH0001', N'Sử dụng Corel Draw', 'N002',N'Đậu Quang Tuấn', 3, '08/09/2005','TH')
insert into SACH values('TH0002', N'Lập trình mạng', 'N003',N'Phạm Vĩnh Hưng', 2, '03/12/2003','TH')
insert into SACH values('TH0003', N'Thiết kế mạng chuyên nghiệp', 'N002',N'Phạm Vĩnh Hưng', 5, '04/05/2003','TH')
insert into SACH values('TH0004', N'Thực hành mạng', 'N003',N'Trần Quang', 3, '06/05/2004','TH')
insert into SACH values('TH0005', N'3D Studio kỹ xảo hoạt hình T1', 'N001',N'Trương Bình', 2, '05/02/2004','TH')
insert into SACH values('TH0006', N'3D Studio kỹ xảo hoạt hình T2', 'N001',N'Trương Bình', 3, '05/06/2004','TH')
insert into SACH values('TH0007', N'Giáo trình Access 2000', 'N001',N'Thiện Tâm', 5, '11/12/2005','TH')

--Insert table NHANVIEN
insert into NHANVIEN values('NV1', N'Nguyễn Vĩnh Quang', 1 ,'1/1/1994',N'Bình Định','01265485763', 'vinhquang@gmail.com')
insert into NHANVIEN values('NV2', N'Hồ Thị Kim Ngân',0 , '1/1/1990',N'Bình Dương', '098123733', 'kimngan@gmail.com')

--Insert table LOAITK
insert into LOAITK values(1,N'Admin')
insert into LOAITK values(2,N'Thủ Thư')

--Insert table TAIKHOAN
insert into TAIKHOAN values(1,N'admin','admin','NV1',1)
insert into TAIKHOAN values(2,N'kimngan','kimngan','NV2',2)

--
insert into MUONSACH values('050001', 'TH0006','NV2', '12/12/2006','01/03/2007')
insert into MUONSACH values('050001', 'TH0007','NV2','12/12/2006',null )
insert into MUONSACH values('050002', 'TH0001','NV2', '08/03/2006','04/15/2007')
insert into MUONSACH values('050002', 'TH0004','NV2', '04/03/2007',null)
insert into MUONSACH values('050002', 'TH0002','NV2', '04/03/2007','04/04/2007')
insert into MUONSACH values('050002', 'TH0003','NV2', '02/04/2007','04/15/2007')
insert into MUONSACH values('060002', 'TH0001','NV2', '08/04/2007',null)
insert into MUONSACH values('060002', 'TH0007','NV2', '03/15/2007','04/15/2007')


-- RB1
Alter table SACH
add
	constraint CHK_SACH_SoLuong check (SoLuong > 0)
Go
-- Function Phat_sinh_ma_the
Create Function Phat_sinh_ma_the()
returns varchar(6)
Begin
	declare @Nam varchar(2);
	declare @STT int;
	declare @MaThe varchar(6);

	set @Nam = right(year(getdate()),2);
	select @STT = max(cast(right(MaThe,4) as int))+1
	from BANDOC 
	where MaThe LIKE @Nam+'%'
	
	IF(@STT is NULL)  Set @STT = 1;

	Set @MaThe = @Nam + '0000';
	Set @MaThe  = STUFF(@MaThe,6-len(@STT)+1, len(@STT), @STT);
	return   @MaThe 
end
go
-- RB2
Create trigger tg_BANDOC_Insert on BANDOC
	instead of insert
	as
		DECLARE @ErrMsg NVarChar(200)
		Declare @TenBanDoc nvarchar(100), @DiaChi nvarchar(100), @SoDT varchar(10);
		select @TenBanDoc=TenBanDoc, @DiaChi=DiaChi,@SoDT=SoDT from INSERTED
		Insert into BANDOC Values(dbo.Phat_sinh_ma_the(), @TenBanDoc,@DiaChi,@SoDT)
	Go

--Fuction Phat_sinh_ma_sach
Create Function Phat_sinh_ma_sach(@MaTL varchar(2))
returns varchar(6)
Begin
	declare @STT int;
	declare @MaSach varchar(6);

	select @STT = max(cast(right(MaSach,4) as int))+1
	from SACH
	where MaTL = @MaTL
	
	IF(@STT is NULL)  Set @STT = 1;

	Set @MaSach  = @MaTL + '0000';
	Set  @MaSach  = STUFF( @MaSach,6-len(@STT)+1, len(@STT), @STT);
	return    @MaSach
end
go
print dbo.Phat_sinh_ma_sach('VL') go
--RB3
Create trigger tg_SACH_Insert on SACH
	instead of insert
	as
		DECLARE @error NVarChar(200)
		Declare @TuaDe nvarchar(100), @MaNXB varchar(4), @TacGia nvarchar(100), @SoLuong int, @NgayNhap datetime, @MaTL varchar(2);
		select  @TuaDe =TuaDe, @MaNXB =MaNXB, @TacGia =TacGia, @SoLuong =SoLuong, @NgayNhap =NgayNhap, @MaTL =MaTL from INSERTED
		if (@SoLuong <=0)
		begin
			set @error= N'Số lượng sách > 0!'
			raiserror (@error,16,1)
			return
		end
		Insert into SACH Values(dbo.Phat_sinh_ma_sach(@MaTL), @TuaDe, @MaNXB, @TacGia, @SoLuong, @NgayNhap, @MaTL)
	Go
--RB 4,5,6 - Khi thực hiện mượn sách
--Ngày trả phải trống.
--Mỗi độc giả được mượn tối đa 3 quyển sách.
--Đọc giả không được phép mượn lại quyển sách mà họ đang nợ.
--Số lượng trong bảng sách sẽ thay đổi.
Create trigger tg_MUONSACH_Insert on MUONSACH
	instead of insert
as
	Declare @MaThe varchar(6), @MaSach varchar(6),@NgayMuon datetime,  @NgayTra datetime, @error nvarchar(100)
	Select @MaThe=MaThe, @MaSach=MaSach,@NgayMuon=NgayMuon, @NgayTra=NgayTra from INSERTED
	--
	if (@NgayTra IS NOT null)
	begin
		set @error= N'Ngày trả phải trống!'
		raiserror (@error,16,1)
		return
	end
	--
	Declare @So_sach_muon int
	Select @So_sach_muon=count(MaSach)
	From MUONSACH
	Where MaThe = @MaThe and NgayTra is null
	if @So_sach_muon = 3
	begin
		set @error= N'Bạn đã mượn đủ 3 quyển sách!!'
		raiserror (@error,16,1)
		return
	end
	--
	
	if Exists(Select * From MUONSACH
	          Where (MaThe = @MaThe) and (MaSach=@MaSach) and NgayTra is null)
	begin
		set @error= N'Bạn đã mượn quyển sách này rồi!!!'
		raiserror (@error,16,1)
		return
	end
	--Insert
	Insert into MUONSACH values(@MaThe, @MaSach,@NgayMuon, @NgayTra)
	--Update
	Update SACH
	Set SoLuong = SoLuong-1
	where MaSach = @MaSach
go

--RB_6 - Thực hiện trả sách
-- Ngày trả >= Ngày mượn
-- Số lượng trong bảng sách sẽ thay đổi.
Create trigger tg_MUONSACH_Update on MUONSACH
	instead of Update
as
	Declare @MaThe varchar(6), @MaSach varchar(6),@NgayMuon datetime,  @NgayTra datetime, @error nvarchar(100)
	Select @MaThe=MaThe, @MaSach=MaSach,@NgayMuon=NgayMuon, @NgayTra=NgayTra from INSERTED
	--
	if (@NgayTra < @NgayMuon)
	begin
		set @error= N'Ngày trả >= Ngày Mượn'
		raiserror (@error,16,1)
		return
	end
	--Update
	Update MUONSACH 
	Set NgayTra= @NgayTra
	Where MaThe = @MaThe and MaSach = @MaSach and NgayMuon = @NgayMuon
	--Update
	Update SACH
	Set SoLuong = SoLuong+1
	where MaSach = @MaSach
go
-- Store Procedure
create proc CapNhatSach(@MaSach varchar(6), @ThaoTac int)
as
	Update SACH
	set SoLuong = (Case @ThaoTac
						when 1 then  SoLuong-1
						when 2 then  SoLuong + 1
				   End ) 
	where MaSach = @MaSach
go
Exec  dbo.CapNhatSach 'TH0001', 2