SET QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
CREATE procedure [dbo].[dangnhap]
@loaitaikhoan varchar(10) ,
@tentaikhoan varchar(50),
@matkhau varchar(50)
 as
begin
if @loaitaikhoan='admin'
select * from AccountAdmin
where taikhoan = @tentaikhoan
and matkhau = @matkhau
else 
select * from Account
where tentaikhoan=@tentaikhoan
and matkhau=@matkhau;
end
GO