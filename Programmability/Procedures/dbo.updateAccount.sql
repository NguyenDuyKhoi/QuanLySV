SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[updateAccount]
@tentaikhoan varchar(50),
@matkhau varchar(250)
AS 
BEGIN
UPDATE Account
SET
tentaikhoan=@tentaikhoan,
matkhau=@matkhau
IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
ELSE BEGIN RETURN 0 END;
END
GO