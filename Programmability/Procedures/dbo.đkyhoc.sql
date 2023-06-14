SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[đkyhoc]
@masinhvien varchar(50),
@mamonhoc int
as 
begin
declare @v_lanhoc int,
@v_temmonhoc varchar(50),
@v_dangky int;
select @v_temmonhoc=temmonhoc
from MonHoc
where mamonhoc=@mamonhoc;
select @v_lanhoc=count(*)
from Diem d
inner join MonHoc g on d.mamonhoc=g.mamonhoc
where d.masinhvien=@masinhvien
and g.temmonhoc=@v_temmonhoc;
select @v_dangky=count(*)
from Diem d
inner join MonHoc g on d.mamonhoc=g.mamonhoc
where d.masinhvien=@masinhvien
and g.temmonhoc=@v_temmonhoc;
if @v_dangky>0 return -1; 
set @v_lanhoc=@v_lanhoc+1;
insert into Diem(masinhvien,mamonhoc,lanhoc)
values (@masinhvien,@mamonhoc,@v_lanhoc);
if @@ROWCOUNT>0 return 1 else return 0;
end
GO