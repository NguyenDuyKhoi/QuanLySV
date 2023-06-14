SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[MonHocChuaDangKy]
@masinhvien varchar(50)

as
begin
select
g.mamonhoc,
g.temmonhoc,
m.sotinchi
from MonHoc g
inner join MonHoc m on g.temmonhoc=m.temmonhoc
where g.mamonhoc not in (select mamonhoc from Diem where masinhvien=@masinhvien)
end
GO