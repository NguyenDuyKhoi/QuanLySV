SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[ThemMoiAccount]
  @tentaikhoan varchar(50),
  @matkhau varchar(250)
 
  AS 
  BEGIN 
  INSERT INTO Account
  (
  mataikhoan,
  tentaikhoan,matkhau)VALUES
  ( CAST(NEXT VALUE for sinhvienSeq as varchar(30)),@tentaikhoan,
  @matkhau)
  IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
  ELSE BEGIN RETURN 0 END;
  END
GO