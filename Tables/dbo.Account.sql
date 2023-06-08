CREATE TABLE [dbo].[Account] (
  [tentaikhoan] [varchar](50) NOT NULL,
  [matkhau] [varchar](250) NULL,
  CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([tentaikhoan])
)
ON [PRIMARY]
GO