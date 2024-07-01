use QL5_HoSoUngTuyenABC
go
drop table if exists Accounts

create table Accounts(
	AccountID int identity(1,1) primary key,
	Username char(10) unique,
	Password char(20),
	Role varchar(20)
);
go
insert into Accounts (Username, Password, Role)
select cast(MaNhanVien as char(10)),
	cast(MaNhanVien as char(20)),
	'NhanVien'
from NhanVien
where MaNhanVien not in (select Username from Accounts);

go
insert into Accounts (Username, Password, Role)
select cast(MaThanhVien as char(10)),
	cast(MaThanhVien as char(20)),
	'ThanhVien'
from ThanhVien
where MaThanhVien not in (select Username from Accounts);
go
--select * from Accounts

create or alter trigger trg_AutoIncrementMaTV
on ThanhVien
instead of insert
as
begin
	set nocount on;
	
	declare @MaxID char(10);
	declare @NewID char(10);
	declare @next int;
	declare @prefix char(2) = 'TV';
	declare @numLength int = 3;

	--Lay ma tv lon nhat hien tai
	select @MaxID = MAX(MaThanhVien) from ThanhVien;

	if @MaxID is null
	begin
		set @next = 1;
	end
	else
	begin
		set @next = cast(substring(@MaxID, 3, len(@MaxID)-2) as int) + 1;
	end

	set @NewID = @prefix + RIGHT('000' + cast(@next as varchar(3)), @numLength);

	--Chen tv moi
	insert into ThanhVien(MaThanhVien, HoTen, NamSinh, SoDienThoai, DiaChi, Email)
	select @NewID, HoTen, NamSinh, SoDienThoai, DiaChi, Email
	from inserted;
end

--insert into dbo.ThanhVien(HoTen,NamSinh,SoDienThoai,DiaChi,Email) values (N'Trần Minh Thư', 1998, '0987783196', N'Xã Mai Lâm, Huyện Đông Anh, Hà Nội', 'anhthutran@gmail.com')
--select * from ThanhVien
--select * from Accounts
--delete from ThanhVien where MaThanhVien = 'TV031'
--delete from Accounts where Username = 'TV031'


