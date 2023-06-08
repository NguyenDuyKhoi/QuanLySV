SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ThemMoiSV]
@Ho nvarchar(10),
@TenDem nvarchar(20),
@Ten nvarchar(10),
@NgaySinh date,
@GioiTinh tinyint,
@QueQuan nvarchar(150),
@DiaChi nvarchar (150),
@DienThoai varchar(30),
@Email varchar(150)
AS
  BEGIN
  INSERT INTO SinhVien
  (
   masinhvien,
   ho,tendem,ten,
   ngaysinh,gioitinh,
   quequan,diachi,
   dienthoai,email
   )VALUES
   ('19SV'+CAST(NEXT VALUE for sinhvienSeq as varchar(30)),
   @Ho,@TenDem,@Ten,
   @Ngaysinh,
   @GioiTinh,
   @QueQuan,@DiaChi,
   @DienThoai,@Email
   )
   IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
   ELSE BEGIN RETURN 0 END;
  END
GO