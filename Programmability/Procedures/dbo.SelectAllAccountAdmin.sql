SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[SelectAllAccountAdmin]
AS
select

taikhoan,
matkhau
from AccountAdmin
GO