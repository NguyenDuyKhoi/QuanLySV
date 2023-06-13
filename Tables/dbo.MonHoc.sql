CREATE TABLE [dbo].[MonHoc] (
  [mamonhoc] [int] IDENTITY,
  [temmonhoc] [nvarchar](150) NOT NULL,
  [sotinchi] [int] NULL,
  CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED ([mamonhoc])
)
ON [PRIMARY]
GO