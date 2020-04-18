CREATE TABLE [dbo].[RightType](
	[RightTypeId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[CanEdit] [bit] NOT NULL,
	[CanView] [bit] NOT NULL,
	[CanUpdate] [bit] NOT NULL,
	[CanDelete] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[LastAccessedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Color] [varchar](10) NULL,
	[CompanyId] [int] NOT NULL,
	[BranchId] [int] NOT NULL,
 CONSTRAINT [PK_RightType] PRIMARY KEY CLUSTERED 
(
	[RightTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
