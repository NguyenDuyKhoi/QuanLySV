CREATE TABLE [dbo].[SinhVien] (
  [ngaytao] [datetime] NULL CONSTRAINT [DF_SinhVien_ngaytao] DEFAULT (getdate()),
  [nguoitao] [varchar](30) NULL CONSTRAINT [DF_SinhVien_nguoitao] DEFAULT ('adimin'),
  [ngaycapnhap] [datetime] NULL CONSTRAINT [DF_SinhVien_ngaycapnhap] DEFAULT (getdate()),
  [nguoicapnhap] [varchar](30) NULL CONSTRAINT [DF_SinhVien_nguoicapnhap] DEFAULT ('admin'),
  [masinhvien] [varchar](50) NOT NULL,
  [ho] [nvarchar](10) NOT NULL,
  [tendem] [nvarchar](20) NULL,
  [ten] [nvarchar](10) NOT NULL,
  [ngaysinh] [date] NULL,
  [gioitinh] [tinyint] NULL,
  [quequan] [nvarchar](150) NULL,
  [diachi] [nvarchar](150) NULL,
  [dienthoai] [varchar](30) NULL,
  [email] [varchar](150) NULL,
  CONSTRAINT [PK_SinhVien] PRIMARY KEY CLUSTERED ([masinhvien])
)
ON [PRIMARY]
GO