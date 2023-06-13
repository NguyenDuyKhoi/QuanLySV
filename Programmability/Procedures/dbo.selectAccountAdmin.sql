SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[selectAccountAdmin]
@mataikhoan varchar(50)
AS
BEGIN
SELECT
taikhoan,
matkhau
FROM AccountAdmin
WHERE mataitaikhoan=@mataikhoan;
END
GO