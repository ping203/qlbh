	(SELECT NgayNhap,SoHieu,NULL,TenNhaCC,SoLuong,NULL,TonKho,idHangHoa FROM qlbh.phieunhaphangct left join 
	qlbh.phieunhaphang on phieunhaphangct.IdPhieuNhapHang = phieunhaphang.idphieunhaphang)
	union all
	(select NgayXuat,NULL,SoHieu,TenKhachHang,NULL,SoLuong,TonKho,IdHangHoa from qlbh.phieuxuathangct left join 
	qlbh.phieuxuathang on phieuxuathangct.IdPhieuXuatHang =phieuxuathang.idphieuxuathang)
	order by NgayNhap