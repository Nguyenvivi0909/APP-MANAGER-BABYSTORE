USE BabyStore
GO
------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------ĐĂNG NHẬP ĐĂNG KÍ------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------
-- Đăng nhập
	DROP PROC IF EXISTS pro_DangNhap
	GO
	CREATE PROC pro_DangNhap 
	@IdTK NVARCHAR(11),
	@Matkhau NVARCHAR(10),
	@IdLTK CHAR(4),
	@ErrorPrint NVARCHAR(200) OUTPUT
	AS BEGIN 
		IF EXISTS (SELECT * FROM TAIKHOAN where IdTK = @IdTK AND Matkhau = @Matkhau AND IdLTK = @IdLTK)
			BEGIN
				SET @ErrorPrint =  N'Chào mừng bạn'
			END
		ELSE 
			SET @ErrorPrint =  N'Sai tên tài khoản rồi !!'
	END
	GO
---------

-- Đăng ký
	

	DROP proc IF EXISTS pro_DangKy
	GO
	CREATE PROC pro_DangKy
		@IdTK NVARCHAR(10),
		@Matkhau NVARCHAR(10), 
		@HoTen NVARCHAR(50)
	AS 
	BEGIN
		UPDATE TAIKHOAN
		SET IdTK = @IdTK, Matkhau = @Matkhau

		IF EXISTS(SELECT * FROM TAIKHOAN WHERE IdTK = @IdTK) 
		BEGIN 
			INSERT INTO KHACHHANG(Hovaten,Diem,Sdt) VALUES (@HoTen, 0, @IdTK)
		END
	END
	GO
---------

------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------KHÁCH HÀNG-------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------

-- Hàm xem sản phẩm trang khách hàng
	DROP function IF EXISTS fn_XemSanPhamTrangKhachHang
	GO
	CREATE FUNCTION fn_XemSanPhamTrangKhachHang() 
	RETURNS @tmp TABLE (
		IdSP CHAR(5),
		TenSP NVARCHAR(50),
		TenDM NVARCHAR(50),
		TenNCC NVARCHAR(50),
		Gia INT,
		Diachi NVARCHAR(100)
	) 
	AS BEGIN 
		INSERT INTO @tmp
		SELECT sp.IdSP, sp.TenSP, dm.TenDM, ncc.TenNCC, sp.Gia, ch.Diachi
		FROM SANPHAM sp
		INNER JOIN DANHMUCSANPHAM dm
			ON sp.IdDM = dm.IdDM
		INNER JOIN NHACUNGCAP ncc
			ON ncc.IdNCC = sp.IdNCC	
		INNER JOIN KHO k
			ON k.IdSP = sp.IdSP
		INNER JOIN CUAHANG ch
			ON ch.IdCH = k.IdCH
		RETURN 
	END
	GO
---------

-- Hàm lọc sản phẩm theo danh mục
	DROP function IF EXISTS fn_LocSanPhamTheoDanhMuc
	GO
	CREATE FUNCTION fn_LocSanPhamTheoDanhMuc(@IdDM CHAR(7)) 
	RETURNS @tmp TABLE (
		IdSP CHAR(5),
		TenSP NVARCHAR(50),
		TenDM NVARCHAR(50),
		TenNCC NVARCHAR(50),
		Gia INT,
		Diachi NVARCHAR(100)
	) 
	AS BEGIN 
		INSERT INTO @tmp
		SELECT sp.IdSP,sp.TenSP, dm.TenDM, ncc.TenNCC, sp.Gia, ch.Diachi
		FROM SANPHAM sp
		INNER JOIN DANHMUCSANPHAM dm
			ON sp.IdDM = dm.IdDM
		INNER JOIN NHACUNGCAP ncc
			ON ncc.IdNCC = sp.IdNCC	
		INNER JOIN KHO k
			ON k.IdSP = sp.IdSP
		INNER JOIN CUAHANG ch
			ON ch.IdCH = k.IdCH
		WHERE dm.IdDM like @IdDM
		RETURN 
	END
	GO
---------

-- Hàm tìm kiếm sảm phẩm
	DROP function IF EXISTS fn_TimKiemSanPham
	GO
	CREATE FUNCTION fn_TimKiemSanPham(@TenSP NVARCHAR(50))
	RETURNS @tmp TABLE (
		IdSP CHAR(5),
		TenSP NVARCHAR(50),
		TenDM NVARCHAR(50),
		TenNCC NVARCHAR(50),
		Gia INT,
		Diachi NVARCHAR(100)
	)
	AS BEGIN 
		INSERT INTO @tmp
		SELECT sp.IdSP,sp.TenSP, dm.TenDM, ncc.TenNCC, sp.Gia, ch.Diachi
		FROM SANPHAM sp
		INNER JOIN DANHMUCSANPHAM dm
			ON sp.IdDM = dm.IdDM
		INNER JOIN NHACUNGCAP ncc
			ON ncc.IdNCC = sp.IdNCC	
		INNER JOIN KHO k
			ON k.IdSP = sp.IdSP
		INNER JOIN CUAHANG ch
			ON ch.IdCH = k.IdCH
		WHERE sp.TenSP  LIKE CONCAT('%', @TenSP, '%')
		RETURN
	END
	GO
---------

-- Hàm xem hóa đơn trang khách hàng 
	drop function if exists fn_GetIdNV
	go
	CREATE FUNCTION fn_GetIdNV(@sdt nvarchar(11))
	returns nvarchar(5)
	begin
		declare @idnv nvarchar(5) = null;
		select @idnv=idnv
			from nhanvien
			where sdt = @sdt
		return @idnv
	end
	GO
---------

-- Thông tin các nhân
	DROP PROC IF EXISTS pro_ThongTinKhachHang
	GO

	CREATE PROC pro_ThongTinKhachHang 
	@SDT NVARCHAR(11)
	AS BEGIN 
	
		SELECT KHACHHANG.Hovaten, KHACHHANG.Diem 
		FROM KHACHHANG 
		WHERE KHACHHANG.Sdt = @SDT
	END
	GO

	DROP PROC IF EXISTS proc_SuaTenKhachHang
	GO
	CREATE PROC proc_SuaTenKhachHang
	@Hovaten NVARCHAR(50),
	@SDT NVARCHAR(11)
	AS
	BEGIN
	UPDATE KHACHHANG
	SET	Hovaten = @Hovaten
	WHERE Sdt = @SDT
	END
	GO

---------
-- Lịch sử mua hàng
	DROP VIEW IF EXISTS V_LichSuMuaHang
	GO
	CREATE VIEW V_LichSuMuaHang
	AS
		SELECT hd.IdHD, ch.Diachi, hd.Ngaymua, hd.ThanhTien,CONVERT (int, hd.ThanhTien*0.01) AS diemcong, sdd.Diem, kh.Sdt 
			FROM HOADON hd
				INNER JOIN SUDUNGDIEM sdd ON sdd.IdHD = hd.IdHD
				INNER JOIN KHACHHANG kh ON kh.IdKH = hd.IdKH
				INNER JOIN NHANVIEN nv ON nv.IdNV = hd.IdNV
				INNER JOIN CUAHANG ch ON ch.IdCH = nv.IdCH
	GO

	DROP FUNCTION IF exists fn_XemLichSu
	GO

	CREATE FUNCTION fn_XemLichSu(@sdt NVARCHAR(11))
	RETURNS TABLE
	AS
		RETURN(SELECT * FROM V_LichSuMuaHang WHERE @sdt = V_LichSuMuaHang.Sdt)
	GO

------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------QUẢN LÍ TÀI KHOẢN------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------

---Hiển thị tất cả tài khoản
	drop function if exists func_show_acc
	go
	create function func_show_acc()
	returns table
	as
		return( select  tk.IdTK, tk.Matkhau, tk.IdLTK, ltk.TenLTK
				from TAIKHOAN tk, LOAITAIKHOAN ltk
				where tk.IdLTK = ltk.IdLTK		)
	go

	drop proc if exists proc_show_acc
	go
	create proc proc_show_acc
	as
	begin
		select * from dbo.func_show_acc()
	end
	go
---------

---Hiển thị 1 tài khoản
	drop function if exists func_show_acc_str
	go
	create function func_show_acc_str(@str char(15))
	returns table
	as
		return( select  tk.IdTK, tk.Matkhau, tk.IdLTK, ltk.TenLTK
				from TAIKHOAN tk, LOAITAIKHOAN ltk
				where tk.IdLTK = ltk.IdLTK	and tk.IdTK = @str	)
	go

	drop proc if exists proc_show_acc_str
	go
	create proc proc_show_acc_str @str char(15)
	as
	begin
		select * from dbo.func_show_acc_str(@str)
	end
	go
---------

---Thêm 1 tài khoản
	drop proc if exists transaction_proc_add_account
	go
	create proc transaction_proc_add_account @account char(15), @password char(15), @typeaccount char(10)
	as 
	begin
		begin transaction
			begin try
				insert into TAIKHOAN(IdTK, Matkhau, IdLTK) values (@account, @password, @typeaccount)
				commit transaction
			end try
			begin catch
				rollback transaction
			end catch
	end
	go
---------

--- Xóa 1 tài khoản

	drop proc if exists transaction_proc_delete_account
	go
	create proc transaction_proc_delete_account @account char(15)
	as
	begin
		begin transaction
			begin try
				delete from TAIKHOAN where IdTK = @account
				commit transaction
			end try
			begin catch
				rollback transaction
			end catch
	end
	go
---------

---Cập nhật thông tin tài khoản
	drop proc if exists transaction_proc_update_account
	go
	create proc transaction_proc_update_account @account char(15), @password char(15), @typeaccount char(10)
	as
	begin
		begin transaction
			begin try
				update TAIKHOAN
				set Matkhau = @password,
				IdLTK = @typeaccount
				where IdTK = @account
				commit transaction
			end try
			begin catch
				rollback transaction
			end catch
	end
	go
---------

---Hiển thị tất cả cửa hàng
	drop function if exists func_show_CH
	go
	create function func_show_CH()
	returns table
	as
		return(select * from CUAHANG)
	go

	DROP PROC IF EXISTS proc_ShowCH
	GO
	create proc proc_ShowCH
	as
	begin
		select * from func_show_CH()
	end
	go
---------

---Thêm 1 cửa hàng
	---Hàm hỗ trợ
		drop function if exists func_Check_Info
		go
		create function func_Check_Info(@str NVARCHAR(50) )
		returns int
		AS
		BEGIN
			DECLARE @num int
			SELECT @num = COUNT(*)
				FROM CUAHANG
				WHERE IdQL = @str
			IF (@num = 0) 
				RETURN 0
			RETURN 1
		END
		GO

		drop proc if exists proc_Check_Info
		go
		create proc proc_Check_Info @str nvarchar(40)
		as
		begin
			select dbo.func_Check_Info(@str)
		end
		go
	---------

	-- Cập nhật ID của hàng cho nhân viên, VD khi thăng cấp cho nhân viên lên làm quản lí
		create proc Update_IDCH_for_Emp @IDCH char(5), @IDNV char(10)
		as
		begin
			Update NHANVIEN
			set IdCH = @IDCH
			where IdNV = @IDNV
		end
		go
	---------

	---Hàm hỗ trợ

		drop proc if exists transaction_proc_add_store
		go
		create proc transaction_proc_add_store @Address nvarchar(40), @ManagerID char(10)
		as
		begin
			begin transaction
				begin try
					declare @tmp int
					set @tmp = dbo.func_Check_Info(@ManagerID)
					if @tmp = 0
						insert into CUAHANG(Diachi,IdQL) values(@Address, @ManagerID)
						DECLARE @idch CHAR(5)
						SELECT @idch = ch.IdCH
							FROM CUAHANG ch
							WHERE ch.IdQL = @ManagerID
						exec Update_IDCH_for_Emp @idch, @ManagerID
					commit transaction
					print @tmp
				end try
				begin catch
					rollback transaction
				end catch
		end
		go
	---------
	
	---Xóa 1 cửa hàng

		---Hàm hỗ trợ
			drop proc if exists proc_Update_Info_Store_Of_Employee
			go
			create proc proc_Update_Info_Store_Of_Employee @IDCH varchar(10)
			as
			begin
				update NHANVIEN
				set IdCH = null
				where IdCH = @IDCH
			end
			go

			drop proc if exists proc_Update_Info_Store_Of_Warehouse
			go
			create proc proc_Update_Info_Store_Of_Warehouse @IDCH varchar(10)
			as
			begin
				update KHO
				set IdCH = 'CH1'
				where IdCH = @IDCH
			END
			go
		---------

		--Hàm hỗ trợ
			drop proc if exists transaction_proc_Delete_Store
			go
			create proc transaction_proc_Delete_Store @IDCH varchar(10)
			as
			begin
				begin transaction
					begin try
						exec dbo.proc_Update_Info_Store_Of_Employee @IDCH
						exec dbo.proc_Update_Info_Store_Of_Warehouse @IDCH

						update CUAHANG
						set IdQL = null
						where IdCH = @IDCH

						delete CUAHANG where IdCH = @IDCH
						commit transaction
					end try
					begin catch
						rollback transaction
					end catch
			end
			go
		---------
	---------
---------

--Cập nhật thông tin cửa hàng
	drop proc if exists transaction_proc_update_store 
	go
	create proc transaction_proc_update_store 
	@IdCH CHAR(3),
	@Address  NVARCHAR(100),
	@IDMgr Char(10)
	as
	begin
		begin transaction
			begin try
				update CUAHANG
				SET Diachi =@Address,
					IdQL = @IDMgr
				WHERE IdCH=@IdCH
				exec Update_IDCH_for_Emp @IdCH, @IDMgr

				commit transaction
			end try
			begin catch
				rollback transaction
			end catch
	end
	go
---------


------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------QUẢN LÍ SẢN PHẨM-------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------

---Hiển thị tất cả khách hàng
	DROP FUNCTION IF EXISTS func_show_cus
	GO
	create function func_show_cus()
	returns table
	as
	return(select * from KHACHHANG)	
	go

	DROP proc if exists show_list_cus
	go
	create proc show_list_cus
	as
	begin	
		select*from func_show_cus()
	end
	go
---------


--Hiển thị thông tin 1 khách hàng

	DROP FUNCTION IF EXISTS func_show_cus_str
	GO
	create function func_show_cus_str(@str char(10))
	returns table
	as
	return(select * from KHACHHANG
			where IdKH = @str)	
	go

	DROP proc if exists show_list_cus_str
	go
	create proc show_list_cus_str @str_Cus char(10)
	as
	begin
		select*from func_show_cus_str(@str_Cus)
	end
	go
---------

--Thêm 1 khách hàng

	drop proc if exists transaction_proc_add_cus
	go
	create proc transaction_proc_add_cus @name nvarchar(30), @point int, @phonenumber char(11)
	as
	begin
		begin transaction
			begin try
				Insert into KHACHHANG(Hovaten,Diem,Sdt) VALUES (@name, @point, @phonenumber)
				commit transaction
			end try
			begin catch
				rollback transaction
			end catch
	end
	go
---------

--Xóa 1 khách hàng

	drop proc if exists transaction_proc_del_cus
	go
	create proc transaction_proc_del_cus @phonenumber char(11)
	as
	begin
		begin transaction
			begin try
				delete from KHACHHANG
				where Sdt = @phonenumber
				commit transaction
			end try
			begin catch
				rollback transaction
			end catch
	end
	go
---------

--Cập nhật thông tin của khách hàng
	drop proc if exists transaction_proc_update_cus
	go
	create proc transaction_proc_update_cus @ID_cus char(10), @name nvarchar(30), @point int, @phonenumber char(11)
	as
	begin
		begin transaction
			begin try
				UPDATE KHACHHANG
				SET	Hovaten = @name,
					Diem = @point,
					Sdt = @phonenumber
				where IdKH = @ID_cus
				commit transaction
			end try
			begin catch
				rollback transaction
			end catch
	end
	go
---------

------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------QUẢN LÍ SẢN PHẨM-------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------
--Hiển thị sản phẩm
	DROP PROC IF EXISTS pro_HienthiSP
	GO
	create proc pro_HienthiSP
	as
		select * from SANPHAM
	go
---------

--Thêm sản phẩm

	drop proc if exists insertSP_transaction
	go
	create proc insertSP_transaction
	@IdDM CHAR(7),
	@IdNCC CHAR(4),
	@TenSP NVARCHAR(50),
	@NSX DATE,
	@HSD DATE,
	@Gia INT
	as
	begin
		begin tran
			begin try
					if exists (select * from SANPHAM where TenSP=@TenSP)
						begin
							print N'Trùng tên sản phẩm'
						end
					else
							begin
							insert into SANPHAM(IdDM,IdNCC,TenSP,NSX,HSD,Gia)
							values(@IdDM,@IdNCC,@TenSP,@NSX,@HSD,@Gia)
							print N'Thêm sản phẩm thành công'
							end
							commit tran	
							
			end try
			begin catch
				print N'Thêm sản phẩm thất bại'
				rollback tran
			end catch
	end
	go
---------

--Sửa sản phẩm
	drop proc if exists updateSP_transaction
	go
	create proc updateSP_transaction
	@IdSP char(7),
	@IdDM char(5),
	@TenSP nvarchar(50),
	@NSX date,
	@HSD date,
	@Gia int
	as
	begin
		begin tran
				begin try
					UPDATE SANPHAM
					set IdDM=@IdDM,
						TenSP=@TenSP,
						NSX=@NSX,
						HSD=@HSD,
						Gia=@Gia
						Where IdSP=@IdSP
						print N'Cập nhật sản phẩm  thành công'
						commit tran
				end try
				begin catch
					print N'Cập nhật sản phẩm  thất bại'
					rollback tran
				end catch
	end
---------

--Lọc sản phẩm hết hạn
	DROP PROC IF EXISTS SP_hethan
	go
	create proc SP_hethan
	@HSD date
	as
	begin
	select * from SANPHAM
	Where HSD < @HSD	
	end	
	go
---------

---Xóa sản phẩm
	DROP PROC IF EXISTS XoaSP
	go
	create proc XoaSP
	@IdSP char(5)
	as
	begin
		delete from SANPHAM
		where IdSP=@IdSP

	end
	GO

--exec pro_HienthiSP
--exec XoaSP 'SP001'
---------


------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------QUẢN LÍ NHÂN VIÊN------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------
----hiển thị nhân viên
	DROP PROC IF EXISTS pro_HienThiNhanVien
	GO
	CREATE PROC pro_HienThiNhanVien
	AS
	BEGIN
	SELECT IdNV, Hovaten, Ngaysinh, Diachi,
		CASE WHEN Gioitinh = 1 THEN N'Nữ' ELSE N'Nam' END AS Gioitinh, Sdt, Luong, IdCH, IdCa FROM NHANVIEN
	END
	GO
---------

----Thêm nhân viên
	drop proc if exists insertNV_transaction
	go
	create proc insertNV_transaction
	@Hovaten NVARCHAR(50),
	@Ngaysinh DATE,
	@Diachi NVARCHAR(100),
	@Gioitinh BIT,
	@Sdt CHAR(11),
	@Luong INT,
	@IdCH CHAR(3),
	@IdCa CHAR(3)
	as
	begin
		begin tran 
			begin try 
				insert into NHANVIEN(Hovaten,Ngaysinh,Diachi,Gioitinh,Sdt,Luong,IdCH,IdCa)
				values(@Hovaten,@Ngaysinh,@Diachi,@Gioitinh,@Sdt,@Luong,@IdCH,@IdCa)
				print N'thêm thành công'
				commit tran 
			end try
			begin catch
				print N'thêm thất bại'
				rollback tran
			end catch
	end
---------

---Sửa nhân viên
	drop proc if exists updateNV_transaction
	go
	create proc updateNV_transaction
	@IdNV CHAR(5),
	@Hovaten NVARCHAR(50),
	@Ngaysinh DATE,
	@Diachi NVARCHAR(100),
	@Sdt CHAR(11),
	@Luong INT,
	@IdCH CHAR(3),
	@IdCa CHAR(3)
	as
	begin
		begin tran
			begin try
				update NHANVIEN 
				set Hovaten=@Hovaten,
				Ngaysinh=@Ngaysinh,
				Diachi=@Diachi,
				Sdt=@Sdt,
				Luong=@Luong,
				IdCH=@IdCH,
				IdCa=@IdCa
				where IdNV=@IdNV
				print N'cập nhật thành công'
				commit tran
			end try
			begin catch
				print N'cập nhật thất bại'
				rollback tran
			end catch
	end
---------

--Xoá danh nhân viên
	DROP PROC IF EXISTS XoaNV
	go
	create proc XoaNV
	@IdNV CHAR(5)
	as
	begin
		delete from NHANVIEN
		where IdNV=@IdNV
	end
	go

--EXEC pro_HienThiNhanVien
--EXEC XoaNV 'NV002'
---------

--Tìm kiếm theo tên hoặc id
	DROP PROC IF EXISTS proc_Timkiemtheodieukien
	GO
	CREATE PROC proc_Timkiemtheodieukien (@str NVARCHAR(50))
	AS 
	BEGIN
		SELECT * 
			FROM NHANVIEN nv
			WHERE nv.Hovaten LIKE '%'+@str+'%' OR nv.IdNV like '%'+@str+'%'
	END
	GO
---------

------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------QUẢN LÍ DANH MỤC SẢN PHẨM----------------------------------------------
------------------------------------------------------------------------------------------------------------------------------

--hiển thị danh mục sản phẩm
	drop proc if exists func_HienDMSP
	go
	create function func_HienDMSP()
	returns table
	as
	return (select * from DANHMUCSANPHAM)
	go
---------


--Thêm danh mục sản phẩm
	DROP PROC IF EXISTS proc_ThemDMSP
	GO
	create proc proc_ThemDMSP
	@TenDM nvarchar(50)
	as
	begin
		if exists (select * from DANHMUCSANPHAM WHERE TenDM=@TenDM)
			begin	
				print N'Tên danh mục sản phẩm đã tồn tại'
			end
		else	
			begin
				insert into DANHMUCSANPHAM(TenDM)values(@TenDM)
				print 'Thêm tên danh mục sản phẩm thành công'
			end
	end
	go
---------


---Sửa danh mục sản phẩm
	DROP PROC IF EXISTS proc_SuaDMSP
	GO
	create proc proc_SuaDMSP
	@IdDM CHAR(7),
	@TenDM NVARCHAR(50)
	as
	begin
		UPDATE DANHMUCSANPHAM
		SET TenDM=@TenDM
		Where IdDM=@IdDM
	end
	go
---------



--Xóa danh muc sạn phẩm
	DROP PROC IF EXISTS Xoa_DMSP
	GO
	create proc Xoa_DMSP
	@IdDM CHAR(7)
	as
	begin
		delete from DANHMUCSANPHAM
		where IdDM=@IdDM
	end
	go

--exec Xoa_DMSP 'DMSP001'
--select * from func_HienDMSP()
---------

--Tìm kiếm tên danh mục
	DROP PROC IF EXISTS TK_TenDMSP
	GO
	create proc TK_TenDMSP
	@TenDM nvarchar(7)
	as
	begin
		select * from DANHMUCSANPHAM
		Where TenDM like  '%' +@TenDM+'%'
	end
	go
---------

------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------QUẢN LÍ NHÀ CUNG CẤP---------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------

--Hiển thị nhà cung cấp
	DROP PROC IF EXISTS Hienthi_NCC
	go
	create proc Hienthi_NCC
	as
	begin
	select * from NHACUNGCAP
	end
	go
---------


--Thêm nhà cung cấp
	DROP PROC IF EXISTS Them_NCC
	go
	create proc Them_NCC
	@TenNCC nvarchar(50),
	@Diachi nvarchar(100)
	as
		begin
				if exists(select * from NHACUNGCAP where TenNCC=@TenNCC)
				begin
					print N'Trùng tên nhà cung cấp'
				end
			else
				begin
				insert into NHACUNGCAP(TenNCC,Diachi)
				values(@TenNCC,@Diachi)	
				print N'Thêm nhà cung cấp thành công'
				end
		end
	go
---------

--Sửa nhà cung cấp------
	DROP PROC IF EXISTS Sua_NCC
	go
	create proc Sua_NCC
	@IdNCC char(4),
	@TenNCC nvarchar(50),
	@Diachi nvarchar(100)
	as
	begin
	UPDATE NHACUNGCAP
	SET	TenNCC=@TenNCC,
		Diachi=@Diachi
	where IdNCC=@IdNCC
	end
	go
---------

--Xóa nhà cung cấp
	DROP PROC IF EXISTS Xoa_NCC
	go
	create proc  Xoa_NCC
	@IdNCC char(4)
	as
	begin
	delete from NHACUNGCAP
		where IdNCC=@IdNCC
	end
	go

--exec Hienthi_NCC
--exec Xoa_NCC 'NCC2'
---------

--Tìm kiếm tên nhà cung cấp
	DROP PROC IF EXISTS Tk_Ten_NCC
	GO
	create proc Tk_Ten_NCC
	@Giatri nvarchar(50)
	as
	begin
	select * from NHACUNGCAP
	Where TenNCC like '%' +@Giatri+ '%' OR Diachi like '%' +@Giatri+ '%' 
	end
	go
---------

------------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------------QUẢN LÍ CA LÀM---------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------

--Hiển thị ca làm
	DROP PROC IF EXISTS proc_HienThiCa_Lam
	GO
	create proc proc_HienThiCa_Lam
	as
	begin
		select * from CA
	end
	go
---------

--thêm ca
	DROP PROC IF EXISTS proc_ThemCA
	GO
	create proc proc_ThemCA
	@Thoigian nvarchar(10)
	as
	begin
		insert into CA(Thoigian)values(@Thoigian)
	end
	go
---------

--Sửa ca
	DROP PROC IF EXISTS proc_Suaca
	GO
	create proc proc_Suaca
	@IdCa char(3),
	@Thoigian nvarchar(50)
	as
	begin
	UPDATE CA
	SET Thoigian=@Thoigian
	Where  IdCa=@IdCa
	end
	go
---------

--Xóa ca
	DROP PROC IF EXISTS proc_Xoa
	GO
	create proc proc_Xoa
	@IdCa varchar(5)
	as
	delete from CA
	where IdCa=@IdCa
	go

--exec proc_HienThiCa_Lam
--exec proc_Xoa 'CA1'
---------

------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------BÁN HÀNG-----------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------

--Kiểm tra khách khàng đã đăng kí tài khoản chưa

	DROP FUNCTION IF EXISTS Check_KH
	GO

	CREATE FUNCTION Check_KH(@str NVARCHAR(50) )
	RETURNS table
	AS
		return SELECT *
			FROM KHACHHANG
			WHERE Sdt like '%'+@str+'%' OR IdKH like '%'+@str+'%'
	GO
---------

--Giảm số lượng sản phẩm trong kho

	DROP proc IF EXISTS ReSL
	GO

	CREATE proc ReSL(@idch CHAR(3), @idsp CHAR(5), @sl INT)
	as
	BEGIN
		SET NOCOUNT ON;
		BEGIN TRAN
			BEGIN TRY
			UPDATE KHO
			SET Soluong = Soluong - @sl 
			WHERE IdSP = @idsp AND IdCH = @idch
			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	END
	GO
---------

--Tăng số lượng sản phẩm trong kho

	DROP PROC IF EXISTS InSL
	GO

	CREATE PROC InSL(@idch CHAR(3), @idsp CHAR(5), @sl INT)
	AS
	BEGIN
		SET NOCOUNT ON;
		BEGIN TRAN
			BEGIN TRY
			UPDATE KHO
			SET Soluong = Soluong + @sl 
			WHERE IdSP = @idsp AND IdCH = @idch
			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	END
	GO
---------

--View sản phẩm
	DROP view IF EXISTS ViewSanPham
	GO
	create view ViewSanPham
	as
		select IdSP,TenSP,Gia from SANPHAM
	go
---------

--Tìm kiếm sản phẩm

	DROP PROC IF EXISTS Search_SP
	GO

	CREATE PROC Search_SP (@str NVARCHAR(50))
	AS 
	BEGIN
		SELECT * 
			FROM SANPHAM
			WHERE TenSP like '%'+@str+'%' or IdSP like '%'+@str+'%'
	END
	GO
---------

--Thêm hoá đơn
	DROP PROC IF EXISTS proc_InsertHD
	GO
	CREATE PROC proc_InsertHD (@idkh CHAR(5), @idnv char(5))
	AS
		SET NOCOUNT ON;
		BEGIN TRAN
			BEGIN TRY
			INSERT INTO HOADON(IdKH,IdNV,Ngaymua,giamgia) VALUES (@idkh,@idnv,getdate(),0)
				COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	GO
---------

--Lay IdHD vua them
	DROP function IF EXISTS GetIdHD
	GO
	create function GetIdHD()
	returns char(5)
	begin
		return (SELECT TOP 1 IdHD from HOADON
		ORDER BY IdHD DESC)
	end
	go
---------

--Kiem tra so luong khi them vao hoa don
	DROP function IF EXISTS fn_TestSL
	GO
	CREATE function fn_TestSL(@idch CHAR(3), @idsp CHAR(5), @sl INT)
	returns int
	BEGIN
		declare @kq int
		if (@sl <= (select Soluong from KHO WHERE IdSP = @idsp AND IdCH = @idch))
			set @kq =1
		else
			set @kq =0
		return @kq
	END
	go
---------

--Insert Chi Tiet Hoa Don
	DROP PROC IF EXISTS proc_InsertCTHD
	GO
	CREATE PROC proc_InsertCTHD (@idhd CHAR(5), @idsp CHAR(5), @sl INT)
	AS
	BEGIN
		SET NOCOUNT ON;
		BEGIN TRAN
			BEGIN TRY
		if exists (select * from HOADON where IdHD=@idhd)
		begin
			DECLARE @idch CHAR(3), @idnv CHAR(5)


			SELECT @idnv = hd.IdNV 
				FROM HOADON hd
				WHERE hd.IdHD = @idhd


			SELECT  @idch = ch.IdCH
				FROM CUAHANG ch, NHANVIEN nv
				WHERE nv.IdNV = @idnv and ch.IdCH = nv.IdCH 
		
			EXEC ReSL @idch,@idsp,@sl

			INSERT INTO CHITIETHOADON(IdHD,IdSP,Soluong) VALUES (@idhd,@idsp,@sl)
		end
		COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	END
	GO
---------

--View chi tiet hoa don
	DROP VIEW IF EXISTS VIEW_CHITIETHOADON 
	GO

	CREATE VIEW VIEW_CHITIETHOADON 
	AS
		select hd.IdHD, sp.IdSP, sp.TenSP, sp.Gia, hd.Soluong, sp.Gia*hd.Soluong Thanhtien 
		FROM CHITIETHOADON hd
			INNER JOIN SANPHAM sp ON hd.IdSP = sp.IdSP
	GO
---------

--Hiện  view chi tiet hoá đơn theo idhd và idsp

	DROP PROC IF EXISTS ChiTietHD
	GO
	create proc ChiTietHD (@idhd varchar(5), @idsp varchar(5))
	as
	begin
		select * 
		from VIEW_CHITIETHOADON cthd
		where  cthd.IdSP = @idsp and cthd.IdHD = @idhd
	end
	go
---------

--Xoá hoá đơn theo idhd và idsp
	DROP PROC IF EXISTS Delete_HD
	GO
	CREATE PROC Delete_HD (@idhd CHAR(5), @idsp CHAR(5))
	AS
	BEGIN
		DECLARE @idch CHAR(3), @idnv CHAR(5), @sl INT

		SELECT @sl = Soluong
		from CHITIETHOADON
		WHERE IdHD = @idhd and IdSP=@idsp

		SELECT @idnv = Q.IdNV 
			FROM(SELECT DISTINCT hd.IdNV 
			FROM HOADON hd, CHITIETHOADON cthd  
			WHERE cthd.IdHD = hd.IdHD and hd.IdHD = @idhd) Q


		SELECT @idch = ch.IdCH
			FROM CUAHANG ch, NHANVIEN nv
			WHERE nv.IdNV = @idnv and ch.IdCH = nv.IdCH 
		EXEC InSL @idch,@idsp,@sl

		SET NOCOUNT ON;
		BEGIN TRAN
			BEGIN TRY
		DELETE
			FROM CHITIETHOADON
			WHERE IdHD=@idhd and IdSP=@idsp
			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	END
	GO
---------

--Thêm giảm giá

	DROP proc IF EXISTS Insert_GG 
	GO
	create proc Insert_GG(@idhd varchar(5),@giamgia int)
	as
		SET NOCOUNT ON;
		BEGIN TRAN
			BEGIN TRY
			if exists(select * from GiamGia where IdHD = @idhd)
			begin
				update GiamGia 
				set Giamgia=@giamgia
				Where IdHD=@idhd
			end
			else
			begin
				insert GiamGia values(@idhd,0)
			end
			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	go
---------

--Check điểm sử dụng

	DROP function IF EXISTS Check_SDDiem 
	GO
	create function Check_SDDiem(@idhd varchar(5),@diem int)
	returns int
	begin
		declare @idkh char(5), @test int
			select @idkh = IdKH from HOADON 
				where IdHD =@idhd

		if (@diem <= (select Diem from KHACHHANG where IdKH =@idkh))
			set @test = 1;
		else
			set @test = 0;
		return @test;
	end
	go
---------

--Tăng điểm khi thanh toán =1% thành tiền hoá đơn tương ứng

	DROP proc IF EXISTS Insert_Diem 
	GO
	create proc Insert_Diem(@idhd varchar(5))
	as
	begin
		SET NOCOUNT ON;
		BEGIN TRAN
			BEGIN TRY
				declare @diem int = 0
				select @diem =convert(int,hd.ThanhTien*0.01)
					from HOADON hd
					where IdHD=@idhd

				declare @idkh char(5)
					select @idkh = IdKH from HOADON 
						where IdHD = @idhd

				UPDATE KHACHHANG
				SET Diem = Diem + @diem 
				WHERE IdKH = @idkh

				if exists(select * from SUDUNGDIEM where IdHD = @idhd)
				begin
					update SUDUNGDIEM 
					set Diem=@diem,
						Hoatdong = 0
					where IdHD=@idhd
				end
				else
				begin
					insert SUDUNGDIEM values(@idhd,@diem,0)
				end
				COMMIT TRANSACTION
			END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	end
	go
---------

--Su dung diem
	DROP proc IF EXISTS Insert_SDDiem 
	GO
	create proc Insert_SDDiem(@idhd varchar(5),@diem int)
	as
		declare @idkh char(5)
			select @idkh = IdKH from HOADON 
				where IdHD =@idhd
		if (@diem <= (select Diem from KHACHHANG where IdKH =@idkh))
		begin
			UPDATE KHACHHANG
			SET Diem = Diem - @diem 
			WHERE IdKH = @idkh

			insert SUDUNGDIEM values(@idhd,@diem,1)
		end
	go
---------

--Update Hoa Don
	drop  proc if exists proc_UpdateHD
	go
	create proc proc_UpdateHD(@IdHD char(5))
	as
	begin
		SET NOCOUNT ON;
		BEGIN TRAN
			BEGIN TRY
			declare @tongtien int, @giamgia int, @diem int =0

			select @tongtien = sum(Thanhtien)
				from VIEW_CHITIETHOADON
				GROUP BY IdHD

			if not exists (select * from GIAMGIA where IdHD=@IdHD)
				insert GiamGia values(@idhd,0)

			select @giamgia=convert(int,gg.Giamgia*@tongtien*0.01)
				from GIAMGIA gg, HOADON hd
				where gg.IdHD=@IdHD and hd.IdHD=gg.IdHD

			if exists (select * from SUDUNGDIEM where IdHD=@IdHD)
			begin
				select @diem=diem
					from SUDUNGDIEM
				where IdHD=@IdHD
			end

			update HOADON
			set Tongtien = @tongtien,
				Giamgia =@giamgia+ @diem,
				ThanhTien= @tongtien -  @giamgia-@diem
			Where IdHD = @IdHD
			COMMIT TRANSACTION
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
		END CATCH
	end
	go
---------

--Hiện danh sách chi tiết hoá đơn (sản phẩm) theo idhd (khi bấm thanh toán)
	DROP PROC IF EXISTS ListChiTietHD
	GO
	create proc ListChiTietHD (@idhd varchar(5))
	as
	begin
		select *
		from VIEW_CHITIETHOADON cthd
		where cthd.IdHD = @idhd
	end
	go
---------

--View Hoa Don
	drop view if exists VIEW_HOADON
	Go
	create view VIEW_HOADON
	as
		SELECT hd.IdHD, nv.Hovaten TenNV, ch.IdCH,ch.Diachi, kh.Sdt, kh.Hovaten TenKH, hd.Ngaymua,hd.Tongtien, hd.Giamgia, hd.ThanhTien
			FROM HOADON hd
				INNER JOIN NHANVIEN nv on nv.IdNV = hd.IdNV
				INNER JOIN KHACHHANG kh on kh.IdKH = hd.IdKH
				INNER JOIN CUAHANG ch on ch.IdCH = nv.IdCH
	go
---------

--Hiện hoá đơn theo idhd (khi bấm thanh toán )
	DROP PROC IF EXISTS HienHDTheoIdHD
	GO
	create proc HienHDTheoIdHD(@idhd varchar(5))
	as
	begin
		select * from VIEW_HOADON
		where IdHD = @idhd

	end
	go
---------

------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------DOANH SỐ-----------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------

--View doanh số
	DROP view IF EXISTS View_DoanhSo
	GO
	create view View_DoanhSo
	as
		select IdCH, sum(ThanhTien) Doanhso
		from VIEW_HOADON 
		group by IdCH
	go
---------

--Hiện tất cả các hoá đơn
	DROP proc IF EXISTS HienAllHD
	GO
	create proc HienAllHD(@idhd varchar(5))
	as
	 select * 
		from  view_hoadon
	go
---------

--Hiện Doanh số toàn hệ thống
	DROP function IF EXISTS Doanhso
	GO
	create function DoanhSo()
	returns int
	as
	begin
		declare @ds int;
		select @ds=sum(thanhtien)
		from VIEW_HOADON
		return @ds
	end
	go
---------

--Hiện hoá đơn theo thời gian trên toàn hệ thống
	DROP PROC IF EXISTS HienHDTheoTG
	GO
	create proc HienHDTheoTG(@tungay date, @denngay date)
	as
	begin
		select * from VIEW_HOADON
		where ngaymua between @tungay and @denngay

	end
	go
---------

--Doanh số theo thời gian trên toàn hệ thống
	DROP function IF EXISTS DoanhSoTheoTG
	GO
	create function DoanhSoTheoTG(@tungay date, @denngay date)
	returns int
	as
	begin
		declare @ds int;
		select @ds=sum(thanhtien)
		from VIEW_HOADON
		where (ngaymua between @tungay and @denngay)
		return @ds
	end
	go
---------

--Hiện hoá đơn theo từng cửa hàng
	DROP proc IF EXISTS ListHDTheoCH
	GO
	create proc ListHDTheoCH(@idch varchar(3))
	as
		select * from VIEW_HOADON
		where IdCH = @idch
	GO
---------

--Doanh số theo cửa hàng
	DROP function IF EXISTS DoanhSoTheoCH
	GO

	create function DoanhSoTheoCH(@idch varchar(3))
	returns int
	as
	begin
		declare @ds int;
		select @ds=Doanhso
		from View_DoanhSo
		where  IdCH = @idch
		return @ds
	end
	go
---------

--Hiện hoá đơn theo thời gian của từng cửa hàng

	DROP proc IF EXISTS ListHDTheoCHTG
	GO
	create proc ListHDTheoCHTG(@idch varchar(3),@tungay date, @denngay date)
	as
		select * from VIEW_HOADON
		where IdCH = @idch and  (ngaymua between @tungay and @denngay)
	go
---------

--Doanh số theo thời gian của từng của hàng
	DROP function IF EXISTS DoanhSoCHTG
	GO
	create function DoanhSoCHTG(@idch varchar(3),@tungay date, @denngay date)
	returns int
	as
	begin
		declare @ds int;
		select @ds=sum(thanhtien)
		from VIEW_HOADON
		where (ngaymua between @tungay and @denngay) and IdCH = @idch
		return @ds
	end
	go
---------
--Đánh giá
	DROP PROC IF EXISTS proc_ThemDanhGia
	GO
	CREATE PROC proc_ThemDanhGia
	@SDT NVARCHAR(11),
	@NoiDung NVARCHAR(255)
	AS
	BEGIN
		INSERT INTO DANHGIA values (@SDT, @NoiDung)
	END
	GO

	DROP FUNCTION IF exists fn_QLXemDanhGia
	GO

	CREATE FUNCTION fn_QLXemDanhGia()
	RETURNS TABLE
	AS
		RETURN(select KHACHHANG.Hovaten, KHACHHANG.Sdt, DANHGIA.NoiDung from DANHGIA INNER JOIN KHACHHANG ON DANHGIA.Sdt = KHACHHANG.Sdt)
	GO
--