SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
create procedure [dbo].[MonDangKy]
@masinhvien varchar(30)
as 
begin
select
m.temmonhoc,
m.sotinchi
from Diem d
inner join MonHoc m on d.mamonhoc = m.mamonhoc
where d.masinhvien=@masinhvien;
end
GO