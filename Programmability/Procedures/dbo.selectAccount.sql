SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[selectAccount]
@tentaikhoan varchar(50)
AS
BEGIN
SELECT
tentaikhoan
matkhau
FROM Account
WHERE tentaikhoan=@tentaikhoan;
END
GO