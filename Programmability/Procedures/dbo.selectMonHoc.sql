SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
create procedure [dbo].[selectMonHoc]
@mamonhoc int
AS
BEGIN
SELECT
temmonhoc,
sotinchi
from MonHoc
where mamonhoc=@mamonhoc;
END
GO