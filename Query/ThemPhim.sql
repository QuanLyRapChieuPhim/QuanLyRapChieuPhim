use MovieDB
go

alter proc ThemPhim (@MaPhim nvarchar(10), @TenPhim nvarchar(50),@DaoDien nvarchar(30), @QuocGia nvarchar(10)
						, @Nam int, @ThoiLuong int, @TheLoai nvarchar(30), @HinhAnh image)
as
begin
	insert into Phim(MaPhim, TenPhim, DaoDien, QuocGia, Nam, ThoiLuong, TheLoai, HinhAnh)
	values (@MaPhim, @TenPhim, @DaoDien, @QuocGia, @Nam, @ThoiLuong, @TheLoai, @HinhAnh)
end
go

exec ThemPhim 'Phim06', N'ĐẤU TRƯỜNG ÂM NHẠC', N'Garth Jennings', N'Mỹ', '2016', '108', N'Hoạt Hình'