SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
create proc [dbo].[deleteMH]
@mamonhoc varchar(50)
as
begin
delete from MonHoc where mamonhoc= @mamonhoc
if(@@ROWCOUNT >0) return 1;
else return 0;
end
GO