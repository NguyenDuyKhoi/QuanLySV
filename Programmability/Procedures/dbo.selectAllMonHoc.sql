SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[selectAllMonHoc]
@tukhoa1 nvarchar(50)

AS
select
mamonhoc,
temmonhoc,
sotinchi
from MonHoc
where 
 lower(temmonhoc) like '%'+lower(trim(@tukhoa1))+'%'
order by temmonhoc;
GO