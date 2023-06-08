SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SelectAllAccount]
AS
select 
tentaikhoan,
matkhau
from Account
GO;
GO