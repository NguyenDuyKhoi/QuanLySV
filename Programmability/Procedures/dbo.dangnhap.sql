SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[dangnhap]
@taikhoan varchar(50),
@matkhau varchar(50)
 as
begin
select * from Account
where tentaikhoan = @taikhoan
and matkhau = @matkhau; 
end
GO