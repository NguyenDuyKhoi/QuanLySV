SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
create procedure [dbo].[updateSV]
@masinhvien varchar(50),
@ho nvarchar(10),
@tendem nvarchar(20),
@ten nvarchar(10),
@ngaysinh date,
@gioitinh tinyint,
@quequan nvarchar(150),
@diachi nvarchar(150),
@dienthoai varchar(30),
@email varchar(150)
AS
BEGIN
UPDATE SinhVien
SET
ho=@ho,
tendem=@tendem,
ngaysinh=@ngaysinh,
gioitinh=@gioitinh,
quequan=@quequan,
diachi=@diachi,
dienthoai=@dienthoai,
email=@email
WHERE masinhvien=@masinhvien;
IF @@ROWCOUNT >0 BEGIN RETURN 1 END
ELSE BEGIN RETURN 0 END;
END
GO