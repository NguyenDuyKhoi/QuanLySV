SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[updateMH]
@mamonhoc int,
@tenmonhoc nvarchar(150),
@sotinchi int
AS 
BEGIN
UPDATE MonHoc
SET

temmonhoc=@tenmonhoc,
sotinchi=@sotinchi
WHERE mamonhoc=@mamonhoc;
IF @@ROWCOUNT >0 BEGIN RETURN 1 END
ELSE BEGIN RETURN 0 END;
END
GO