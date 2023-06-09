CREATE TABLE [dbo].[Account] (
  [mataikhoan] [varchar](50) NOT NULL,
  [tentaikhoan] [varchar](50) NOT NULL CONSTRAINT [df_tentaikhoan] DEFAULT ('Khoi'),
  [matkhau] [varchar](250) NULL CONSTRAINT [df_matkhau] DEFAULT ('123456'),
  CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([mataikhoan])
)
ON [PRIMARY]
GO