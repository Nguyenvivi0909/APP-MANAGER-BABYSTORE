CREATE DATABASE BabyStore
GO

USE BabyStore
GO

/****** HÀM TỰ ĐỘNG TĂNG ID  ******/

    --Loại tài khoản
        DROP FUNCTION IF EXISTS AUTO_IDLTK
        GO

        CREATE FUNCTION AUTO_IDLTK()
        RETURNS VARCHAR(4)
        AS
        BEGIN
            DECLARE @Id VARCHAR(4)
            IF (SELECT COUNT(IdLTK) FROM LOAITAIKHOAN) = 0
                SET @Id = '0'
            ELSE
                SELECT @Id = MAX(RIGHT(IdLTK, 1)) FROM LOAITAIKHOAN
                SELECT @Id = CASE
                    WHEN @Id >= 0 and @Id < 9 THEN 'LTK' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                END
            RETURN @Id
        END
        GO
    --
    --Tài khoản
        DROP FUNCTION IF EXISTS AUTO_IDNCC
        GO
        CREATE FUNCTION AUTO_IDNCC()
        RETURNS VARCHAR(4)
        AS
        BEGIN
            DECLARE @Id VARCHAR(4)
            IF (SELECT COUNT(IdNCC) FROM NHACUNGCAP) = 0
                SET @Id = '0'
            ELSE
                SELECT @Id = MAX(RIGHT(IdNCC, 1)) FROM NHACUNGCAP
                SELECT @Id = CASE
                    WHEN @Id >= 0 and @Id < 9 THEN 'NCC' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                END
            RETURN @Id
        END
        GO
    --
    --Nhà cung cấp
        DROP FUNCTION IF EXISTS AUTO_IDNCC
        GO
        CREATE FUNCTION AUTO_IDNCC()
        RETURNS VARCHAR(4)
        AS
        BEGIN
            DECLARE @Id VARCHAR(4)
            IF (SELECT COUNT(IdNCC) FROM NHACUNGCAP) = 0
                SET @Id = '0'
            ELSE
                SELECT @Id = MAX(RIGHT(IdNCC, 1)) FROM NHACUNGCAP
                SELECT @Id = CASE
                    WHEN @Id >= 0 and @Id < 9 THEN 'NCC' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                END
            RETURN @Id
        END
        GO
    --
    --Danh mục sản phẩm
        DROP FUNCTION IF EXISTS AUTO_IDDMSP
        GO
        CREATE FUNCTION AUTO_IDDMSP()
        RETURNS VARCHAR(7)
        AS
        BEGIN
            DECLARE @Id VARCHAR(7)
            IF (SELECT COUNT(IdDM) FROM DANHMUCSANPHAM) = 0
                SET @Id = '0'
            ELSE
                SELECT @Id = MAX(RIGHT(IdDM, 1)) FROM DANHMUCSANPHAM
                SELECT @Id = CASE
                    WHEN @Id >= 0 and @Id < 9 THEN 'DMSP00' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                    WHEN @Id >= 9 THEN 'DMSP0' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                END
            RETURN @Id
        END
        GO
    --
    --Sản phẩm
        DROP FUNCTION IF EXISTS AUTO_IDSP
        GO
        CREATE FUNCTION AUTO_IDSP()
        RETURNS VARCHAR(5)
        AS
        BEGIN
            DECLARE @Id VARCHAR(5)
            IF (SELECT COUNT(IdSP) FROM SANPHAM) = 0
                SET @Id = '0'
            ELSE
                SELECT @Id = MAX(RIGHT(IdSP, 3)) FROM SANPHAM
                SELECT @Id = CASE
                    WHEN @Id >= 0 and @Id < 9 THEN 'SP00' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                    WHEN @Id >= 9 THEN 'SP0' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                END
            RETURN @Id
        END
        GO
    --
    --Cửa hàng
        DROP FUNCTION IF EXISTS AUTO_IDCH
        GO
        CREATE FUNCTION AUTO_IDCH()
        RETURNS VARCHAR(3)
        AS
        BEGIN
            DECLARE @Id VARCHAR(3)
            IF (SELECT COUNT(IdCH) FROM CUAHANG) = 0
                SET @Id = '0'
            ELSE
                SELECT @Id = MAX(RIGHT(IdCH, 1)) FROM CUAHANG
                SELECT @Id = CASE
                    WHEN @Id >= 0 and @Id < 9 THEN 'CH' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                END
            RETURN @Id
        END
        GO
    --
    --Ca làm
        DROP FUNCTION IF EXISTS AUTO_IDCA
        GO
        CREATE FUNCTION AUTO_IDCA()
        RETURNS VARCHAR(3)
        AS
        BEGIN
            DECLARE @Id VARCHAR(3)
            IF (SELECT COUNT(IdCa) FROM CA) = 0
                SET @Id = '0'
            ELSE
                SELECT @Id = MAX(RIGHT(IdCa, 1)) FROM CA
                SELECT @Id = CASE
                    WHEN @Id >= 0 and @Id < 9 THEN 'CA' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                END
            RETURN @Id
        END
        GO
    --
    --Nhân viên
        DROP FUNCTION IF EXISTS AUTO_IDNV
        GO
        CREATE FUNCTION AUTO_IDNV()
        RETURNS VARCHAR(5)
        AS
        BEGIN
            DECLARE @Id VARCHAR(5)
            IF (SELECT COUNT(IdNV) FROM NHANVIEN) = 0
                SET @Id = '0'
            ELSE
                SELECT @Id = MAX(RIGHT(IdNV, 3)) FROM NHANVIEN
                SELECT @Id = CASE
                    WHEN @Id >= 0 and @Id < 9 THEN 'NV00' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                    WHEN @Id >= 9 THEN 'NV0' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                END
            RETURN @Id
        END
        GO
    --
    --Khách hàng
        DROP FUNCTION IF EXISTS AUTO_IDKH
        GO
        CREATE FUNCTION AUTO_IDKH()
        RETURNS VARCHAR(5)
        AS
        BEGIN
            DECLARE @Id VARCHAR(5)
            IF (SELECT COUNT(IdKH) FROM KHACHHANG) = 0
                SET @Id = '0'
            ELSE
                SELECT @Id = MAX(RIGHT(IdKH, 3)) FROM KHACHHANG
                SELECT @Id = CASE
                    WHEN @Id >= 0 and @Id < 9 THEN 'KH00' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                    WHEN @Id >= 9 THEN 'KH0' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                END
            RETURN @Id
        END
        GO
    --
    --Hoá đơn
        DROP FUNCTION IF EXISTS AUTO_IDHD
        GO
        CREATE FUNCTION AUTO_IDHD()
        RETURNS VARCHAR(5)
        AS
        BEGIN
            DECLARE @Id VARCHAR(5)
            IF (SELECT COUNT(IdHD) FROM HOADON) = 0
                SET @Id = '0'
            ELSE
                SELECT @Id = MAX(RIGHT(IdHD, 3)) FROM HOADON
                SELECT @Id = CASE
                    WHEN @Id >= 0 and @Id < 9 THEN 'HD00' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                    WHEN @Id >= 9 THEN 'HD0' + CONVERT(CHAR, CONVERT(INT, @Id) + 1)
                END
            RETURN @Id
        END
        GO
    --
--

/****** TẠO BẢNG ******/

    --Loại tài khoản
        CREATE TABLE LOAITAIKHOAN(
            IdLTK CHAR(4) PRIMARY KEY CONSTRAINT IdLTK DEFAULT DBO.AUTO_IDLTK(),
            TenLTK NVARCHAR(50)  
        )
        GO
    --
    --Tài khoản
        CREATE TABLE TAIKHOAN(
            IdTK NVARCHAR(10) PRIMARY KEY,
            Matkhau NVARCHAR(10),
            IdLTK CHAR(4)
        )
        GO
    --
    --Nhà cung cấp
        CREATE TABLE NHACUNGCAP(
        IdNCC CHAR(4) PRIMARY KEY CONSTRAINT IdNCC DEFAULT DBO.AUTO_IDNCC(),
        TenNCC NVARCHAR(50),
        Diachi NVARCHAR(100)
        )
        GO
    --
    --Danh mục sản phẩm
        CREATE TABLE DANHMUCSANPHAM(
            IdDM CHAR(7) PRIMARY KEY CONSTRAINT IdDM DEFAULT DBO.AUTO_IDDMSP(),
            TenDM NVARCHAR(50)
        )
        GO
    --
    --Sản phẩm
        CREATE TABLE SANPHAM(
            IdSP CHAR(5) PRIMARY KEY CONSTRAINT IdSP DEFAULT DBO.AUTO_IDSP(),
            IdDM CHAR(7),
            IdNCC CHAR(4),
            TenSP NVARCHAR(50),
            NSX DATE,
            HSD DATE,
            Gia INT
        )
        GO
    --
    --Cửa hàng
        CREATE TABLE CUAHANG(
        IdCH CHAR(3) PRIMARY KEY CONSTRAINT IdCH DEFAULT DBO.AUTO_IDCH(),
        Diachi NVARCHAR(100) UNIQUE,
        IdQL CHAR(5) UNIQUE
        )
        GO
    --
    --Kho
        CREATE TABLE KHO(
            IdSP CHAR(5),
            IdCH CHAR(3),
            Soluong INT
            PRIMARY KEY(IdSP,IdCH)
        )
        GO
    --
    --Ca làm
        CREATE TABLE CA (
            IdCa CHAR(3) PRIMARY KEY CONSTRAINT IdCa DEFAULT DBO.AUTO_IDCA(),
            Thoigian NVARCHAR(50)
        )
        GO
    --
    --Nhân viên
        CREATE TABLE NHANVIEN(
            IdNV CHAR(5) PRIMARY KEY CONSTRAINT IdNV DEFAULT DBO.AUTO_IDNV(),
            Hovaten NVARCHAR(50),
            Ngaysinh DATE,
            Diachi NVARCHAR(100),
            Gioitinh BIT,
            Sdt CHAR(11) UNIQUE, --ms thêm
            Luong INT CHECK (Luong > 3000),
            IdCH CHAR(3),
            IdCa CHAR(3)
        )
        GO
    --
    --Khách hàng
        CREATE TABLE KHACHHANG(
            IdKH CHAR(5) PRIMARY KEY CONSTRAINT IdKH DEFAULT DBO.AUTO_IDKH(),
            Hovaten NVARCHAR(50),
            Diem INT,
            Sdt CHAR(11) UNIQUE 
        )
        GO
    --
    --Hoá đơn
        create table HOADON(
            IdHD char(5) PRIMARY KEY CONSTRAINT IdHD DEFAULT DBO.AUTO_IDHD(),
            IdNV char(5),
            IdKH char(5) not null,
            Ngaymua date,
            Tongtien int,
            Giamgia int,
            ThanhTien int
        )
        go
    --
    --Chi tiết hoá đơn
        CREATE  TABLE CHITIETHOADON(
            IdHD CHAR(5),
            IdSP CHAR(5),
            Soluong INT CHECK(Soluong > 0),
            PRIMARY KEY(IdHD, IdSP)
        )
        GO
    --
    --Giảm giá
        create table GIAMGIA(
            IdHD char(5) primary key,
            Giamgia int
        )
        go
    --
    --Sử dụng điểm
        create table SUDUNGDIEM(
            IdHD char(5),
            Diem int,
            Hoatdong int
            primary key (IdHD)
        )
        go
    --
    --Đánh giá
        CREATE TABLE DANHGIA(
            ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
            Sdt CHAR(11),
            NoiDung NVARCHAR(255)
        )
        go
    --
--

/****** TRIGGER ******/

    -- NSX trước(<)  HSD *check
        Drop TRIGGER IF EXISTS CHECK_SANPHAM 
        GO

        CREATE TRIGGER CHECK_SANPHAM 
        ON SANPHAM
        INSTEAD OF INSERT
        AS
        BEGIN
            SET NOCOUNT ON;
            INSERT INTO SANPHAM ( 
                IdSP, IdDM, TenSP,NSX, HSD, Gia,IdNCC
            )
            SELECT
                i.IdSP, i.IdDM, i.TenSP, i.NSX, i.HSD, i.Gia,i.IdNCC
            FROM
                inserted i
            WHERE
                i.HSD > i.NSX
        END
        go
    --

    --Kiểm tra NQL có là nhân viên không
        Drop TRIGGER IF EXISTS CHECK_SANPHAM 
            GO

        CREATE TRIGGER TRIG_CHECKNHANVIEN
        ON NHANVIEN
        FOR DELETE
        AS
            BEGIN
                IF (  SELECT COUNT(*)
                    FROM CUAHANG, INSERTED
                    WHERE CUAHANG.IdQL = INSERTED.IdNV
                    )>0
                ROLLBACK TRANSACTION
            END
        GO
    --

    --Kiểm tra hợp lệ khi thêm/ sửa hoá đơn
        CREATE TRIGGER CHECK_HOADON ON HOADON
        FOR INSERT, UPDATE
        AS
        DECLARE @kh INT, @nv INT, @sp INT

        SELECT @kh =COUNT(*)
        FROM inserted ne, KHACHHANG
        WHERE ne.IdKH = KHACHHANG.IdKH

        SELECT @nv=COUNT(*)
        FROM inserted ne, NHANVIEN
        WHERE ne.IdNV = NHANVIEN.IdNV

        BEGIN
            IF (@kh = 0 ) 
            BEGIN
                ROLLBACK TRAN;
            END
            IF (@nv = 0 ) 
            BEGIN
                ROLLBACK TRAN;
            END
        END
        GO
    --

    --Kiểm tra hợp lệ khi thêm/ sửa chi tiết hoá đơn hoá đơn
        CREATE TRIGGER CHECK_CHITIETHOADON ON CHITIETHOADON
        FOR INSERT, UPDATE
        AS
        DECLARE  @sp INT

        SELECT @sp =COUNT(*)
        FROM inserted ne, SANPHAM
        WHERE ne.IdSP = SANPHAM.IdSP

        BEGIN
            IF (@sp = 0 ) 
            BEGIN
                ROLLBACK TRAN;
            END
        END
        GO
    --
    --Đăng kí
        DROP TRIGGER IF EXISTS trg_DangKy
        GO
        CREATE TRIGGER trg_DangKy
            ON TAIKHOAN
            INSTEAD OF UPDATE
        AS BEGIN
            DECLARE @IdTK_New NVARCHAR(11), @matKhau NVARCHAR(50)

            SELECT @IdTK_New = IdTK FROM inserted
            SELECT @matKhau = Matkhau FROM inserted
        
            IF ISNUMERIC(@IdTK_New) = 0 OR LEN(@IdTK_New) <> 10 OR (@IdTK_New NOT LIKE '035%' AND @IdTK_New NOT LIKE '083%' AND @IdTK_New NOT LIKE '070%')
            BEGIN 
                PRINT N'Số điện thoại không hợp lệ'
                ROLLBACK TRAN
            END	

            ELSE IF EXISTS (SELECT * FROM deleted WHERE deleted.IdTK = @IdTK_New)
            BEGIN 
                PRINT N'Tài khoản đã tồn tại'
                ROLLBACk TRAN
            END

            ELSE 
            BEGIN
                INSERT INTO TAIKHOAN(IdTK, Matkhau, IdLTK) VALUES (@IdTK_New, @matKhau, 'LTK1')
            END
        END
        GO
    --
    -- Kiểm tra bên sản phẩm còn sản phẩm thì bên danh muc sản phẩm không xóa được
        drop trigger IF EXISTS check_xoadmsp
        go
        create trigger check_xoadmsp on DANHMUCSANPHAM FOR DELETE
        AS
            if (select count(*) from SANPHAM WHERE IdDM =(select IdDM from deleted))>0
            begin 
                print N'Không thể xóa danh mục đang có sản phẩm'
                rollback tran
            end
        go
    --

--

/****** CHÈN DỮ LIỆU VÀO BẢNG ******/
    --Loại tài khoản
        INSERT INTO LOAITAIKHOAN(TenLTK) VALUES ('Khach Hang')
        INSERT INTO LOAITAIKHOAN(TenLTK) VALUES ('Nhan Vien')
        INSERT INTO LOAITAIKHOAN(TenLTK) VALUES ('Quan Ly')
        GO
    --
    --Tài khoảN
        INSERT INTO TAIKHOAN(IdTK, Matkhau, IdLTK) VALUES ('0945881905', 123, 'LTK1')
        INSERT INTO TAIKHOAN(IdTK, Matkhau, IdLTK) VALUES ('0973776072', 123, 'LTK1')
        INSERT INTO TAIKHOAN(IdTK, Matkhau, IdLTK) VALUES ('0917749254', 123, 'LTK1')
        GO 

        INSERT INTO TAIKHOAN(IdTK, Matkhau, IdLTK) VALUES ('0123505051', 123, 'LTK2')
        INSERT INTO TAIKHOAN(IdTK, Matkhau, IdLTK) VALUES ('0123773434', 123, 'LTK2')
        INSERT INTO TAIKHOAN(IdTK, Matkhau, IdLTK) VALUES ('0125523651', 123, 'LTK2')
        INSERT INTO TAIKHOAN(IdTK, Matkhau, IdLTK) VALUES ('0123342851', 123, 'LTK2')
        INSERT INTO TAIKHOAN(IdTK, Matkhau, IdLTK) VALUES ('123', 123, 'LTK3')
        GO
    --
    --Nhà cung cấp
        INSERT INTO NHACUNGCAP(TenNCC, Diachi) VALUES ('Vinamilk', 'Ho Chi Minh City');
        INSERT INTO NHACUNGCAP(TenNCC, Diachi) VALUES ('PediaSure', 'Ho Chi Minh City');
        INSERT INTO NHACUNGCAP(TenNCC, Diachi) VALUES ('Enfa', 'Ha Noi');
        INSERT INTO NHACUNGCAP(TenNCC, Diachi) VALUES ('PediaSure', 'American');
        INSERT INTO NHACUNGCAP(TenNCC, Diachi) VALUES ('Animo', 'Ho Chi Minh City');
        INSERT INTO NHACUNGCAP(TenNCC, Diachi) VALUES ('Lego', 'Ho Chi Minh City');
        INSERT INTO NHACUNGCAP(TenNCC, Diachi) VALUES ('Kim Dong', 'Ho Chi Minh City');
        GO
    --
    --Danh mục sản phẩm
        INSERT INTO DANHMUCSANPHAM(TenDM) VALUES ('Sua');
        INSERT INTO DANHMUCSANPHAM(TenDM) VALUES ('Ngu Coc');
        INSERT INTO DANHMUCSANPHAM(TenDM) VALUES ('Banh Keo Dinh Duong');
        INSERT INTO DANHMUCSANPHAM(TenDM) VALUES ('Thoi Trang So Sinh');
        INSERT INTO DANHMUCSANPHAM(TenDM) VALUES ('Thoi Trang Be Trai');
        INSERT INTO DANHMUCSANPHAM(TenDM) VALUES ('Thoi Trang Be Gai');
        INSERT INTO DANHMUCSANPHAM(TenDM) VALUES ('Sach, Hoc Tap');
        INSERT INTO DANHMUCSANPHAM(TenDM) VALUES ('Do Choi Be Gai');
        INSERT INTO DANHMUCSANPHAM(TenDM) VALUES ('Do Choi Be Trai');
        GO
    --
    --Sản phẩm
        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP001','NCC1','Sua Bellamy Organic Junior Milk Drink so 4 900g', 679000, '20220101','20221231')
        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP001','NCC1','Sua Abbott Grow 4 900g', 309000, '20220101','20221231')
        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP001','NCC1','Sua Nan Organic 3', 590000, '20220101','20221231')

        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP002','NCC2','Combo 2 Banh an dam Grinny vi bi ngo', 88000, '20220101','20221231')
        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP002','NCC2','Banh Gao An Dam Cho Tre Em Happy Bites Chuoi', 65000, '20220101','20221231')

        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP003','NCC4','Banh dinh duong Nestle Cerelac Nutripuff', 54000, '20220101','20221231')
        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP003','NCC3','Banh quy vi cai xanh va cai bo xoi Pigeon 40g', 69000, '20220101','20221231')

        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP004','NCC5','Body Chong muoi Animo VĐ722032 (0-12M,Xanh)', 135000, '20220101', '20221231')
        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP004','NCC5','Bo bao tay chan so sinh thun', 14500, '20220101', '20250101')

        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP005','NCC5','Set kep toc cho be 10 mon Animo', 69000, '20220101', '20250101')
        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP005','NCC5','Non em be gai Animo A2206', 99000, '20220101', '20250101')

        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP006','NCC5','Non luoi trai be trai Animo', 99000, '20220101', '20250101')
        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP006','NCC5','Sandal be trai Animo A2203_JK001', 149000, '20220101', '20250101')

        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP007','NCC7','Ehon - Ga me Cuc Tac và đan con long vang', 25000, '20220101', '20250101')
        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP007','NCC7','To la hoa si - Do an thuc uong', 35000, '20220101', '20250101')

        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP008','NCC6','Hello Kitty - BST 1000 đe can', 40000, '20220101', '20250101')
        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP008','NCC6','Bo do choi dung cu nha bep', 195000, '20220101', '20250101')

        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP009','NCC6','Xe lap rap khung long', 149000, '20220101', '20250101')
        INSERT INTO SANPHAM(IdDM, IdNCC, TenSP, Gia, NSX, HSD) VALUES ('DMSP009','NCC6','Xe keo thu nhung con cua nho', 49000, '20220101', '20250101')
        GO
    --
    --Nhân viên
        INSERT INTO NHANVIEN(Hovaten,Ngaysinh,Diachi,Gioitinh,Sdt,Luong,IdCH,IdCa)VALUES ('Xuan An','20020106','Thu Duc',2,'0123505051','100000','CH1','CA1')
        INSERT INTO NHANVIEN(Hovaten,Ngaysinh,Diachi,Gioitinh,Sdt,Luong,IdCH,IdCa)VALUES ('NGuyen Xuan','20030106','Long An',2,'0123773434','100000','CH2','CA2')
        INSERT INTO NHANVIEN(Hovaten,Ngaysinh,Diachi,Gioitinh,Sdt,Luong,IdCH,IdCa)VALUES ('Nguyen Hien','20030106','Long An',2,'0125523651','120000','CH3','CA3')
        INSERT INTO NHANVIEN(Hovaten,Ngaysinh,Diachi,Gioitinh,Sdt,Luong,IdCH,IdCa)VALUES ('Le Ngoc','20030106','Phu Yen',2,'0123342851','200000','CH4','CA4')
        GO
    --
    --Cửa hàng
        INSERT INTO CUAHANG(Diachi,IdQL) VALUES ('Vo Van Ngan','NV001')
        INSERT INTO CUAHANG(Diachi,IdQL) VALUES ('Pham Van Dong','NV002')
        INSERT INTO CUAHANG(Diachi,IdQL) VALUES ('Chu Van An','NV003')
        INSERT INTO CUAHANG(Diachi,IdQL) VALUES ('Hoang Dieu','NV004')
        GO
    --
    --Kho

        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP001','CH1', 1000)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP002','CH1', 1000)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP003','CH1', 1000)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP004','CH1', 1000)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP005','CH1', 1000)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP006','CH1', 1000)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP007','CH1', 1000)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP008','CH1', 1000)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP009','CH1', 1000)

        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP001','CH2', 1000)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP002','CH2', 300)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP003','CH2', 200)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP010','CH2', 1000)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP011','CH2', 1000)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP012','CH2', 1000)

        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP001','CH3', 800)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP002','CH3', 500)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP013','CH3', 500)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP014','CH3', 500)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP015','CH3', 500)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP016','CH3', 500)

        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP001','CH4', 1500)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP003','CH4', 1500)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP006','CH4', 1500)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP017','CH4', 1500)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP018','CH4', 1500)
        INSERT INTO KHO(IdSP, IdCH, Soluong) VALUES ('SP019','CH4', 1500)
        GO
    --
    --Ca làm
        INSERT INTO CA (Thoigian)VALUEs('7h-10h30')
        INSERT INTO CA (Thoigian)VALUEs('10h30-1h')
        INSERT INTO CA (Thoigian)VALUEs('1h-4h30')
        INSERT INTO CA (Thoigian)VALUEs('4h30-10h')
        GO
    --
    --Khách hàng
        INSERT INTO KHACHHANG(Hovaten,Diem,Sdt) VALUES ('Nguyen Vi', 10000, '0945881905')
        INSERT INTO KHACHHANG(Hovaten,Diem,Sdt) VALUES ('Kha Ai', 40000, '0973776072')
        INSERT INTO KHACHHANG(Hovaten,Diem,Sdt) VALUES ('Minh Chau', 0, '0917749254')
        GO
    --
    --Hoá đơn
        insert into HOADON(IdNV,IdKH,Ngaymua,Tongtien,Giamgia,ThanhTien) values ('NV001','KH001','20220909',2538000,258800,2279200)
        insert into HOADON(IdNV,IdKH,Ngaymua,Tongtien,Giamgia,ThanhTien) values ('NV001','KH002','20220909',3287000,164350,3122650)
        go
        insert into HOADON(IdNV,IdKH,Ngaymua,Tongtien,Giamgia,ThanhTien) values ('NV002','KH001','20220809',253800,76140,2461860)
        insert into HOADON(IdNV,IdKH,Ngaymua,Tongtien,Giamgia,ThanhTien) values ('NV002','KH002','20220809',3287000,164350,3122650)
        go
        insert into HOADON(IdNV,IdKH,Ngaymua,Tongtien,Giamgia,ThanhTien) values ('NV003','KH001','20221009',253800,76140,2461860)
        insert into HOADON(IdNV,IdKH,Ngaymua,Tongtien,Giamgia,ThanhTien) values ('NV003','KH002','20221009',3287000,164350,3122650)
        go
    --
    --Chi tiết hoá đơn
        insert into CHITIETHOADON values('HD001','SP001',2)
        insert into CHITIETHOADON values('HD001','SP003',2)
        go
        insert into CHITIETHOADON values('HD002','SP003',4)
        insert into CHITIETHOADON values('HD002','SP002',3)
        go
        insert into CHITIETHOADON values('HD003','SP001',2)
        insert into CHITIETHOADON values('HD003','SP003',2)
        go
        insert into CHITIETHOADON values('HD004','SP003',4)
        insert into CHITIETHOADON values('HD004','SP002',3)
        go
        insert into CHITIETHOADON values('HD005','SP001',2)
        insert into CHITIETHOADON values('HD005','SP003',2)
        go
        insert into CHITIETHOADON values('HD006','SP003',4)
        insert into CHITIETHOADON values('HD006','SP002',3)
        go
    --
    --Giảm giá
        insert into GIAMGIA values ('HD001',10)
        insert into GIAMGIA values ('HD002',5)
        go
        insert into GIAMGIA values ('HD003',3)
        insert into GIAMGIA values ('HD004',5)
        go
        insert into GIAMGIA values ('HD005',3)
        insert into GIAMGIA values ('HD006',5)
        go

    --
    --Sử dụng điểm
        insert into SUDUNGDIEM values ('HD001',5000,1)
        go
    --
    --Đánh giá
    --
--

/****** KHOÁ NGOẠI ******/
    ALTER TABLE TAIKHOAN ADD FOREIGN KEY (IdLTK) REFERENCES LOAITAIKHOAN(IdLTK)
    ALTER TABLE SANPHAM ADD FOREIGN KEY (IdNCC) REFERENCES NHACUNGCAP(IdNCC)  
    ALTER TABLE KHO ADD FOREIGN KEY (IdSP) REFERENCES SANPHAM(IdSP) on delete cascade
    ALTER TABLE KHO ADD FOREIGN KEY (IdCH) REFERENCES CUAHANG(IdCH) on delete cascade
    ALTER TABLE NHANVIEN ADD FOREIGN KEY (IdCH) REFERENCES CUAHANG(IdCH)
    ALTER TABLE NHANVIEN ADD FOREIGN KEY (IdCa) REFERENCES CA(IdCa)  ON DELETE cascade 
    ALTER TABLE CUAHANG ADD FOREIGN KEY (IdQL) REFERENCES NHANVIEN(IdNV)  on delete cascade
    ALTER TABLE GIAMGIA ADD FOREIGN KEY (IdHD) REFERENCES HOADON(IdHD) 
    ALTER TABLE SUDUNGDIEM ADD FOREIGN KEY (IdHD) REFERENCES HOADON(IdHD) 
    ALTER TABLE DANHGIA ADD FOREIGN KEY (Sdt) REFERENCES KHACHHANG(Sdt)
    GO  
--