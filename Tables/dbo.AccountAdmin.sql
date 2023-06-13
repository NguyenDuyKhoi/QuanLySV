CREATE TABLE [dbo].[AccountAdmin] (
  [mataitaikhoan] [varchar](50) NOT NULL,
  [taikhoan] [varchar](50) NOT NULL,
  [matkhau] [varchar](250) NULL,
  CONSTRAINT [PK_AccountAdmin] PRIMARY KEY CLUSTERED ([mataitaikhoan])
)
ON [PRIMARY]
GO