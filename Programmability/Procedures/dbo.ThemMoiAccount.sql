SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
 create procedure [dbo].[ThemMoiAccount]
  @tentaikhoan varchar(50),
  @matkhau varchar(250)
  AS 
  BEGIN 
  INSERT INTO Account
  (
  tentaikhoan,
  matkhau)VALUES
  (@tentaikhoan,
  @matkhau)
  IF @@ROWCOUNT > 0 BEGIN RETURN 1 END
  ELSE BEGIN RETURN 0 END;
  END
GO