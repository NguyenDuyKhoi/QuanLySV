CREATE TABLE [dbo].[AccountAdmin] (
  [taikhoan] [varchar](50) NOT NULL,
  [matkhau] [varchar](250) NULL,
  CONSTRAINT [PK_AccountAdmin] PRIMARY KEY CLUSTERED ([taikhoan])
)
ON [PRIMARY]
GO