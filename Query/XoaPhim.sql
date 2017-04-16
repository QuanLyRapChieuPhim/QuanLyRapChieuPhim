use MovieDB
go

create proc XoaPhim (@MaPhim nvarchar(10))
as
begin
	Delete Phim
	Where MaPhim=@MaPhim
end
go

exec XoaPhim N'Phim07';