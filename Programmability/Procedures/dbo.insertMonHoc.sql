SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
create procedure [dbo].[insertMonHoc]
@tenmonhoc nvarchar(150),
@sotinchi int
AS
BEGIN
INSERT INTO MonHoc
(
temmonhoc,
sotinchi)
VALUES(
@tenmonhoc,
@sotinchi);
IF @@ROWCOUNT>0 BEGIN RETURN 1 END
ELSE BEGIN RETURN 0 END;
END
GO