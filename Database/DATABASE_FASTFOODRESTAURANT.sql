USE [master]
GO
/****** Object:  Database [QLCH_FAST_FOOD]    Script Date: 6/19/2018 11:45:42 AM ******/
CREATE DATABASE [QLCH_FAST_FOOD]

ALTER DATABASE [QLCH_FAST_FOOD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCH_FAST_FOOD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET  MULTI_USER 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLCH_FAST_FOOD]
GO
/****** Object:  StoredProcedure [dbo].[CAPNHAT_CT_PHIEUNHAPTHUCPHAM]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Thạch Cảnh Nhựt
-- Create date: 06/08/2018
-- Description:	Cập nhật CT_PHIEUNHAP_TP
-- =============================================
CREATE PROCEDURE [dbo].[CAPNHAT_CT_PHIEUNHAPTHUCPHAM]
	@MAPHIEU CHAR(10),
	@TENTP NVARCHAR(100),
	@SL INT = 0
AS
BEGIN
	DECLARE @MATP CHAR(10)
	DECLARE @SL_CU INT
	SET @MATP = (SELECT MATP FROM THUCPHAM WHERE TENTP = @TENTP)
	SET @SL_CU = (SELECT SL FROM CT_PHIEUNHAP_TP WHERE MAPHIEU = @MAPHIEU AND MATP = @MATP)
	SET @SL_CU = @SL_CU * (-1)
	UPDATE CT_PHIEUNHAP_TP
	SET SL = @SL_CU
	WHERE MAPHIEU = @MAPHIEU
	AND MATP = @MATP
	UPDATE CT_PHIEUNHAP_TP
	SET SL = @SL
	WHERE MAPHIEU = @MAPHIEU
	AND MATP = @MATP
END

GO
/****** Object:  StoredProcedure [dbo].[CAPNHAT_CTHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Thạch Cảnh Nhựt
-- Create date: 06/08/2018
-- Description:	Thêm CTHD
-- =============================================
CREATE PROCEDURE [dbo].[CAPNHAT_CTHD]
	@MAHD CHAR(10),
	@TENMA NVARCHAR(100),
	@SL INT = 0
AS
BEGIN
	DECLARE @MAMA CHAR(10)
	DECLARE @SL_CU INT
	SET @MAMA = (SELECT MAMA FROM MONAN WHERE TENMA = @TENMA)
	SET @SL_CU = (SELECT SL FROM CTHD WHERE MAHD = @MAHD AND MAMA = @MAMA)
	SET @SL_CU = @SL_CU * (-1)
	UPDATE CTHD
	SET SL = @SL_CU
	WHERE MAHD = @MAHD 
	AND MAMA = @MAMA
	UPDATE CTHD
	SET SL = @SL
	WHERE MAHD = @MAHD 
	AND MAMA = @MAMA
END

GO
/****** Object:  StoredProcedure [dbo].[CAPNHAT_MONAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 15/06/2018
-- Description:	Cập nhật món ăn
-- =============================================
CREATE PROCEDURE [dbo].[CAPNHAT_MONAN]
	@MAMA CHAR(10),
	@TENMA NVARCHAR(100),
	@GIATIEN INT,
	@TENLOAI_MA NVARCHAR(40)
AS
BEGIN
	DECLARE @MALOAI_MA CHAR(10)
	SET @MALOAI_MA = (SELECT MALOAI_MA FROM LOAIMONAN WHERE TENLOAI_MA = @TENLOAI_MA)
	UPDATE MONAN
	SET TENMA = @TENMA, GIATIEN = @GIATIEN ,MALOAI_MA = @MALOAI_MA
	WHERE MAMA = @MAMA
END


GO
/****** Object:  StoredProcedure [dbo].[CAPNHAT_TAIKHOAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Cập nhật tài khoản 
-- =============================================
CREATE PROCEDURE [dbo].[CAPNHAT_TAIKHOAN]
	@TENDANGNHAP NVARCHAR(40),
	@MATKHAUMOI NVARCHAR(40)
AS
BEGIN
	UPDATE TAIKHOAN
	SET MATKHAU = @MATKHAUMOI
	WHERE TENDANGNHAP = @TENDANGNHAP
END

GO
/****** Object:  StoredProcedure [dbo].[CAPNHAT_THUCPHAM]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 15/06/2018
-- Description:	Cập nhật thực phẩm
-- =============================================
CREATE PROCEDURE [dbo].[CAPNHAT_THUCPHAM]
	@MATP CHAR(10),
	@TENTP NVARCHAR(40),
	@GIA INT = 0,
	@DONVI NVARCHAR(20),
	@TENNPP NVARCHAR(40)
AS
BEGIN
	DECLARE @MANPP CHAR(10)
	SET @MANPP = (SELECT MANPP FROM NHAPHANPHOI WHERE TENNPP = @TENNPP)
	UPDATE THUCPHAM
	SET TENTP = @TENTP, GIA = @GIA,DONVI = @DONVI,MANPP = @MANPP
	WHERE MATP = @MATP
END
GO
/****** Object:  StoredProcedure [dbo].[CTMA_MAMA_tenTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	thêm CTMA khi có ten TP và mã món ăn
-- =============================================
CREATE PROCEDURE [dbo].[CTMA_MAMA_tenTP]
	@MAMA char(10),
	@TENTP nvarchar(40)
AS
BEGIN
	declare @MATP char(10)
	SET @MATP =(SELECT MATP FROM THUCPHAM WHERE TENTP=@TENTP)
	INSERT INTO CTMA VALUES (@MAMA,@MATP)
END

GO
/****** Object:  StoredProcedure [dbo].[DELETE_MONAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	DELETE_MONAN
-- =============================================
CREATE PROCEDURE [dbo].[DELETE_MONAN]
	@MAMA CHAR(10)
AS
BEGIN
	DELETE  FROM MONAN WHERE MAMA = @MAMA
	DELETE FROM CTMA WHERE MAMA=@MAMA
END


GO
/****** Object:  StoredProcedure [dbo].[DELETE_NPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	DELETE_NPP
-- =============================================
CREATE PROCEDURE [dbo].[DELETE_NPP]
	@MANPP CHAR(10)
AS
BEGIN
	DELETE  FROM NHAPHANPHOI WHERE MANPP = @MANPP
END


GO
/****** Object:  StoredProcedure [dbo].[DELETE_TP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	DELETE_TP
-- =============================================
CREATE PROCEDURE [dbo].[DELETE_TP]
	@TP CHAR(10)
AS
BEGIN
	DELETE  FROM CTMA WHERE MATP = @TP
	DELETE  FROM THUCPHAM WHERE MATP = @TP
END


GO
/****** Object:  StoredProcedure [dbo].[DEM_CTHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Đếm số lượng CTHD
-- =============================================
CREATE PROCEDURE [dbo].[DEM_CTHD]
	@MAHD CHAR(10),
	@TENMA NVARCHAR(100)
AS
BEGIN
	DECLARE @MAMA CHAR(10)
	SET @MAMA = (SELECT MAMA FROM MONAN WHERE TENMA = @TENMA)
	SELECT COUNT(*) AS SOLUONG FROM CTHD WHERE MAHD = @MAHD AND MAMA = @MAMA
END

GO
/****** Object:  StoredProcedure [dbo].[DEM_MAHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Thạch Cảnh Nhựt
-- Create date: 09/06/2018
-- Description:	Đếm MAHD
-- =============================================
CREATE PROCEDURE [dbo].[DEM_MAHD]
	@MAHD CHAR(10)
AS
BEGIN
	SELECT COUNT(*) AS SOLUONG FROM HOADON WHERE MAHD = @MAHD
END



GO
/****** Object:  StoredProcedure [dbo].[DEM_MAMA_MONAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Đếm thử MAMA này đã có chưa?
-- =============================================
CREATE PROCEDURE [dbo].[DEM_MAMA_MONAN]
	@MAMA CHAR(10)
AS
BEGIN
	SELECT COUNT(*) AS SOLUONG FROM MONAN WHERE MAMA = @MAMA
END
GO
/****** Object:  StoredProcedure [dbo].[DEM_MANPP_NHAPHANPHOI]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Đếm số lượng CTHD
-- =============================================
CREATE PROCEDURE [dbo].[DEM_MANPP_NHAPHANPHOI]
	@MANPP CHAR(10)
AS
BEGIN
	SELECT COUNT(*) AS SOLUONG FROM NHAPHANPHOI WHERE MANPP = @MANPP
END
GO
/****** Object:  StoredProcedure [dbo].[DEM_MANV]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Thạch Cảnh Nhựt
-- Create date: 09/06/2018
-- Description:	Đếm MANV
-- =============================================
CREATE PROCEDURE [dbo].[DEM_MANV]
	@MANV CHAR(10)
AS
BEGIN
	SELECT COUNT(*) AS SOLUONG FROM NHANVIEN WHERE MANV = @MANV
END



GO
/****** Object:  StoredProcedure [dbo].[DEM_MAPHIEUNHAPTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Đếm số lượng mã phiếu nhập TP
-- =============================================
CREATE PROCEDURE [dbo].[DEM_MAPHIEUNHAPTP]
	@MAPHIEU CHAR(10)
AS
BEGIN
	SELECT COUNT(*) AS SOLUONG FROM PHIEUNHAP_TP WHERE MAPHIEU = @MAPHIEU
END



GO
/****** Object:  StoredProcedure [dbo].[DEM_MATKHAU_TAIKHOAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Đếm thử MAMA này đã có chưa?
-- =============================================
CREATE PROCEDURE [dbo].[DEM_MATKHAU_TAIKHOAN]
	@TENDANGNHAP NVARCHAR(40),
	@MATKHAU NVARCHAR(40)
AS
BEGIN
	SELECT COUNT(*) AS SOLUONG FROM TAIKHOAN WHERE MATKHAU = @MATKHAU
END
GO
/****** Object:  StoredProcedure [dbo].[DEM_MATP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Đếm số lượng mã TP
-- =============================================
CREATE PROCEDURE [dbo].[DEM_MATP]
	@MAPHIEU CHAR(10),
	@MATP CHAR(10)
AS
BEGIN
	SELECT COUNT(*) AS SOLUONG FROM CT_PHIEUNHAP_TP WHERE MAPHIEU = @MAPHIEU AND MATP = @MATP
END



GO
/****** Object:  StoredProcedure [dbo].[DEM_MATP_MAMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DEM_MATP_MAMA]
	@MAMA CHAR(10),
	@TENTP NVARCHAR(40)
AS
BEGIN
	DECLARE @MATP CHAR(10)
	SET @MATP = (SELECT MATP FROM THUCPHAM WHERE TENTP = @TENTP)
	SELECT COUNT(*) AS SOLUONG FROM CTMA WHERE MAMA = @MAMA AND MATP = @MATP
END
GO
/****** Object:  StoredProcedure [dbo].[DEM_MATP_THUCPHAM]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Đếm MATP có trong bảng THUCPHAM
-- =============================================
CREATE PROCEDURE [dbo].[DEM_MATP_THUCPHAM]
	@MATP CHAR(10)
AS
BEGIN
	SELECT COUNT(*) AS SOLUONG FROM THUCPHAM WHERE MATP = @MATP
END
GO
/****** Object:  StoredProcedure [dbo].[KIEMTRA_DANGNHAP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Kiểm tra đăng nhập
-- =============================================
CREATE PROCEDURE [dbo].[KIEMTRA_DANGNHAP]
	@TENDANGNHAP VARCHAR(40),
	@MATKHAU VARCHAR(40)
AS
BEGIN
	SELECT COUNT(*) FROM TAIKHOAN AS SOLUONG WHERE TENDANGNHAP = @TENDANGNHAP AND MATKHAU = @MATKHAU
END


GO
/****** Object:  StoredProcedure [dbo].[KIEMTRA_LOAINV]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 14/06/2018
-- Description:	Procedure kiểm tra loại nhân viên
-- =============================================
CREATE PROCEDURE [dbo].[KIEMTRA_LOAINV]
	@TENDANGNHAP NVARCHAR(40)
AS
BEGIN
	DECLARE @MANV CHAR(10)
	DECLARE @MALOAI_NV CHAR(10)
	SET @MANV = (SELECT MANV FROM TAIKHOAN WHERE TENDANGNHAP = @TENDANGNHAP)
	SET @MALOAI_NV = (SELECT MALOAI_NV FROM NHANVIEN WHERE MANV = @MANV)
	SELECT TENLOAI_NV FROM LOAINHANVIEN WHERE MALOAI_NV = @MALOAI_NV
END


GO
/****** Object:  StoredProcedure [dbo].[KIEMTRA_TENTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 14/06/2018
-- Description:	procedure kiểm tra TENTP có tồn tại hay không?
-- =============================================
CREATE PROCEDURE [dbo].[KIEMTRA_TENTP]
	@MAPHIEU CHAR(10),
	@TENTP NVARCHAR(40)
AS
BEGIN
	DECLARE @MATP CHAR(10)
	SET @MATP = (SELECT MATP FROM THUCPHAM WHERE TENTP = @TENTP)
	SELECT COUNT(MATP) FROM CT_PHIEUNHAP_TP WHERE MAPHIEU = @MAPHIEU AND MATP =  @MATP
END

GO
/****** Object:  StoredProcedure [dbo].[LAY_DSLOAIMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 16/06/2018
-- Description: Hàm lấy MAMA theo TENMA
-- =============================================
CREATE PROCEDURE [dbo].[LAY_DSLOAIMA]
AS
BEGIN
	SELECT * FROM LOAIMONAN
END
GO
/****** Object:  StoredProcedure [dbo].[LAY_DSMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 16/06/2018
-- Description: Hàm lấy MAMA theo TENMA
-- =============================================
CREATE PROCEDURE [dbo].[LAY_DSMA]
AS
BEGIN
	SELECT * FROM MONAN
END
GO
/****** Object:  StoredProcedure [dbo].[LAY_DSNHANVIEN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 16/06/2018
-- Description: Hàm lấy DSNHANVIEN theo TENMA
-- =============================================
CREATE PROCEDURE [dbo].[LAY_DSNHANVIEN]
AS
BEGIN
	SELECT * FROM NHANVIEN
END
GO
/****** Object:  StoredProcedure [dbo].[LAY_DSNHAPHANPHOI]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 16/06/2018
-- Description: Hàm lấy DSNHAPHANPHOI theo TENMA
-- =============================================
CREATE PROCEDURE [dbo].[LAY_DSNHAPHANPHOI]
AS
BEGIN
	SELECT * FROM NHAPHANPHOI
END
GO
/****** Object:  StoredProcedure [dbo].[LAY_DSTHUCPHAM]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 16/06/2018
-- Description: Hàm lấy DSTHUCPHAM
-- =============================================
CREATE PROCEDURE [dbo].[LAY_DSTHUCPHAM]
AS
BEGIN
	SELECT * FROM THUCPHAM
END

GO
/****** Object:  StoredProcedure [dbo].[LAY_GIATIEN_MONAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy giá tiền của MONAN
-- =============================================
CREATE PROCEDURE [dbo].[LAY_GIATIEN_MONAN]
	@TENMA NVARCHAR(100)
AS
BEGIN
	DECLARE @MAMA CHAR(10)
	SET @MAMA = (SELECT MAMA FROM MONAN WHERE TENMA = @TENMA)
	SELECT GIATIEN FROM MONAN WHERE MAMA = @MAMA
END

GO
/****** Object:  StoredProcedure [dbo].[LAY_GIATIEN_TP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy giá tiền của từng TP
-- =============================================
CREATE PROCEDURE [dbo].[LAY_GIATIEN_TP]
	@TENTP NVARCHAR(40)
AS
BEGIN
	DECLARE @MATP CHAR(10)
	SET @MATP = (SELECT MATP FROM THUCPHAM WHERE TENTP = @TENTP)
	SELECT GIA FROM THUCPHAM WHERE MATP = @MATP
END


GO
/****** Object:  StoredProcedure [dbo].[LAY_LOAIMA_TENMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 16/06/2018
-- Description: Hàm lấy MAMA theo TENMA
-- =============================================
CREATE PROCEDURE [dbo].[LAY_LOAIMA_TENMA]
	@TENMA NVARCHAR(100)
AS
BEGIN
	DECLARE @MAMA CHAR(10)
	SET @MAMA = (SELECT MAMA FROM MONAN WHERE TENMA = @TENMA)
	SELECT TENLOAI_MA FROM LOAIMONAN L JOIN MONAN M ON L.MALOAI_MA = M.MALOAI_MA 
	WHERE M.MAMA = @MAMA
END


GO
/****** Object:  StoredProcedure [dbo].[LAY_MAHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy MAHD tăng dần
-- =============================================
CREATE PROCEDURE [dbo].[LAY_MAHD]
AS
BEGIN
	SELECT MAHD = [dbo].AUTO_MAHD()
END



GO
/****** Object:  StoredProcedure [dbo].[LAY_MAMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy MAMA tăng dần
-- =============================================
CREATE PROCEDURE [dbo].[LAY_MAMA]
AS
BEGIN
	SELECT MAMA = [dbo].AUTO_MA_MA()
END

GO
/****** Object:  StoredProcedure [dbo].[LAY_MAMA_TENMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 16/06/2018
-- Description: Hàm lấy MAMA theo TENMA
-- =============================================
CREATE PROCEDURE [dbo].[LAY_MAMA_TENMA]
	@TENMA NVARCHAR(100)
AS
BEGIN
	SELECT MAMA FROM MONAN WHERE TENMA = @TENMA
END


GO
/****** Object:  StoredProcedure [dbo].[LAY_MANPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy MANPP tăng dần
-- =============================================
CREATE PROCEDURE [dbo].[LAY_MANPP]
AS
BEGIN
	SELECT MANPP = [dbo].AUTO_MANPP()
END
GO
/****** Object:  StoredProcedure [dbo].[LAY_MANV]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy MAHD tăng dần
-- =============================================
CREATE PROCEDURE [dbo].[LAY_MANV]
AS
BEGIN
	SELECT MANV = [dbo].AUTO_MA_NV()
END

GO
/****** Object:  StoredProcedure [dbo].[LAY_MAPHIEUNHAPTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy MAPHIEUNHAPTP
-- =============================================
CREATE PROCEDURE [dbo].[LAY_MAPHIEUNHAPTP]
AS
BEGIN
	SELECT MAPHIEU = [dbo].AUTO_MAPHIEU_NHAPTP()
END



GO
/****** Object:  StoredProcedure [dbo].[LAY_MATP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy MATP tăng dần
-- =============================================
CREATE PROCEDURE [dbo].[LAY_MATP]
AS
BEGIN
	SELECT MATP = [dbo].AUTO_MA_TP()
END
GO
/****** Object:  StoredProcedure [dbo].[LAY_TENLOAI_MA_MALOAI_MA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 16/06/2018
-- Description:	Hàm lấy tên loại món ăn dựa vào mã loại Món ăn
-- =============================================
CREATE PROCEDURE [dbo].[LAY_TENLOAI_MA_MALOAI_MA]
	@MALOAI_MA CHAR(10)
AS
BEGIN
	SELECT TENLOAI_MA FROM LOAIMONAN WHERE MALOAI_MA = @MALOAI_MA
END


GO
/****** Object:  StoredProcedure [dbo].[LAY_THANHTIEN_HOADON]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 14/06/2018
-- Description:	Lấy thành tiền của Hóa đơn
-- =============================================
CREATE PROCEDURE [dbo].[LAY_THANHTIEN_HOADON]
	@MAHD CHAR(10)
AS
BEGIN
	SELECT THANHTIEN FROM HOADON WHERE MAHD = @MAHD
END


GO
/****** Object:  StoredProcedure [dbo].[LAY_THANHTIEN_HOADONNHAPHANG]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy thành tiền dựa trên mã phiếu
-- =============================================
CREATE PROCEDURE [dbo].[LAY_THANHTIEN_HOADONNHAPHANG]
	@MAPHIEU CHAR(10)
AS
BEGIN
	SELECT THANHTIEN FROM PHIEUNHAP_TP WHERE MAPHIEU = @MAPHIEU
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_ALL_NHANVIEN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	Liệt kê tất cả TENDANGNHAP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_ALL_NHANVIEN]
AS
BEGIN
	SELECT N.MANV,N.HOTEN,L.TENLOAI_NV FROM NHANVIEN N JOIN LOAINHANVIEN L ON N.MALOAI_NV = L.MALOAI_NV
END
GO
/****** Object:  StoredProcedure [dbo].[LIETKE_ALL_TENDANGNHAP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	Liệt kê tất cả TENDANGNHAP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_ALL_TENDANGNHAP]
	@TENDANGNHAP NVARCHAR(40)
AS
BEGIN
	SELECT T.MANV,N.HOTEN,T.TENDANGNHAP,L.TENLOAI_NV FROM TAIKHOAN T JOIN NHANVIEN N ON T.MANV = N.MANV JOIN LOAINHANVIEN L ON N.MALOAI_NV = L.MALOAI_NV
	WHERE T.TENDANGNHAP = @TENDANGNHAP
END
GO
/****** Object:  StoredProcedure [dbo].[LIETKE_BANAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	Liệt kê tất cả BANAN
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_BANAN]
	@MABA CHAR(10)
AS
BEGIN
	SELECT * FROM  BANAN WHERE MABA = @MABA
END



GO
/****** Object:  StoredProcedure [dbo].[LIETKE_CT_MONAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	lietke_CT_MONAN
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_CT_MONAN]
	@MAMA CHAR(10)
AS
BEGIN
	select CT.MAMA, MA.TENMA, CT.MATP,TP.TENTP FROM (CTMA CT join THUCPHAM TP ON CT.MATP=TP.MATP) JOIN MONAN MA on CT.MAMA=MA.MAMA WHERE CT.MAMA = @MAMA  
END



GO
/****** Object:  StoredProcedure [dbo].[LIETKE_CT_MONAN_MAMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	lietke_CT_MONAN
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_CT_MONAN_MAMA]
	@MAMA CHAR(10)
AS
BEGIN
	select CT.MAMA, MA.TENMA, CT.MATP,TP.TENTP FROM (CTMA CT join THUCPHAM TP ON CT.MATP=TP.MATP) JOIN MONAN MA on CT.MAMA=MA.MAMA WHERE CT.MAMA = @MAMA  
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_CT_MONAN_TENMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	lietke_CT_MONAN
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_CT_MONAN_TENMA]
	@TENMA NVARCHAR(100)
AS
BEGIN
	DECLARE @MAMA CHAR(10)
	SET @MAMA = (SELECT MAMA FROM MONAN WHERE TENMA = @TENMA) 
	select CT.MAMA, MA.TENMA, CT.MATP,TP.TENTP FROM (CTMA CT join THUCPHAM TP ON CT.MATP=TP.MATP) JOIN MONAN MA on CT.MAMA=MA.MAMA WHERE CT.MAMA = @MAMA  
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_CT_PHIEU_YC]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	Liệt kê CT_PHIEU_YC
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_CT_PHIEU_YC]
	@MAPHIEU_YC CHAR(10)
AS
BEGIN
	SELECT * FROM CT_PHIEU_YC WHERE MAPHIEU_YC = @MAPHIEU_YC
END



GO
/****** Object:  StoredProcedure [dbo].[LIETKE_CT_PHIEUNHAPTHUCPHAM_MAPHIEU]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy thông tin Phiếu nhập TP dựa trên mã phiếu Nhập TP và Mã TP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_CT_PHIEUNHAPTHUCPHAM_MAPHIEU]
	@MAPHIEU CHAR(10)
AS
BEGIN
	SELECT C.MAPHIEU,C.MATP,T.TENTP,C.SL,C.DONGIA FROM CT_PHIEUNHAP_TP C JOIn THUCPHAM T ON C.MATP = T.MATP WHERE C.MAPHIEU = @MAPHIEU
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_CT_PHIEUNHAPTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy thông tin Phiếu nhập TP dựa trên mã phiếu Nhập TP và Mã TP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_CT_PHIEUNHAPTP]
	@MAPHIEU CHAR(10),
	@TENTP NVARCHAR(40)
AS
BEGIN
	DECLARE @MATP CHAR(10)
	SELECT @MATP = (SELECT MATP FROM THUCPHAM WHERE TENTP = @TENTP)
	SELECT C.MAPHIEU,C.MATP,T.TENTP,C.SL,C.DONGIA FROM CT_PHIEUNHAP_TP C JOIn THUCPHAM T ON C.MATP = T.MATP WHERE C.MAPHIEU = @MAPHIEU AND C.MATP = @MATP
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_CTHD_MAHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê CTHD dựa vào MAHD và MAMA
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_CTHD_MAHD]
	@MAHD CHAR(10)
AS
BEGIN
	SELECT MAHD,L.TENLOAI_MA, C.MAMA,M.TENMA,C.SL,C.DONGIA FROM CTHD C JOIN (MONAN M JOIN LOAIMONAN L ON M.MALOAI_MA = L.MALOAI_MA) ON C.MAMA = M.MAMA
	WHERE MAHD = @MAHD 
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_CTHD_MAHD_MAMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê CTHD dựa vào MAHD và MAMA
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_CTHD_MAHD_MAMA]
	@MAHD CHAR(10),
	@MAMA CHAR(10)
AS
BEGIN
	SELECT MAHD,C.MAMA,M.TENMA,C.SL,C.DONGIA FROM CTHD C JOIN MONAN M ON C.MAMA = M.MAMA
	WHERE MAHD = @MAHD AND C.MAMA =@MAMA
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_CTHD_MAHD_TENMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê CTHD dựa vào MAHD và MAMA
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_CTHD_MAHD_TENMA]
	@MAHD CHAR(10),
	@TENMA NVARCHAR(100)
AS
BEGIN
	DECLARE @MAMA CHAR(10)
	SET @MAMA = (SELECT MAMA FROM MONAN WHERE TENMA = @TENMA)
	SELECT MAHD,L.TENLOAI_MA, C.MAMA,M.TENMA,C.SL,C.DONGIA FROM CTHD C JOIN (MONAN M JOIN LOAIMONAN L ON M.MALOAI_MA = L.MALOAI_MA) ON C.MAMA = M.MAMA
	WHERE MAHD = @MAHD AND C.MAMA =@MAMA
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_DS_NHANVIEN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê tất cả nhân viên (mã NV, Tên NV, Loại NV)
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_DS_NHANVIEN]
AS
BEGIN
	SELECT NV.MANV,NV.HOTEN,LNV.TENLOAI_NV FROM NHANVIEN NV join LOAINHANVIEN LNV on NV.MALOAI_NV=LNV.MALOAI_NV
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MABA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 13/06/2018
-- Description:	Liệt kê tất cả MABA
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MABA]
AS
BEGIN
	SELECT MABA FROM  BANAN 
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MAHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 13/06/2018
-- Description:	Liệt kê tất cả MAHD
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MAHD]
AS
BEGIN
	SELECT MAHD FROM  HOADON 
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MAMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê MAMA trong MONAN
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MAMA]
AS
BEGIN
	SELECT MAMA FROM MONAN
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MANPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê MANPP từ bảng NHAPHANPHOI
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MANPP] 
AS
BEGIN
	SELECT MANPP FROM NHAPHANPHOI
END



GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MANPP_TENNPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê MANPP từ NAPHANPHOI biết tên NPP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MANPP_TENNPP]
@TENNPP nvarchar(40)
AS
BEGIN
	SELECT MANPP FROM NHAPHANPHOI
	WHERE TENNPP=@TENNPP
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MANV]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê MANV
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MANV] 
AS
BEGIN
	SELECT MANV FROM NHANVIEN
END



GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MATP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê MATP từ THUCPHAM
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MATP]
AS
BEGIN
	SELECT MATP FROM THUCPHAM
END



GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MATP_NPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy MATP của từng NPP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MATP_NPP] 
	@MANPP CHAR(10)
AS
BEGIN
	SELECT MATP FROM THUCPHAM WHERE MANPP = @MANPP
END



GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MATP_TENTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê MATP từ THUCPHAM biết tên tp
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MATP_TENTP]
@TENTP nvarchar(40)
AS
BEGIN
	SELECT MATP FROM THUCPHAM
	WHERE TENTP=@TENTP
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MONAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê tất cả món ăn
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MONAN]
AS
BEGIN
	SELECT MA.MAMA,MA.TENMA, MA.GIATIEN, LMA.TENLOAI_MA FROM MONAN MA join LOAIMONAN LMA on MA.MALOAI_MA=LMA.MALOAI_MA
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MONAN_MAMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê nhan vien ki biết tên món ăn
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MONAN_MAMA]
	@MAMA NVARCHAR(100)
AS
BEGIN
	SELECT * FROM MONAN
	WHERE MAMA = @MAMA
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_MONAN_TENMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê nhan vien ki biết tên món ăn
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_MONAN_TENMA]
	@TENMA NVARCHAR(100)
AS
BEGIN
	DECLARE @MAMA CHAR(10)
	SET @MAMA = (SELECT MAMA FROM MONAN WHERE TENMA = @TENMA)
	SELECT * FROM MONAN
	WHERE MAMA = @MAMA
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_NHANVIEN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê tất cả nhân viên
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_NHANVIEN]
AS
BEGIN
	SELECT MANV,HOTEN,NGAYSINH,GIOITINH,SODT,NGVL,L.TENLOAI_NV 
	FROM NHANVIEN N JOIN LOAINHANVIEN L ON N.MALOAI_NV = L.MALOAI_NV 
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_NHANVIEN_MANV]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê nhan vien ki biết mã nhân viên
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_NHANVIEN_MANV]
	@MANV CHAR(10)
AS
BEGIN
	SELECT MANV,HOTEN,NGAYSINH,GIOITINH,SODT,NGVL,L.TENLOAI_NV 
	FROM NHANVIEN N JOIN LOAINHANVIEN L ON N.MALOAI_NV = L.MALOAI_NV
	WHERE MANV = @MANV 
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_NHANVIEN_PHANQUYEN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Phân quyền nhan vien  ki biết mã nhân viên
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_NHANVIEN_PHANQUYEN]
	@MANV CHAR(10)
AS
BEGIN
	SELECT N.MANV, N.HOTEN, L.TENLOAI_NV  FROM NHANVIEN N join LOAINHANVIEN L ON N.MALOAI_NV=L.MALOAI_NV
	WHERE MANV = @MANV 
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_NPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê tất cả nhà phân phối
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_NPP]
AS
BEGIN
	SELECT * FROM NHAPHANPHOI
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_NPP_MANPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê nhà phân phối ki biết mã nhà phân phối
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_NPP_MANPP]
	@NPP CHAR(10)
AS
BEGIN
	SELECT * FROM NHAPHANPHOI
	WHERE MANPP = @NPP 
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_NPP_TENNPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê nhà phân phối ki biết ten nhà phân phối
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_NPP_TENNPP]
	@TENNPP NVARCHAR(40)
AS
BEGIN
	SELECT * FROM NHAPHANPHOI
	WHERE TENNPP = @TENNPP 
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_PHIEUNHAPTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 15/06/2018
-- Description:	Liệt kê tất cả phiếu nhập thực phẩm
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_PHIEUNHAPTP]
AS
BEGIN
	SELECT MAPHIEU FROM PHIEUNHAP_TP
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_TEN_NPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê TEN_NPP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_TEN_NPP] 
AS
BEGIN
	SELECT TENNPP FROM NHAPHANPHOI
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_TENDANGNHAP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	Liệt kê tất cả TENDANGNHAP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_TENDANGNHAP]
AS
BEGIN
	SELECT TENDANGNHAP FROM TAIKHOAN
END
GO
/****** Object:  StoredProcedure [dbo].[LIETKE_TENDANGNHAP_MANV]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	Liệt kê tất cả TENDANGNHAP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_TENDANGNHAP_MANV]
	@MANV CHAR(10)
AS
BEGIN
	SELECT TENDANGNHAP FROM TAIKHOAN WHERE MANV = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[LIETKE_TENLNV]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê TENLOAI_NV
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_TENLNV] 
AS
BEGIN
	SELECT TENLOAI_NV FROM LOAINHANVIEN
END



GO
/****** Object:  StoredProcedure [dbo].[LIETKE_TENLOAIMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 13/06/2018
-- Description:	Liệt kê TENLOAIMA trong MONAN
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_TENLOAIMA]
AS
BEGIN
	SELECT TENLOAI_MA FROM LOAIMONAN
END



GO
/****** Object:  StoredProcedure [dbo].[LIETKE_TENMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 13/06/2018
-- Description:	Liệt kê TENMA trong MONAN
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_TENMA]
AS
BEGIN
	SELECT TENMA FROM MONAN
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_TENMA_TENLOAI_MA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 13/06/2018
-- Description:	Liệt kê TENMA trong MONAN theo TENLOAI_MA
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_TENMA_TENLOAI_MA]
	@TENLOAI_MA NVARCHAR(40)
AS 
BEGIN
	DECLARE @MALOAI_MA CHAR(10)
	SET @MALOAI_MA = (SELECT MALOAI_MA FROM LOAIMONAN WHERE TENLOAI_MA = @TENLOAI_MA)
	SELECT TENMA FROM MONAN WHERE MALOAI_MA = @MALOAI_MA
END



GO
/****** Object:  StoredProcedure [dbo].[LIETKE_TENNPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê TENNPP từ bảng NHAPHANPHOI
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_TENNPP] 
AS
BEGIN
	SELECT TENNPP FROM NHAPHANPHOI
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_TENNV_MANV]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 15/06/2018
-- Description:	Liệt kê TeeeenNV dựa vào MãNV
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_TENNV_MANV]
	@MANV CHAR(10)
AS
BEGIN
	SELECT HOTEN FROM NHANVIEN WHERE MANV = @MANV;
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_TENTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 14/06/2018
-- Description:	Procedure liệt kê tất cả TenTP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_TENTP]
AS
BEGIN
	SELECT TENTP FROM THUCPHAM
END


GO
/****** Object:  StoredProcedure [dbo].[LIETKE_TENTP_MAMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 14/06/2018
-- Description:	Procedure liệt kê tất cả TenTP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_TENTP_MAMA]
	@MAMA CHAR(10)
AS
BEGIN
	
	SELECT TENTP FROM THUCPHAM T JOIN CTMA C ON T.MATP = C.MATP 
	WHERE C.MAMA = @MAMA
END
GO
/****** Object:  StoredProcedure [dbo].[LIETKE_THONGTINTAIKHOAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê MANPP từ NAPHANPHOI biết tên NPP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_THONGTINTAIKHOAN]
	@TENDANGNHAP nvarchar(40)
AS
BEGIN
	DECLARE @MANV CHAR(10)
	SET @MANV = (SELECT MANV FROM TAIKHOAN WHERE TENDANGNHAP = @TENDANGNHAP)
	SELECT N.MANV, N.HOTEN,L.TENLOAI_NV,N.SODT,N.NGAYSINH,N.NGVL FROM NHANVIEN N JOIN LOAINHANVIEN L ON N.MALOAI_NV = L.MALOAI_NV
	WHERE MANV = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[LIETKE_THUCPHAM]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê tất cả THỤC PHẨM
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_THUCPHAM]
AS
BEGIN
	SELECT T.MATP,T.TENTP,T.GIA,T.DONVI,N.TENNPP FROM THUCPHAM T join NHAPHANPHOI N on T.MANPP=N.MANPP
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_THUCPHAM_MATP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê LIETKE_THUCPHAM_MATP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_THUCPHAM_MATP]
	@MATP CHAR(10)
AS
BEGIN
	SELECT * FROM THUCPHAM
	WHERE MATP = @MATP 
END

GO
/****** Object:  StoredProcedure [dbo].[LIETKE_THUCPHAM_TENTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Liệt kê LIETKE_THUCPHAM_TENTP
-- =============================================
CREATE PROCEDURE [dbo].[LIETKE_THUCPHAM_TENTP]
	@TENTP NVARCHAR(40)
AS
BEGIN
	SELECT T.MATP,T.TENTP,T.GIA,T.DONVI,P.TENNPP FROM THUCPHAM T JOIN NHAPHANPHOI P ON T.MANPP = P.MANPP
	WHERE TENTP = @TENTP 
END
GO
/****** Object:  StoredProcedure [dbo].[RESET_TAI_KHOAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	THEMTAIKHOAN
-- =============================================
CREATE PROCEDURE [dbo].[RESET_TAI_KHOAN]
	@MANV CHAR(10),
	@TENDANGNHAP NVARCHAR(40),
	@MATKHAU NVARCHAR(40)
AS
BEGIN
	UPDATE TAIKHOAN
	SET MATKHAU = @MATKHAU 
	WHERE TENDANGNHAP = @TENDANGNHAP
	AND MANV = @MANV
END
GO
/****** Object:  StoredProcedure [dbo].[THANHTIEN_HOADON_MAHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Lấy THANHTIEN từ bảng HOADON dựa vào MAHD
-- =============================================
CREATE PROCEDURE [dbo].[THANHTIEN_HOADON_MAHD]
	@MAHD CHAR(10)
AS
BEGIN
	SELECT THANHTIEN FROM HOADON WHERE MAHD = @MAHD
END



GO
/****** Object:  StoredProcedure [dbo].[THANHTIEN_PHIEUNHAPTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Tính THANHTIEN từ PHIEUNHAP_TP dựa vào MAPHIEUNHAPTP
-- =============================================
CREATE PROCEDURE [dbo].[THANHTIEN_PHIEUNHAPTP]
	@MAPHIEU CHAR(10)
AS
BEGIN
	SELECT THANHTIEN FROM PHIEUNHAP_TP WHERE MAPHIEU = @MAPHIEU
END



GO
/****** Object:  StoredProcedure [dbo].[THEM_CT_PHIEUNHAP_TP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Thêm chi tiết phiếu nhập TP
-- =============================================
CREATE PROCEDURE [dbo].[THEM_CT_PHIEUNHAP_TP]
	@MAPHIEU CHAR(10),
	@TENTP NVARCHAR(40),
	@SL INT = 0,
	@DONGIA INT = 0
AS
BEGIN
	DECLARE @MATP CHAR(10)
	SELECT @MATP = (SELECT MATP FROM THUCPHAM WHERE TENTP = @TENTP)
	INSERT INTO CT_PHIEUNHAP_TP VALUES (@MAPHIEU,@MATP,@SL,@DONGIA)
END


GO
/****** Object:  StoredProcedure [dbo].[THEM_CT_PHIEUNHAPTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Thêm chi tiết phiếu nhập TP
-- =============================================
CREATE PROCEDURE [dbo].[THEM_CT_PHIEUNHAPTP]
	@MAPHIEU CHAR(10),
	@TENTP NVARCHAR(40),
	@SL INT = 0,
	@DONGIA INT = 0
AS
BEGIN
	DECLARE @MATP CHAR(10)
	SELECT @MATP = (SELECT MATP FROM THUCPHAM WHERE TENTP = @TENTP)
	INSERT INTO CT_PHIEUNHAP_TP VALUES (@MAPHIEU,@MATP,@SL,@DONGIA)
END

GO
/****** Object:  StoredProcedure [dbo].[THEM_MA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 15/06/2018
-- Description:	Thêm Món ăn
-- =============================================
CREATE PROCEDURE [dbo].[THEM_MA]
	@MAMA CHAR(10),
	@TENMA NVARCHAR(100),
	@GIATIEN INT,
	@TENLOAI_MA NVARCHAR(40)
AS
BEGIN
	DECLARE @MALOAI_MA CHAR(10)
	SET @MALOAI_MA = (SELECT MALOAI_MA FROM LOAIMONAN WHERE TENLOAI_MA = @TENLOAI_MA)
	INSERT INTO MONAN VALUES(@MAMA,@TENMA,@GIATIEN,@MALOAI_MA)
END


GO
/****** Object:  StoredProcedure [dbo].[THEM_NPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Thạch Cảnh Nhựt
-- Create date: 08/06/2018
-- Description:	Thêm NHÀ phân phối
-- =============================================
CREATE PROCEDURE [dbo].[THEM_NPP]
	@MANPP CHAR(10),
	@TENNPP	nvarchar(40),
	@DIACHI nvarchar(100)
AS
BEGIN
	INSERT INTO NHAPHANPHOI(MANPP,TENNPP,DIACHI) VALUES (@MANPP,@TENNPP, @DIACHI)
END
GO
/****** Object:  StoredProcedure [dbo].[THEM_PHIEUNHAPTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author: Thạch Cảnh Nhựt
-- Create date: 09/06/2018
-- Description:	Thêm phiếu nhập TP
-- =============================================
CREATE PROCEDURE [dbo].[THEM_PHIEUNHAPTP]
	@MAPHIEU CHAR(10),
	@NGNHAP SMALLDATETIME,
	@MANPP CHAR(10),
	@MANV CHAR(10),
	@THANHTIEN INT = 0 
AS
BEGIN
	INSERT INTO PHIEUNHAP_TP VALUES(@MAPHIEU,@NGNHAP,@MANPP,@MANV,@THANHTIEN)
END

GO
/****** Object:  StoredProcedure [dbo].[THEMCTHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Thạch Cảnh Nhựt
-- Create date: 06/08/2018
-- Description:	Thêm CTHD
-- =============================================
CREATE PROCEDURE [dbo].[THEMCTHD]
	@MAHD CHAR(10),
	@TENMA NVARCHAR(100),
	@SL INT = 0,
	@DONGIA INT = 0
AS
BEGIN
	DECLARE @MAMA CHAR(10)
	SET @MAMA = (SELECT MAMA FROM MONAN WHERE TENMA = @TENMA)
	INSERT INTO CTHD VALUES(@MAHD,@MAMA,@SL,@DONGIA)
END

GO
/****** Object:  StoredProcedure [dbo].[THEMHOADON]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Thạch Cảnh Nhựt
-- Create date: 08/06/2018
-- Description:	Thêm hóa đơn
-- =============================================
CREATE PROCEDURE [dbo].[THEMHOADON]
	@MAHD CHAR(10),
	@NGHD SMALLDATETIME,
	@MANV CHAR(10),
	@MABA CHAR(10) = NULL,
	@THANHTIEN INT = 0
AS
BEGIN
	IF(@MABA = '')
		SET @MABA = NULL
	INSERT INTO HOADON(MAHD,NGHD,MANV,MABA,THANHTIEN) VALUES (@MAHD,@NGHD,@MANV,@MABA,@THANHTIEN)
END

GO
/****** Object:  StoredProcedure [dbo].[THEMNV]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Thạch Cảnh Nhựt
-- Create date: 08/06/2018
-- Description:	Thêm nhân viên
-- =============================================
CREATE PROCEDURE [dbo].[THEMNV]
	@MANV CHAR(10),
	@HOTEN	nvarchar(40),
	@NGAYSINH smalldatetime,
	@GIOITINH nvarchar(10),
	@SODT	varchar(20),
	@NGVL	smalldatetime,
	@TENLOAI_NV char(10)
AS
BEGIN
	DECLARE @MALOAI_NV CHAR(10)
	SET @MALOAI_NV = (select MALOAI_NV from LOAINHANVIEN where TENLOAI_NV=@TENLOAI_NV)
	INSERT INTO NHANVIEN(MANV,HOTEN,NGAYSINH,GIOITINH,SODT,NGVL,MALOAI_NV) VALUES (@MANV,@HOTEN,@NGAYSINH,@GIOITINH,@SODT,@NGVL,@MALOAI_NV)
END
GO
/****** Object:  StoredProcedure [dbo].[THEMTAIKHOAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	Liệt kê tất cả TENDANGNHAP
-- =============================================
CREATE PROCEDURE [dbo].[THEMTAIKHOAN]
	@MANV CHAR(10),
	@TENDANGNHAP NVARCHAR(40),
	@MATKHAU NVARCHAR(40)
AS
BEGIN
	INSERT INTO TAIKHOAN VALUES(@MANV,@TENDANGNHAP,@MATKHAU)
END
GO
/****** Object:  StoredProcedure [dbo].[THEMTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Thạch Cảnh Nhựt
-- Create date: 08/06/2018
-- Description:	Thêm thực phẩm
-- =============================================
CREATE PROCEDURE [dbo].[THEMTP]
	@MATP CHAR(10),
	@TENTP	nvarchar(40),
	@GIA int,
	@DONVI nvarchar(20),
	@TEN_NPP nvarchar(40)
AS
BEGIN
	DECLARE @MANPP CHAR(10)
	SET @MANPP = (select MANPP from NHAPHANPHOI where TENNPP=@TEN_NPP)
	INSERT INTO THUCPHAM(MATP,TENTP,GIA,DONVI,MANPP) VALUES (@MATP,@TENTP,@GIA ,@DONVI,@MANPP)
END
GO
/****** Object:  StoredProcedure [dbo].[THONGKE_NAM]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Thống kê theo năm
-- =============================================
CREATE PROCEDURE [dbo].[THONGKE_NAM]
	@NAM INT
AS
BEGIN
	SELECT MONTH(NGHD) AS THÁNG, SUM(THANHTIEN) AS TỔNG FROM HOADON WHERE YEAR(NGHD) = @NAM GROUP BY MONTH(NGHD)
END



GO
/****** Object:  StoredProcedure [dbo].[THONGKE_SP_NAM]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Thống kê SP theo NĂM
-- =============================================
CREATE PROCEDURE [dbo].[THONGKE_SP_NAM]
	@NAM INT
AS
BEGIN
	SELECT CTHD.MAMA AS 'MÃ MÓN ĂN', SUM(HOADON.THANHTIEN) AS 'TỔNG' FROM HOADON JOIN CTHD
	ON HOADON.MAHD = CTHD.MAHD 
	WHERE YEAR(HOADON.NGHD) = @NAM
	GROUP BY CTHD.MAMA
END



GO
/****** Object:  StoredProcedure [dbo].[THONGKE_SP_NGAY_THANG_NAM]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Thống kê SP Theo NGAY THANG NAM
-- =============================================
CREATE PROCEDURE [dbo].[THONGKE_SP_NGAY_THANG_NAM]
	@NGAY INT,
	@THANG INT,
	@NAM INT
AS
BEGIN
	SELECT CTHD.MAMA AS 'MÃ MÓN ĂN', SUM(HOADON.THANHTIEN) AS 'TỔNG' FROM HOADON JOIN CTHD
	ON HOADON.MAHD = CTHD.MAHD 
	WHERE DAY(HOADON.NGHD) = @NGAY
	AND MONTH(HOADON.NGHD) = @THANG
	AND YEAR(HOADON.NGHD) = @NAM
	GROUP BY CTHD.MAMA
END



GO
/****** Object:  StoredProcedure [dbo].[THONGKE_SP_THANG_NAM]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description: Thống kê SP theo THANG và NAM	
-- =============================================
CREATE PROCEDURE [dbo].[THONGKE_SP_THANG_NAM]
	@THANG INT,
	@NAM INT
AS
BEGIN
	SELECT CTHD.MAMA AS 'MÃ MÓN ĂN', SUM(HOADON.THANHTIEN) AS 'TỔNG' FROM HOADON JOIN CTHD
	ON HOADON.MAHD = CTHD.MAHD 
	WHERE MONTH(HOADON.NGHD) = @THANG
	AND YEAR(HOADON.NGHD) = @NAM
	GROUP BY CTHD.MAMA
END



GO
/****** Object:  StoredProcedure [dbo].[THONGKE_THANG_NAM]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Thống kê theo tháng + năm
-- =============================================
CREATE PROCEDURE [dbo].[THONGKE_THANG_NAM] 
	@THANG INT,
	@NAM INT
AS
BEGIN
	SELECT DAY(NGHD) AS NGÀY,SUM(THANHTIEN) AS TỔNG FROM HOADON WHERE MONTH(NGHD) = @THANG AND YEAR(NGHD) = @NAM GROUP BY DAY(NGHD);
END



GO
/****** Object:  StoredProcedure [dbo].[THUCPHAM_TENTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	thêm thực phẩm
-- =============================================
CREATE PROCEDURE [dbo].[THUCPHAM_TENTP]
@tenTP nvarchar(40)
AS
BEGIN
	INSERT INTO THUCPHAM(MATP,TENTP) VALUES (dbo.AUTO_MA_TP(),@tenTP)
	
END


GO
/****** Object:  StoredProcedure [dbo].[TIMKIEM_HOADON_MAHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 15/6/2018
-- Description:	Hàm lấy thông tin hóa đơn dựa vào MAHD
-- =============================================
CREATE PROCEDURE [dbo].[TIMKIEM_HOADON_MAHD]
	@MAHD CHAR(10)
AS
BEGIN
	SELECT * FROM HOADON WHERE MAHD = @MAHD 
END


GO
/****** Object:  StoredProcedure [dbo].[TIMKIEM_PHIEUNHAPTP_MAPHIEU]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 15/6/2018
-- Description:	Hàm lấy thông tin hóa nhập hàng đơn dựa vào MAPHIEU
-- =============================================
CREATE PROCEDURE [dbo].[TIMKIEM_PHIEUNHAPTP_MAPHIEU]
	@MAPHIEU CHAR(10)
AS
BEGIN
	SELECT * FROM PHIEUNHAP_TP WHERE MAPHIEU = @MAPHIEU
END

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_MONAN_GIA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	UPDATE GIAMONAN
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_MONAN_GIA]
	@MAMA CHAR(10),
	@GIATIEN int
AS
BEGIN
	UPDATE MONAN SET GIATIEN = @GIATIEN WHERE MAMA=@MAMA;
END


GO
/****** Object:  StoredProcedure [dbo].[UPDATE_NHANVIEN_LOAINV]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	UPDATE LOẠI NHÂN VIÊN
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_NHANVIEN_LOAINV]
	@MANV CHAR(10),
	@TENLNV nvarchar(40)
AS
BEGIN
	UPDATE NHANVIEN SET MALOAI_NV = (select MALOAI_NV from LOAINHANVIEN where TENLOAI_NV=@TENLNV)
	WHERE MANV=@MANV;
END


GO
/****** Object:  StoredProcedure [dbo].[UPDATE_NHANVIEN_SODT]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	UPDATE SỐ ĐT
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_NHANVIEN_SODT]
	@MANV CHAR(10),
	@SODT VARCHAR(10)
AS
BEGIN
	UPDATE NHANVIEN SET SODT = @SODT  WHERE MANV=@MANV;
END


GO
/****** Object:  StoredProcedure [dbo].[UPDATE_NHAPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	UPDATE TÊN NHÀ PHÂN PHỐI
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_NHAPP]
	@MANPP CHAR(10),
	@TENNPP nvarchar(40)
AS
BEGIN
	UPDATE NHAPHANPHOI SET TENNPP =@TENNPP
	WHERE MANPP=@MANPP;
END

GO
/****** Object:  StoredProcedure [dbo].[UPDATE_NHAPP_DIACHI]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	UPDATE ĐỊA CHỈ NHÀ PHÂN PHỐI
-- =============================================
CREATE PROCEDURE [dbo].[UPDATE_NHAPP_DIACHI]
	@MANPP CHAR(10),
	@DIACHINPP nvarchar(40)
AS
BEGIN
	UPDATE NHAPHANPHOI SET DIACHI =@DIACHINPP
	WHERE MANPP=@MANPP;
END

GO
/****** Object:  StoredProcedure [dbo].[XOA_HOADON]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 15/06/2018
-- Description:	Xóa hóa đơn
-- =============================================
CREATE PROCEDURE [dbo].[XOA_HOADON]
	@MAHD CHAR(10)
AS
BEGIN
	DELETE FROM HOADON WHERE MAHD = @MAHD
END


GO
/****** Object:  StoredProcedure [dbo].[XOA_MONAN_CTHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 14/06/2018
-- Description:	Procedure xóa món ăn trong CTHD
-- =============================================
CREATE PROCEDURE [dbo].[XOA_MONAN_CTHD] 
	@MAHD CHAR(10),
	@TENMA NVARCHAR(100),
	@SL INT,
	@DONGIA INT
AS
BEGIN
	DECLARE @MAMA CHAR(10)
	SET @MAMA = (SELECT MAMA FROM MONAN WHERE TENMA = @TENMA)
	DELETE FROM CTHD WHERE MAHD = @MAHD AND MAMA = @MAMA AND SL = @SL AND DONGIA = @DONGIA
END

GO
/****** Object:  StoredProcedure [dbo].[XOA_PHIEUNHAP_TP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 15/06/2018
-- Description:	Xóa phiếu nhập hàng
-- =============================================
CREATE PROCEDURE [dbo].[XOA_PHIEUNHAP_TP]
	@MAPHIEU CHAR(10)
AS
BEGIN
	DELETE FROM PHIEUNHAP_TP WHERE MAPHIEU = @MAPHIEU
END

GO
/****** Object:  StoredProcedure [dbo].[XOA_THUCPHAM_CTMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 14/06/2018
-- Description:	Procedure xóa món ăn trong CTHD
-- =============================================
CREATE PROCEDURE [dbo].[XOA_THUCPHAM_CTMA] 
	@MAMA CHAR(10),
	@TENTP NVARCHAR(40)
AS
BEGIN
	DECLARE @MATP CHAR(10)
	SET @MATP = (SELECT MATP FROM THUCPHAM WHERE TENTP = @TENTP)
	DELETE FROM CTMA WHERE MAMA = @MAMA AND MATP = @MATP
END

GO
/****** Object:  StoredProcedure [dbo].[XOA_TP_CT_PHIEUNHAP_TP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 14/06/2018
-- Description:	Procedure xóa thực phẩm trong PHIEUNHAP_TP
-- =============================================
CREATE PROCEDURE [dbo].[XOA_TP_CT_PHIEUNHAP_TP] 
	@MAPHIEU CHAR(10),
	@TENTP NVARCHAR(40),
	@SL INT,
	@DONGIA INT
AS
BEGIN
	DECLARE @MATP CHAR(10)
	SET @MATP = (SELECT MATP FROM THUCPHAM WHERE TENTP = @TENTP)
	DELETE FROM CT_PHIEUNHAP_TP WHERE MAPHIEU = @MAPHIEU AND MATP = @MATP AND SL = @SL AND DONGIA = @DONGIA
END

GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MA_MA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	Hàm tăng món ăn
-- =============================================
CREATE FUNCTION [dbo].[AUTO_MA_MA]()
RETURNS CHAR(10)
AS
BEGIN 
	DECLARE @MAMA CHAR(10)
	DECLARE @MAX_MAMA INT

	SELECT @MAX_MAMA = COUNT(MAMA) FROM MONAN

	IF(@MAX_MAMA <= 0)
		SET @MAX_MAMA = 1
	ELSE 
		SET @MAX_MAMA = @MAX_MAMA + 1
	IF(@MAX_MAMA < 10)
		SET @MAMA = 'MA0000000' + CONVERT(CHAR(1),@MAX_MAMA)
	ELSE 
	IF(@MAX_MAMA < 100) 
		SET @MAMA = 'MA000000'+ CONVERT(CHAR(2),@MAX_MAMA)
	ELSE 
	IF(@MAX_MAMA < 1000)
		SET @MAMA = 'MA00000' + CONVERT(CHAR(3),@MAX_MAMA)
	ELSE
	IF(@MAX_MAMA < 10000)
		SET @MAMA = 'MA0000' + CONVERT(CHAR(4),@MAX_MAMA)
	ELSE
	IF(@MAX_MAMA < 100000)
		SET @MAMA = 'MA000' + CONVERT(CHAR(5),@MAX_MAMA)
	ELSE
	IF(@MAX_MAMA < 1000000)
		SET @MAMA = 'MA00' + CONVERT(CHAR(6),@MAX_MAMA)
	ELSE
	IF(@MAX_MAMA < 10000000)
		SET @MAMA = 'MA0' + CONVERT(CHAR(7),@MAX_MAMA)
	ELSE
	IF(@MAX_MAMA < 100000000)
		SET @MAMA = 'MA' + CONVERT(CHAR(8),@MAX_MAMA)
RETURN @MAMA
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MA_NV]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	Hàm tăng mã phiếu yêu cầu.
-- =============================================
CREATE FUNCTION [dbo].[AUTO_MA_NV]()
RETURNS CHAR(10)
AS
BEGIN 
	DECLARE @MANV CHAR(10)
	DECLARE @MAX_MANV INT

	SELECT @MAX_MANV = COUNT(MANV) FROM NHANVIEN

	IF(@MAX_MANV <= 0)
		SET @MAX_MANV = 1
	ELSE 
		SET @MAX_MANV = @MAX_MANV + 1
	IF(@MAX_MANV < 10)
		SET @MANV = 'NV0000000' + CONVERT(CHAR(1),@MAX_MANV)
	ELSE 
	IF(@MAX_MANV < 100) 
		SET @MANV = 'NV000000'+ CONVERT(CHAR(2),@MAX_MANV)
	ELSE 
	IF(@MAX_MANV < 1000)
		SET @MANV = 'NV00000' + CONVERT(CHAR(3),@MAX_MANV)
	ELSE
	IF(@MAX_MANV < 10000)
		SET @MANV = 'NV0000' + CONVERT(CHAR(4),@MAX_MANV)
	ELSE
	IF(@MAX_MANV < 100000)
		SET @MANV = 'NV000' + CONVERT(CHAR(5),@MAX_MANV)
	ELSE
	IF(@MAX_MANV < 1000000)
		SET @MANV = 'NV00' + CONVERT(CHAR(6),@MAX_MANV)
	ELSE
	IF(@MAX_MANV < 10000000)
		SET @MANV = 'NV0' + CONVERT(CHAR(7),@MAX_MANV)
	ELSE
	IF(@MAX_MANV < 100000000)
		SET @MANV = 'NV' + CONVERT(CHAR(8),@MAX_MANV)
RETURN @MANV
END


GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MA_PHIEUYC]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	Hàm tăng mã phiếu yêu cầu.
-- =============================================
CREATE FUNCTION [dbo].[AUTO_MA_PHIEUYC]()
RETURNS CHAR(10)
AS
BEGIN 
	DECLARE @MAPHIEUYC CHAR(10)
	DECLARE @MAX_MAPHIEUYC INT

	SELECT @MAX_MAPHIEUYC = COUNT(MAPHIEU_YC) FROM PHIEU_YC

	IF(@MAX_MAPHIEUYC <= 0)
		SET @MAX_MAPHIEUYC = 1
	ELSE 
		SET @MAX_MAPHIEUYC = @MAX_MAPHIEUYC + 1
	IF(@MAX_MAPHIEUYC < 10)
		SET @MAPHIEUYC = 'MYC000000' + CONVERT(CHAR(1),@MAX_MAPHIEUYC)
	ELSE 
	IF(@MAX_MAPHIEUYC < 100) 
		SET @MAPHIEUYC = 'MYC00000'+ CONVERT(CHAR(2),@MAX_MAPHIEUYC)
	ELSE 
	IF(@MAX_MAPHIEUYC < 1000)
		SET @MAPHIEUYC = 'MYC0000' + CONVERT(CHAR(3),@MAX_MAPHIEUYC)
	ELSE
	IF(@MAX_MAPHIEUYC < 10000)
		SET @MAPHIEUYC = 'MYC000' + CONVERT(CHAR(4),@MAX_MAPHIEUYC)
	ELSE
	IF(@MAX_MAPHIEUYC < 100000)
		SET @MAPHIEUYC = 'MYC00' + CONVERT(CHAR(5),@MAX_MAPHIEUYC)
	ELSE
	IF(@MAX_MAPHIEUYC < 1000000)
		SET @MAPHIEUYC = 'MYC0' + CONVERT(CHAR(6),@MAX_MAPHIEUYC)
	ELSE
	IF(@MAX_MAPHIEUYC < 10000000)
		SET @MAPHIEUYC = 'MYC' + CONVERT(CHAR(7),@MAX_MAPHIEUYC)
RETURN @MAPHIEUYC
END


GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MA_TP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 10/06/2018
-- Description:	Hàm tăng mã THực phẩm.
-- =============================================
CREATE FUNCTION [dbo].[AUTO_MA_TP]()
RETURNS CHAR(10)
AS
BEGIN 
	DECLARE @MATP CHAR(10)
	DECLARE @MAX_MATP INT

	SELECT @MAX_MATP = COUNT(MATP) FROM THUCPHAM

	IF(@MAX_MATP <= 0)
		SET @MAX_MATP = 1
	ELSE 
		SET @MAX_MATP = @MAX_MATP + 1
	IF(@MAX_MATP < 10)
		SET @MATP = 'TP0000000' + CONVERT(CHAR(1),@MAX_MATP)
	ELSE 
	IF(@MAX_MATP < 100) 
		SET @MATP = 'TP000000'+ CONVERT(CHAR(2),@MAX_MATP)
	ELSE 
	IF(@MAX_MATP < 1000)
		SET @MATP = 'TP00000' + CONVERT(CHAR(3),@MAX_MATP)
	ELSE
	IF(@MAX_MATP < 10000)
		SET @MATP = 'TP0000' + CONVERT(CHAR(4),@MAX_MATP)
	ELSE
	IF(@MAX_MATP < 100000)
		SET @MATP = 'TP000' + CONVERT(CHAR(5),@MAX_MATP)
	ELSE
	IF(@MAX_MATP < 1000000)
		SET @MATP  = 'TP00' + CONVERT(CHAR(6),@MAX_MATP)
	ELSE
	IF(@MAX_MATP < 10000000)
		SET @MATP = 'TP0' + CONVERT(CHAR(7),@MAX_MATP)
	ELSE
	IF(@MAX_MATP < 100000000)
		SET @MATP = 'TP' + CONVERT(CHAR(8),@MAX_MATP)
RETURN @MATP
END



GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MAHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 08/06/2018
-- Description:	Hàm tăng tự động mã hóa đơn
-- =============================================
CREATE FUNCTION [dbo].[AUTO_MAHD]()
RETURNS CHAR(10)
AS
BEGIN 
	DECLARE @MAHD CHAR(10)
	DECLARE @MAX_MAHD INT

	SELECT @MAX_MAHD = COUNT(MAHD) FROM HOADON

	IF(@MAX_MAHD <= 0)
		SET @MAX_MAHD = 1
	ELSE 
		SET @MAX_MAHD = @MAX_MAHD + 1
	IF(@MAX_MAHD < 10)
		SET @MAHD = 'HD0000000' + CONVERT(CHAR(1),@MAX_MAHD)
	ELSE 
	IF(@MAX_MAHD < 100) 
		SET @MAHD = 'HD000000'+ CONVERT(CHAR(2),@MAX_MAHD)
	ELSE 
	IF(@MAX_MAHD < 1000)
		SET @MAHD = 'HD00000' + CONVERT(CHAR(3),@MAX_MAHD)
	ELSE
	IF(@MAX_MAHD < 10000)
		SET @MAHD = 'HD0000' + CONVERT(CHAR(4),@MAX_MAHD)
	ELSE
	IF(@MAX_MAHD < 100000)
		SET @MAHD = 'HD000' + CONVERT(CHAR(5),@MAX_MAHD)
	ELSE
	IF(@MAX_MAHD < 1000000)
		SET @MAHD = 'HD00' + CONVERT(CHAR(6),@MAX_MAHD)
	ELSE
	IF(@MAX_MAHD < 10000000)
		SET @MAHD = 'HD0' + CONVERT(CHAR(7),@MAX_MAHD)
	ELSE
	IF(@MAX_MAHD < 100000000)
		SET @MAHD = 'HD' + CONVERT(CHAR(8),@MAX_MAHD)
RETURN @MAHD
END


GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MANPP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[AUTO_MANPP]()
RETURNS CHAR(10)
AS
BEGIN 
	DECLARE @MANPP CHAR(10)
	DECLARE @MAX_MANPP INT

	SELECT @MAX_MANPP = COUNT(MANPP) FROM NHAPHANPHOI

	IF(@MAX_MANPP <= 0)
		SET @MAX_MANPP = 1
	ELSE 
		SET @MAX_MANPP = @MAX_MANPP + 1
	IF(@MAX_MANPP < 10)
		SET @MANPP = 'NPP000000' + CONVERT(CHAR(1),@MAX_MANPP)
	ELSE 
	IF(@MAX_MANPP < 100) 
		SET @MANPP = 'NPP00000'+ CONVERT(CHAR(2),@MAX_MANPP)
	ELSE 
	IF(@MAX_MANPP < 1000)
		SET @MANPP = 'NPP0000' + CONVERT(CHAR(3),@MAX_MANPP)
	ELSE
	IF(@MAX_MANPP < 10000)
		SET @MANPP = 'NPP000' + CONVERT(CHAR(4),@MAX_MANPP)
	ELSE
	IF(@MAX_MANPP < 100000)
		SET @MANPP = 'NPP00' + CONVERT(CHAR(5),@MAX_MANPP)
	ELSE
	IF(@MAX_MANPP < 1000000)
		SET @MANPP = 'NPP0' + CONVERT(CHAR(6),@MAX_MANPP)
	ELSE
	IF(@MAX_MANPP < 10000000)
		SET @MANPP = 'NPP' + CONVERT(CHAR(7),@MAX_MANPP)
RETURN @MANPP
END
GO
/****** Object:  UserDefinedFunction [dbo].[AUTO_MAPHIEU_NHAPTP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:	Nguyễn Thị Anh
-- Create date: 09/06/2018
-- Description:	Hàm tăng mã phiếu
-- =============================================
CREATE FUNCTION [dbo].[AUTO_MAPHIEU_NHAPTP]()
RETURNS CHAR(10)
AS
BEGIN 
	DECLARE @MAPHIEU CHAR(10)
	DECLARE @MAX_MAPHIEU INT
	SELECT @MAX_MAPHIEU = COUNT(MAPHIEU) FROM PHIEUNHAP_TP

	IF(@MAX_MAPHIEU <= 0)
		SET @MAX_MAPHIEU = 1
	ELSE
		SET @MAX_MAPHIEU = @MAX_MAPHIEU + 1;
	IF(@MAX_MAPHIEU < 10)
		SET @MAPHIEU = 'PN0000000' + CONVERT(CHAR(1),@MAX_MAPHIEU)
	ELSE 
	IF(@MAX_MAPHIEU < 100) 
		SET @MAPHIEU = 'PN000000'+ CONVERT(CHAR(2),@MAX_MAPHIEU)
	ELSE 
	IF(@MAX_MAPHIEU < 1000)
		SET @MAPHIEU = 'PN00000' + CONVERT(CHAR(3),@MAX_MAPHIEU)
	ELSE
	IF(@MAX_MAPHIEU < 10000)
		SET @MAPHIEU = 'PN0000' + CONVERT(CHAR(4),@MAX_MAPHIEU)
	ELSE
	IF(@MAX_MAPHIEU < 100000)
		SET @MAPHIEU = 'PN000' + CONVERT(CHAR(5),@MAX_MAPHIEU)
	ELSE
	IF(@MAX_MAPHIEU < 1000000)
		SET @MAPHIEU = 'PN00' + CONVERT(CHAR(6),@MAX_MAPHIEU)
	ELSE
	IF(@MAX_MAPHIEU < 10000000)
		SET @MAPHIEU = 'PN0' + CONVERT(CHAR(7),@MAX_MAPHIEU)
	ELSE
	IF(@MAX_MAPHIEU < 100000000)
		SET @MAPHIEU = 'PN' + CONVERT(CHAR(8),@MAX_MAPHIEU)

RETURN @MAPHIEU
END

GO
/****** Object:  Table [dbo].[BANAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANAN](
	[MABA] [char](10) NOT NULL,
	[TENBA] [nvarchar](100) NULL,
	[TRANGTHAI] [nvarchar](100) NULL,
 CONSTRAINT [pk_ba] PRIMARY KEY CLUSTERED 
(
	[MABA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PHIEU_YC]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEU_YC](
	[MAPHIEU_YC] [char](10) NOT NULL,
	[MAMA] [char](10) NOT NULL,
	[SL] [int] NULL,
 CONSTRAINT [pk_ctpyc] PRIMARY KEY CLUSTERED 
(
	[MAPHIEU_YC] ASC,
	[MAMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PHIEUNHAP_TP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUNHAP_TP](
	[MAPHIEU] [char](10) NOT NULL,
	[MATP] [char](10) NOT NULL,
	[SL] [int] NULL,
	[DONGIA] [int] NULL,
 CONSTRAINT [pk_ctpntp] PRIMARY KEY CLUSTERED 
(
	[MAPHIEU] ASC,
	[MATP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHD](
	[MAHD] [char](10) NOT NULL,
	[MAMA] [char](10) NOT NULL,
	[SL] [int] NULL,
	[DONGIA] [int] NULL,
 CONSTRAINT [pk_cthd] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC,
	[MAMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTMA]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTMA](
	[MAMA] [char](10) NOT NULL,
	[MATP] [char](10) NOT NULL,
 CONSTRAINT [pk_ctma] PRIMARY KEY CLUSTERED 
(
	[MAMA] ASC,
	[MATP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHD] [char](10) NOT NULL,
	[NGHD] [smalldatetime] NULL,
	[MANV] [char](10) NULL,
	[MABA] [char](10) NULL,
	[THANHTIEN] [int] NULL,
 CONSTRAINT [pk_hd] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIMONAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIMONAN](
	[MALOAI_MA] [char](10) NOT NULL,
	[TENLOAI_MA] [nvarchar](40) NULL,
 CONSTRAINT [pk_loaima] PRIMARY KEY CLUSTERED 
(
	[MALOAI_MA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAINHANVIEN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAINHANVIEN](
	[MALOAI_NV] [char](10) NOT NULL,
	[TENLOAI_NV] [nvarchar](40) NULL,
 CONSTRAINT [pk_loainv] PRIMARY KEY CLUSTERED 
(
	[MALOAI_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MONAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MONAN](
	[MAMA] [char](10) NOT NULL,
	[TENMA] [nvarchar](100) NULL,
	[GIATIEN] [int] NULL,
	[MALOAI_MA] [char](10) NULL,
 CONSTRAINT [pk_ma] PRIMARY KEY CLUSTERED 
(
	[MAMA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [char](10) NOT NULL,
	[HOTEN] [nvarchar](40) NULL,
	[NGAYSINH] [smalldatetime] NULL,
	[GIOITINH] [nvarchar](10) NULL,
	[SODT] [varchar](20) NULL,
	[NGVL] [smalldatetime] NULL,
	[MALOAI_NV] [char](10) NULL,
 CONSTRAINT [pk_nv] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAPHANPHOI]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHAPHANPHOI](
	[MANPP] [char](10) NOT NULL,
	[TENNPP] [nvarchar](40) NULL,
	[DIACHI] [nvarchar](100) NULL,
 CONSTRAINT [pk_npp] PRIMARY KEY CLUSTERED 
(
	[MANPP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEU_YC]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEU_YC](
	[MAPHIEU_YC] [char](10) NOT NULL,
	[NGYC] [smalldatetime] NULL,
	[MABA] [char](10) NULL,
	[MANV] [char](10) NULL,
 CONSTRAINT [pk_pyc] PRIMARY KEY CLUSTERED 
(
	[MAPHIEU_YC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP_TP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP_TP](
	[MAPHIEU] [char](10) NOT NULL,
	[NGNHAP] [smalldatetime] NULL,
	[MANPP] [char](10) NULL,
	[MANV] [char](10) NULL,
	[THANHTIEN] [int] NULL,
 CONSTRAINT [pk_pntp] PRIMARY KEY CLUSTERED 
(
	[MAPHIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MANV] [char](10) NOT NULL,
	[TENDANGNHAP] [nvarchar](40) NOT NULL,
	[MATKHAU] [nvarchar](40) NULL,
 CONSTRAINT [pk_taikhoan] PRIMARY KEY CLUSTERED 
(
	[TENDANGNHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THUCPHAM]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THUCPHAM](
	[MATP] [char](10) NOT NULL,
	[TENTP] [nvarchar](40) NULL,
	[GIA] [int] NULL,
	[DONVI] [nvarchar](20) NULL,
	[MANPP] [char](10) NULL,
 CONSTRAINT [pk_tp] PRIMARY KEY CLUSTERED 
(
	[MATP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BANAN] ([MABA], [TENBA], [TRANGTHAI]) VALUES (N'MABA000001', N'bàn 1', N'trống')
INSERT [dbo].[BANAN] ([MABA], [TENBA], [TRANGTHAI]) VALUES (N'MABA000002', N'bàn 2', N'trống')
INSERT [dbo].[BANAN] ([MABA], [TENBA], [TRANGTHAI]) VALUES (N'MABA000003', N'bàn 3', N'trống')
INSERT [dbo].[BANAN] ([MABA], [TENBA], [TRANGTHAI]) VALUES (N'MABA000004', N'bàn 4', N'trống')
INSERT [dbo].[BANAN] ([MABA], [TENBA], [TRANGTHAI]) VALUES (N'MABA000005', N'bàn 5', N'trống')
INSERT [dbo].[BANAN] ([MABA], [TENBA], [TRANGTHAI]) VALUES (N'MABA000006', N'bàn 6', N'trống')
INSERT [dbo].[BANAN] ([MABA], [TENBA], [TRANGTHAI]) VALUES (N'MABA000007', N'bàn 7', N'trống')
INSERT [dbo].[BANAN] ([MABA], [TENBA], [TRANGTHAI]) VALUES (N'MABA000008', N'bàn 8', N'trống')
INSERT [dbo].[CT_PHIEU_YC] ([MAPHIEU_YC], [MAMA], [SL]) VALUES (N'MYC0000001', N'MA00000001', 1)
INSERT [dbo].[CT_PHIEU_YC] ([MAPHIEU_YC], [MAMA], [SL]) VALUES (N'MYC0000001', N'MA00000006', 1)
INSERT [dbo].[CT_PHIEU_YC] ([MAPHIEU_YC], [MAMA], [SL]) VALUES (N'MYC0000002', N'MA00000001', 2)
INSERT [dbo].[CT_PHIEU_YC] ([MAPHIEU_YC], [MAMA], [SL]) VALUES (N'MYC0000003', N'MA00000001', 4)
INSERT [dbo].[CT_PHIEU_YC] ([MAPHIEU_YC], [MAMA], [SL]) VALUES (N'MYC0000003', N'MA00000004', 1)
INSERT [dbo].[CT_PHIEU_YC] ([MAPHIEU_YC], [MAMA], [SL]) VALUES (N'MYC0000003', N'MA00000010', 4)
INSERT [dbo].[CT_PHIEUNHAP_TP] ([MAPHIEU], [MATP], [SL], [DONGIA]) VALUES (N'PN00000001', N'TP00000001', 50, 10000)
INSERT [dbo].[CT_PHIEUNHAP_TP] ([MAPHIEU], [MATP], [SL], [DONGIA]) VALUES (N'PN00000001', N'TP00000002', 50, 10000)
INSERT [dbo].[CT_PHIEUNHAP_TP] ([MAPHIEU], [MATP], [SL], [DONGIA]) VALUES (N'PN00000002', N'TP00000008', 4, 50000)
INSERT [dbo].[CT_PHIEUNHAP_TP] ([MAPHIEU], [MATP], [SL], [DONGIA]) VALUES (N'PN00000002', N'TP00000011', 30, 10000)
INSERT [dbo].[CT_PHIEUNHAP_TP] ([MAPHIEU], [MATP], [SL], [DONGIA]) VALUES (N'PN00000003', N'TP00000003', 10, 20000)
INSERT [dbo].[CT_PHIEUNHAP_TP] ([MAPHIEU], [MATP], [SL], [DONGIA]) VALUES (N'PN00000003', N'TP00000004', 20, 15000)
INSERT [dbo].[CT_PHIEUNHAP_TP] ([MAPHIEU], [MATP], [SL], [DONGIA]) VALUES (N'PN00000003', N'TP00000005', 20, 10000)
INSERT [dbo].[CT_PHIEUNHAP_TP] ([MAPHIEU], [MATP], [SL], [DONGIA]) VALUES (N'PN00000004', N'TP00000004', 3, 15000)
INSERT [dbo].[CT_PHIEUNHAP_TP] ([MAPHIEU], [MATP], [SL], [DONGIA]) VALUES (N'PN00000004', N'TP00000005', 5, 10000)
INSERT [dbo].[CT_PHIEUNHAP_TP] ([MAPHIEU], [MATP], [SL], [DONGIA]) VALUES (N'PN00000005', N'TP00000002', 3, 10000)
INSERT [dbo].[CT_PHIEUNHAP_TP] ([MAPHIEU], [MATP], [SL], [DONGIA]) VALUES (N'PN00000005', N'TP00000003', 5, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAMA], [SL], [DONGIA]) VALUES (N'HD00000001', N'MA00000001', 1, 25000)
INSERT [dbo].[CTHD] ([MAHD], [MAMA], [SL], [DONGIA]) VALUES (N'HD00000001', N'MA00000006', 1, 18000)
INSERT [dbo].[CTHD] ([MAHD], [MAMA], [SL], [DONGIA]) VALUES (N'HD00000002', N'MA00000001', 2, 25000)
INSERT [dbo].[CTHD] ([MAHD], [MAMA], [SL], [DONGIA]) VALUES (N'HD00000003', N'MA00000004', 1, 25000)
INSERT [dbo].[CTHD] ([MAHD], [MAMA], [SL], [DONGIA]) VALUES (N'HD00000003', N'MA00000007', 1, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAMA], [SL], [DONGIA]) VALUES (N'HD00000003', N'MA00000009', 2, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAMA], [SL], [DONGIA]) VALUES (N'HD00000004', N'MA00000001', 4, 25000)
INSERT [dbo].[CTHD] ([MAHD], [MAMA], [SL], [DONGIA]) VALUES (N'HD00000004', N'MA00000010', 4, 15000)
INSERT [dbo].[CTHD] ([MAHD], [MAMA], [SL], [DONGIA]) VALUES (N'HD00000005', N'MA00000004', 3, 25000)
INSERT [dbo].[CTHD] ([MAHD], [MAMA], [SL], [DONGIA]) VALUES (N'HD00000006', N'MA00000002', 3, 20000)
INSERT [dbo].[CTHD] ([MAHD], [MAMA], [SL], [DONGIA]) VALUES (N'HD00000006', N'MA00000006', 3, 18000)
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000001', N'TP00000001')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000001', N'TP00000002')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000001', N'TP00000003')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000002', N'TP00000001')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000002', N'TP00000002')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000002', N'TP00000003')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000003', N'TP00000002')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000004', N'TP00000012')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000005', N'TP00000003')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000006', N'TP00000004')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000007', N'TP00000006')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000007', N'TP00000010')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000008', N'TP00000008')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000008', N'TP00000009')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000009', N'TP00000011')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000010', N'TP00000012')
INSERT [dbo].[CTMA] ([MAMA], [MATP]) VALUES (N'MA00000011', N'TP00000010')
INSERT [dbo].[HOADON] ([MAHD], [NGHD], [MANV], [MABA], [THANHTIEN]) VALUES (N'HD00000001', CAST(0xA9010473 AS SmallDateTime), N'NV00000001', N'MABA000001', 43000)
INSERT [dbo].[HOADON] ([MAHD], [NGHD], [MANV], [MABA], [THANHTIEN]) VALUES (N'HD00000002', CAST(0xA9010473 AS SmallDateTime), N'NV00000002', N'MABA000002', 50000)
INSERT [dbo].[HOADON] ([MAHD], [NGHD], [MANV], [MABA], [THANHTIEN]) VALUES (N'HD00000003', CAST(0xA9010473 AS SmallDateTime), N'NV00000003', NULL, 75000)
INSERT [dbo].[HOADON] ([MAHD], [NGHD], [MANV], [MABA], [THANHTIEN]) VALUES (N'HD00000004', CAST(0xA9010473 AS SmallDateTime), N'NV00000003', N'MABA000004', 160000)
INSERT [dbo].[HOADON] ([MAHD], [NGHD], [MANV], [MABA], [THANHTIEN]) VALUES (N'HD00000005', CAST(0xA9000000 AS SmallDateTime), N'NV00000002', N'MABA000004', 75000)
INSERT [dbo].[HOADON] ([MAHD], [NGHD], [MANV], [MABA], [THANHTIEN]) VALUES (N'HD00000006', CAST(0xA9000000 AS SmallDateTime), N'NV00000003', N'MABA000004', 114000)
INSERT [dbo].[LOAIMONAN] ([MALOAI_MA], [TENLOAI_MA]) VALUES (N'LMA0000001', N'thức ăn ngọt')
INSERT [dbo].[LOAIMONAN] ([MALOAI_MA], [TENLOAI_MA]) VALUES (N'LMA0000002', N'thức ăn mặn')
INSERT [dbo].[LOAIMONAN] ([MALOAI_MA], [TENLOAI_MA]) VALUES (N'LMA0000003', N'nước giải khát')
INSERT [dbo].[LOAIMONAN] ([MALOAI_MA], [TENLOAI_MA]) VALUES (N'LMA0000004', N'kem')
INSERT [dbo].[LOAINHANVIEN] ([MALOAI_NV], [TENLOAI_NV]) VALUES (N'LNV0000001', N'addmin')
INSERT [dbo].[LOAINHANVIEN] ([MALOAI_NV], [TENLOAI_NV]) VALUES (N'LNV0000002', N'nhanvien')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000001', N'Hamburger', 25000, N'LMA0000002')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000002', N'Sandwich', 20000, N'LMA0000002')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000003', N'Bánh mì ngọt', 15000, N'LMA0000001')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000004', N'Nem nướng', 25000, N'LMA0000002')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000005', N'Nước Soda', 25000, N'LMA0000003')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000006', N'Nước nha dam', 18000, N'LMA0000003')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000007', N'kem Tràng Tiền', 20000, N'LMA0000004')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000008', N'kem Ốc Quế', 15000, N'LMA0000004')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000009', N'kem dừa', 15000, N'LMA0000004')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000010', N'kem que', 30000, N'LMA0000004')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000011', N'Kem Tươi', 20000, N'LMA0000002')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000012', N'Kem dứa', 15000, N'LMA0000002')
INSERT [dbo].[MONAN] ([MAMA], [TENMA], [GIATIEN], [MALOAI_MA]) VALUES (N'MA00000013', N'Banh trang tron', 15000, N'LMA0000002')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [GIOITINH], [SODT], [NGVL], [MALOAI_NV]) VALUES (N'NV00000001', N'Nguyen Nhu Nhut', CAST(0x00000000 AS SmallDateTime), N'Nam', N'927345678', CAST(0x00380000 AS SmallDateTime), N'LNV0000001')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [GIOITINH], [SODT], [NGVL], [MALOAI_NV]) VALUES (N'NV00000002', N'Le Thi Phi Yen', CAST(0x00000000 AS SmallDateTime), N'Nữ', N'987567390', CAST(0x00000000 AS SmallDateTime), N'LNV0000002')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [GIOITINH], [SODT], [NGVL], [MALOAI_NV]) VALUES (N'NV00000003', N'Nguyen Van B', CAST(0x00000000 AS SmallDateTime), N'Nam', N'997047382', CAST(0x00000000 AS SmallDateTime), N'LNV0000002')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [GIOITINH], [SODT], [NGVL], [MALOAI_NV]) VALUES (N'NV00000004', N'Ngo Thanh Tuan', CAST(0x00000000 AS SmallDateTime), N'Nam', N'913758498', CAST(0x00000000 AS SmallDateTime), N'LNV0000002')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [GIOITINH], [SODT], [NGVL], [MALOAI_NV]) VALUES (N'NV00000005', N'Nguyen Thi Truc Thanh', CAST(0x00000000 AS SmallDateTime), N'Nữ', N'918590387', CAST(0x00000000 AS SmallDateTime), N'LNV0000002')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [GIOITINH], [SODT], [NGVL], [MALOAI_NV]) VALUES (N'NV00000006', N'Nguyễn Thị Anh', CAST(0x8D31013F AS SmallDateTime), N'Nữ', N'01647782791', CAST(0xA8FF013F AS SmallDateTime), N'LNV0000002')
INSERT [dbo].[NHANVIEN] ([MANV], [HOTEN], [NGAYSINH], [GIOITINH], [SODT], [NGVL], [MALOAI_NV]) VALUES (N'NV00000007', N'Thạch Cảnh NHựt', CAST(0x8C900000 AS SmallDateTime), N'Nam', N'0967072612', CAST(0xA8FD0000 AS SmallDateTime), N'LNV0000002')
INSERT [dbo].[NHAPHANPHOI] ([MANPP], [TENNPP], [DIACHI]) VALUES (N'NPP0000001', N'Tiệm bánh mì Oppa', N'74 Võ Văn Ngân, Thủ Đức, HCM')
INSERT [dbo].[NHAPHANPHOI] ([MANPP], [TENNPP], [DIACHI]) VALUES (N'NPP0000002', N'Xưởng nem, Lạp xưởng Hoa Mai', N'170 Đặng Văn Bi, Bình Thọ, Thủ Đức, HCM')
INSERT [dbo].[NHAPHANPHOI] ([MANPP], [TENNPP], [DIACHI]) VALUES (N'NPP0000003', N'Đại lí phân phối kem Q2 collagen', N'115  Đường số 8, Phường 11, Gò Vấp, HCM')
INSERT [dbo].[NHAPHANPHOI] ([MANPP], [TENNPP], [DIACHI]) VALUES (N'NPP0000004', N'Nhà phân phối nước giải khát Phú Đức', N'37 Lý Thường Kiệt, Hóc Môn, HCM')
INSERT [dbo].[NHAPHANPHOI] ([MANPP], [TENNPP], [DIACHI]) VALUES (N'NPP0000005', N'Cửa hàng thịt heo Thanh Thảo', N'Đường 154,phường Tân Phú, quận 9, HCM')
INSERT [dbo].[NHAPHANPHOI] ([MANPP], [TENNPP], [DIACHI]) VALUES (N'NPP0000006', N'Cửa hàng rau củ quả Hà Anh', N'60A Đường 4,phường Linh Xuân, quận Thủ Đức, HCM')
INSERT [dbo].[NHAPHANPHOI] ([MANPP], [TENNPP], [DIACHI]) VALUES (N'NPP0000007', N'Nhà cung cấp Kem Tươi', N'Quận 7, TP HCM')
INSERT [dbo].[NHAPHANPHOI] ([MANPP], [TENNPP], [DIACHI]) VALUES (N'NPP0000008', N'Nhà phân phối thức ăn nhanh', N'Quận 9')
INSERT [dbo].[NHAPHANPHOI] ([MANPP], [TENNPP], [DIACHI]) VALUES (N'NPP0000009', N'Nhà phân phối ABC', N'Quận 11')
INSERT [dbo].[NHAPHANPHOI] ([MANPP], [TENNPP], [DIACHI]) VALUES (N'NPP0000010', N'Nha Phan Phoi XYZ', N'QUận Bình Thạnh')
INSERT [dbo].[PHIEU_YC] ([MAPHIEU_YC], [NGYC], [MABA], [MANV]) VALUES (N'MYC0000001', CAST(0xA9010473 AS SmallDateTime), N'MABA000001', N'NV00000001')
INSERT [dbo].[PHIEU_YC] ([MAPHIEU_YC], [NGYC], [MABA], [MANV]) VALUES (N'MYC0000002', CAST(0xA9010473 AS SmallDateTime), N'MABA000002', N'NV00000001')
INSERT [dbo].[PHIEU_YC] ([MAPHIEU_YC], [NGYC], [MABA], [MANV]) VALUES (N'MYC0000003', CAST(0xA9010473 AS SmallDateTime), N'MABA000004', N'NV00000002')
INSERT [dbo].[PHIEUNHAP_TP] ([MAPHIEU], [NGNHAP], [MANPP], [MANV], [THANHTIEN]) VALUES (N'PN00000001', CAST(0xA9010473 AS SmallDateTime), N'NPP0000001', N'NV00000003', 1000000)
INSERT [dbo].[PHIEUNHAP_TP] ([MAPHIEU], [NGNHAP], [MANPP], [MANV], [THANHTIEN]) VALUES (N'PN00000002', CAST(0xA9010473 AS SmallDateTime), N'NPP0000003', N'NV00000005', 500000)
INSERT [dbo].[PHIEUNHAP_TP] ([MAPHIEU], [NGNHAP], [MANPP], [MANV], [THANHTIEN]) VALUES (N'PN00000003', CAST(0xA9010473 AS SmallDateTime), N'NPP0000004', N'NV00000004', 500000)
INSERT [dbo].[PHIEUNHAP_TP] ([MAPHIEU], [NGNHAP], [MANPP], [MANV], [THANHTIEN]) VALUES (N'PN00000004', CAST(0xA9000000 AS SmallDateTime), N'NPP0000007', N'NV00000002', 95000)
INSERT [dbo].[PHIEUNHAP_TP] ([MAPHIEU], [NGNHAP], [MANPP], [MANV], [THANHTIEN]) VALUES (N'PN00000005', CAST(0xA9000000 AS SmallDateTime), N'NPP0000004', N'NV00000002', 130000)
INSERT [dbo].[TAIKHOAN] ([MANV], [TENDANGNHAP], [MATKHAU]) VALUES (N'NV00000002', N'2', N'2')
INSERT [dbo].[TAIKHOAN] ([MANV], [TENDANGNHAP], [MATKHAU]) VALUES (N'NV00000003', N'3', N'3')
INSERT [dbo].[TAIKHOAN] ([MANV], [TENDANGNHAP], [MATKHAU]) VALUES (N'NV00000007', N'aaaa', N'a')
INSERT [dbo].[TAIKHOAN] ([MANV], [TENDANGNHAP], [MATKHAU]) VALUES (N'NV00000001', N'addmin', N'addmin')
INSERT [dbo].[TAIKHOAN] ([MANV], [TENDANGNHAP], [MATKHAU]) VALUES (N'NV00000006', N'anh', N'a')
INSERT [dbo].[TAIKHOAN] ([MANV], [TENDANGNHAP], [MATKHAU]) VALUES (N'NV00000004', N'nv01', N'a')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000001', N'bánh mì mềm', 10000, N'cái', N'NPP0000001')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000002', N'bánh mì ngọt', 10000, N'cái', N'NPP0000001')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000003', N'Nước Soda', 20000, N'chai', N'NPP0000004')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000004', N'Nước nha dam', 15000, N'chai', N'NPP0000004')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000005', N'rau xà lách', 10000, N'kg', N'NPP0000006')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000006', N'thịt heo', 100000, N'kg', N'NPP0000005')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000007', N'nem', 10000, N'cái', N'NPP0000002')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000008', N'kem', 50000, N'kg', N'NPP0000003')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000009', N'bánh ốc quế', 1000, N'cái', N'NPP0000003')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000010', N'kem Tràng Tiền', 15000, N'cái', N'NPP0000003')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000011', N'kem dừa', 10000, N'cái', N'NPP0000003')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000012', N'kem que', 10000, N'cái', N'NPP0000003')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000013', N'Kem cây', 5000, N'Cây', N'NPP0000007')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000014', N'Nước Mirinda', 8000, N'Lon', N'NPP0000004')
INSERT [dbo].[THUCPHAM] ([MATP], [TENTP], [GIA], [DONVI], [MANPP]) VALUES (N'TP00000015', N'Bánh tráng trộn', 20000, N'cái', N'NPP0000006')
ALTER TABLE [dbo].[CT_PHIEU_YC]  WITH CHECK ADD  CONSTRAINT [fk01_CT_PHIEU_YC] FOREIGN KEY([MAPHIEU_YC])
REFERENCES [dbo].[PHIEU_YC] ([MAPHIEU_YC])
GO
ALTER TABLE [dbo].[CT_PHIEU_YC] CHECK CONSTRAINT [fk01_CT_PHIEU_YC]
GO
ALTER TABLE [dbo].[CT_PHIEU_YC]  WITH CHECK ADD  CONSTRAINT [fk02_CT_PHIEU_YC] FOREIGN KEY([MAMA])
REFERENCES [dbo].[MONAN] ([MAMA])
GO
ALTER TABLE [dbo].[CT_PHIEU_YC] CHECK CONSTRAINT [fk02_CT_PHIEU_YC]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP_TP]  WITH CHECK ADD  CONSTRAINT [fk01_CT_PHIEUNHAP_TP] FOREIGN KEY([MAPHIEU])
REFERENCES [dbo].[PHIEUNHAP_TP] ([MAPHIEU])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP_TP] CHECK CONSTRAINT [fk01_CT_PHIEUNHAP_TP]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP_TP]  WITH CHECK ADD  CONSTRAINT [fk02_CT_PHIEUNHAP_TP] FOREIGN KEY([MATP])
REFERENCES [dbo].[THUCPHAM] ([MATP])
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP_TP] CHECK CONSTRAINT [fk02_CT_PHIEUNHAP_TP]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [fk01_CTHD] FOREIGN KEY([MAHD])
REFERENCES [dbo].[HOADON] ([MAHD])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [fk01_CTHD]
GO
ALTER TABLE [dbo].[CTHD]  WITH CHECK ADD  CONSTRAINT [fk02_CTHD] FOREIGN KEY([MAMA])
REFERENCES [dbo].[MONAN] ([MAMA])
GO
ALTER TABLE [dbo].[CTHD] CHECK CONSTRAINT [fk02_CTHD]
GO
ALTER TABLE [dbo].[CTMA]  WITH CHECK ADD  CONSTRAINT [fk01_CTMA] FOREIGN KEY([MAMA])
REFERENCES [dbo].[MONAN] ([MAMA])
GO
ALTER TABLE [dbo].[CTMA] CHECK CONSTRAINT [fk01_CTMA]
GO
ALTER TABLE [dbo].[CTMA]  WITH CHECK ADD  CONSTRAINT [fk02_CTMA] FOREIGN KEY([MATP])
REFERENCES [dbo].[THUCPHAM] ([MATP])
GO
ALTER TABLE [dbo].[CTMA] CHECK CONSTRAINT [fk02_CTMA]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk01_HD] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk01_HD]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [fk02_HD] FOREIGN KEY([MABA])
REFERENCES [dbo].[BANAN] ([MABA])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [fk02_HD]
GO
ALTER TABLE [dbo].[MONAN]  WITH CHECK ADD  CONSTRAINT [fk01_MA] FOREIGN KEY([MALOAI_MA])
REFERENCES [dbo].[LOAIMONAN] ([MALOAI_MA])
GO
ALTER TABLE [dbo].[MONAN] CHECK CONSTRAINT [fk01_MA]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [fkn_NV] FOREIGN KEY([MALOAI_NV])
REFERENCES [dbo].[LOAINHANVIEN] ([MALOAI_NV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [fkn_NV]
GO
ALTER TABLE [dbo].[PHIEU_YC]  WITH CHECK ADD  CONSTRAINT [fk01_PHIEU_YC] FOREIGN KEY([MABA])
REFERENCES [dbo].[BANAN] ([MABA])
GO
ALTER TABLE [dbo].[PHIEU_YC] CHECK CONSTRAINT [fk01_PHIEU_YC]
GO
ALTER TABLE [dbo].[PHIEU_YC]  WITH CHECK ADD  CONSTRAINT [fk02_PHIEU_YC] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[PHIEU_YC] CHECK CONSTRAINT [fk02_PHIEU_YC]
GO
ALTER TABLE [dbo].[PHIEUNHAP_TP]  WITH CHECK ADD  CONSTRAINT [fk01_PHIEUNHAP_TP] FOREIGN KEY([MANPP])
REFERENCES [dbo].[NHAPHANPHOI] ([MANPP])
GO
ALTER TABLE [dbo].[PHIEUNHAP_TP] CHECK CONSTRAINT [fk01_PHIEUNHAP_TP]
GO
ALTER TABLE [dbo].[PHIEUNHAP_TP]  WITH CHECK ADD  CONSTRAINT [fk02_PHIEUNHAP_TP] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[PHIEUNHAP_TP] CHECK CONSTRAINT [fk02_PHIEUNHAP_TP]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [fk01_TAIKHOAN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [fk01_TAIKHOAN]
GO
ALTER TABLE [dbo].[THUCPHAM]  WITH CHECK ADD  CONSTRAINT [fk01_TP] FOREIGN KEY([MANPP])
REFERENCES [dbo].[NHAPHANPHOI] ([MANPP])
GO
ALTER TABLE [dbo].[THUCPHAM] CHECK CONSTRAINT [fk01_TP]
GO
/****** Object:  Trigger [dbo].[tr_updateHD]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create trigger [dbo].[tr_updateHD] on  [dbo].[CT_PHIEUNHAP_TP]
for INSERT as
begin
	Declare @DG int
	Declare @S int
	Declare @MP char(10)
	Select @S = SL , @DG = DONGIA  , @MP=b.MAPHIEU
	From PHIEUNHAP_TP a, inserted b
	where  a.MAPHIEU=b.MAPHIEU 
	update PHIEUNHAP_TP set THANHTIEN = (THANHTIEN + (@DG * @S) )where @MP= MAPHIEU 
end
GO
/****** Object:  Trigger [dbo].[trigger_CT_PHIEUNHAP_TP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trigger_CT_PHIEUNHAP_TP] on [dbo].[CT_PHIEUNHAP_TP]
for UPDATE as
begin
	Declare @DG int
	Declare @SL int
	Declare @MAPHIEU char(10)
	DECLARE @MATP CHAR(10)
	SELECT @SL = SL, @MAPHIEU = MAPHIEU , @MATP = MATP,@DG = DONGIA FROM INSERTED
	update PHIEUNHAP_TP set THANHTIEN = (THANHTIEN + (@DG * @SL) )where MAPHIEU = @MAPHIEU
end
GO
/****** Object:  Trigger [dbo].[TRIGGER_DELETE_CT_PHIEUNHAP_TP]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TRIGGER_DELETE_CT_PHIEUNHAP_TP] ON [dbo].[CT_PHIEUNHAP_TP]
FOR DELETE AS
BEGIN
	DECLARE @MAPHIEU CHAR(10)
	DECLARE @MATP CHAR(10)
	DECLARE @SL INT
	DECLARE @DONGIA INT
	SELECT @MAPHIEU = MAPHIEU , @MATP = MATP, @SL = SL, @DONGIA = DONGIA FROM DELETED
	UPDATE PHIEUNHAP_TP SET THANHTIEN = (THANHTIEN - ( @SL * @DONGIA )) WHERE MAPHIEU = @MAPHIEU
END
GO
/****** Object:  Trigger [dbo].[tr_updateHDBH]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tr_updateHDBH] on  [dbo].[CTHD]
for INSERT as
begin
	Declare @DG int
	Declare @S int
	Declare @MP char(10)
	Select @S = SL , @DG = DONGIA  , @MP=b.MAHD
	From HOADON a, inserted b
	where  a.MAHD=b.MAHD 
	update HOADON set THANHTIEN = (THANHTIEN + (@DG * @S) )where @MP= MAHD
end
GO
/****** Object:  Trigger [dbo].[TRIGGER_DELETE_MONAN]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TRIGGER_DELETE_MONAN] ON [dbo].[CTHD]
FOR DELETE AS
BEGIN
	DECLARE @MAHD CHAR(10)
	DECLARE @MAMA CHAR(10)
	DECLARE @SL INT
	DECLARE @DONGIA INT
	SELECT @MAHD = MAHD , @MAMA = MAMA, @SL = SL, @DONGIA = DONGIA FROM DELETED
	UPDATE HOADON SET THANHTIEN = (THANHTIEN - ( @SL * @DONGIA )) WHERE MAHD = @MAHD
END
GO
/****** Object:  Trigger [dbo].[trigger_update_HoaDon]    Script Date: 6/19/2018 11:45:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[trigger_update_HoaDon] on [dbo].[CTHD]
for UPDATE as
begin
	Declare @DG int
	Declare @S int
	Declare @MAHD char(10)
	DECLARE @MAMA CHAR(10)
	SELECT @S = SL, @MAHD = MAHD , @MAMA = MAMA,@DG = DONGIA FROM INSERTED
	update HOADON set THANHTIEN = (THANHTIEN + (@DG * @S) )where MAHD = @MAHD
end
GO
USE [master]
GO
ALTER DATABASE [QLCH_FAST_FOOD] SET  READ_WRITE 
GO
