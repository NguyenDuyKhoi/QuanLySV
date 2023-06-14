SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[MonDangKy]
@masinhvien varchar(30)
as 
begin
select
g.mamonhoc,

m.sotinchi
from Diem d

inner join MonHoc g on d.mamonhoc=g.mamonhoc
inner join MonHoc m on g.temmonhoc = m.temmonhoc

where d.masinhvien=@masinhvien;
end
GO