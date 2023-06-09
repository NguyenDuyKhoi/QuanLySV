SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
create procedure [dbo].[deleteAccount]
@mataikhoan varchar(50)
as
begin
delete from Account where mataikhoan=@mataikhoan
if(@@ROWCOUNT >0) return 1;
else return 0;
end
GO