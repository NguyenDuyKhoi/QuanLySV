SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[selectSV]
@masinhvien varchar(50)
AS 
BEGIN
SELECT
ho,tendem,ten,convert(varchar(10),ngaysinh,103) as ngsinh,
gioitinh,
quequan,diachi,dienthoai,email
FROM SinhVien
WHERE masinhvien=@masinhvien;
END 
GO