SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SelectAllAccount]
@tukhoa nvarchar(50)

AS
select 
mataikhoan,
tentaikhoan,
matkhau
from Account
where
lower(tentaikhoan) like '%'+lower(trim(@tukhoa))+'%'
order by tentaikhoan;
GO