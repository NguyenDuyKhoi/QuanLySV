CREATE TABLE [dbo].[Diem] (
  [mamonhoc] [int] NOT NULL,
  [masinhvien] [varchar](50) NOT NULL,
  [lanhoc] [int] NOT NULL,
  [diemthilan1] [float] NULL,
  [diemthilan2] [float] NULL,
  CONSTRAINT [PK_Diem] PRIMARY KEY CLUSTERED ([mamonhoc], [masinhvien], [lanhoc])
)
ON [PRIMARY]
GO