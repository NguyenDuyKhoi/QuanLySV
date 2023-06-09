SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[updateAccount]
@mataikhoan varchar(50),
@tentaikhoan varchar(50),
@matkhau varchar(250)

AS 
BEGIN
UPDATE Account
SET
tentaikhoan=@tentaikhoan,
matkhau=@matkhau
where mataikhoan=@mataikhoan
IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
ELSE BEGIN RETURN 0 END;
END
GO