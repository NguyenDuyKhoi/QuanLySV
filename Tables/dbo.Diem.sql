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

ALTER TABLE [dbo].[Diem]
  ADD CONSTRAINT [FK_Diem_MonHoc] FOREIGN KEY ([mamonhoc]) REFERENCES [dbo].[MonHoc] ([mamonhoc])
GO

ALTER TABLE [dbo].[Diem]
  ADD CONSTRAINT [FK_Diem_SinhVien] FOREIGN KEY ([masinhvien]) REFERENCES [dbo].[SinhVien] ([masinhvien])
GO