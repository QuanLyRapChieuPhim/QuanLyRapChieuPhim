use MovieDB
go

alter proc SuaPhim (@MaPhim nvarchar(10), @TenPhim nvarchar(50),@DaoDien nvarchar(30), @QuocGia nvarchar(10)
						, @Nam int, @ThoiLuong int, @TheLoai nvarchar(100), @HinhAnh image)
as
begin
	Update Phim
	Set TenPhim=@TenPhim, DaoDien=@DaoDien, QuocGia=@QuocGia, Nam=@Nam, ThoiLuong=@ThoiLuong, TheLoai=@TheLoai, HinhAnh=@HinhAnh
	Where MaPhim=@MaPhim
end
go

exec SuaPhim 'Phim06', N'ĐẤU TRƯỜNG ÂM NHẠC', N'Garth Jennings', N'VN', '2008', '108', N'Hoạt Hình'