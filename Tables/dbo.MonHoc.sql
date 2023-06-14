CREATE TABLE [dbo].[MonHoc] (
  [mamonhoc] [int] IDENTITY,
  [temmonhoc] [nvarchar](150) NOT NULL,
  [sotinchi] [int] NULL,
  CONSTRAINT [PK_MonHoc_1] PRIMARY KEY CLUSTERED ([mamonhoc], [temmonhoc])
)
ON [PRIMARY]
GO