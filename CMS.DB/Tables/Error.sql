CREATE TABLE [dbo].[Error](
	[ErrorId] [int] IDENTITY(1,1) NOT NULL,
	[ControllerName] [nvarchar](20) NULL,
	[MethodType] [nvarchar](20) NULL,
	[MethodName] [nvarchar](20) NULL,
	[UserId] [int] NOT NULL,
	[CompanyId] [int] NOT NULL,
	[BranchId] [int] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[ErrorMessage] [nvarchar](4000) NULL,
	[Model] [nvarchar](20) NULL,
 CONSTRAINT [PK_Error] PRIMARY KEY CLUSTERED 
(
	[ErrorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
