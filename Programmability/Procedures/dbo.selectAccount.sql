SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[selectAccount]
@mataikhoan varchar(50)
AS
BEGIN
SELECT
tentaikhoan,
matkhau
FROM Account
WHERE mataikhoan=@mataikhoan;
END
GO