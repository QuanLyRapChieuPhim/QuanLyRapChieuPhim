use MovieDB
go

Select P.*
From dbo.Phim P, dbo.LichChieu L, dbo.NgayChieu N, dbo.GioChieu G
Where P.MaPhim = L.MaPhim and L.NgayChieu = N.NgayChieu and L.GioChieu = G.GioChieu
		and L.MaPhim = 'Phim01' and L.GioChieu = '20:00'
		
Select P.*
From dbo.Phim P, dbo.LichChieu L, dbo.NgayChieu N
Where P.MaPhim = L.MaPhim and L.NgayChieu = N.NgayChieu
		and L.MaPhim = 'Phim01' and L.NgayChieu = ''		
				
Select P.*
From dbo.Phim P