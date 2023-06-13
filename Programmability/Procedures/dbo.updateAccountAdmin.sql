SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[updateAccountAdmin]

@tentaikhoan varchar(50),
@matkhau varchar(250)

AS 
BEGIN
UPDATE AccountAdmin
SET
taikhoan=@tentaikhoan,
matkhau=@matkhau
IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
ELSE BEGIN RETURN 0 END;
END
GO