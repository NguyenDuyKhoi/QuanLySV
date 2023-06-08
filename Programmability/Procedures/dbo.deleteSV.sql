SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE proc [dbo].[deleteSV]
@masinhvien varchar(50)
as
begin
delete from SinhVien where masinhvien= @masinhvien
if(@@ROWCOUNT >0) return 1;
else return 0;
end
GO