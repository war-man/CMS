CREATE TABLE [dbo].[SuggestionOrComplain](
	[SuggestionOrComplainId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Value] [nvarchar](500) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
	[LastAccessedDate] [datetime] NOT NULL,
	[ModifiedBy] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Color] [varchar](10) NULL,
	[CompanyId] [int] NOT NULL,
	[BranchId] [int] NOT NULL,
 CONSTRAINT [PK_SuggestionOrComplain] PRIMARY KEY CLUSTERED 
(
	[SuggestionOrComplainId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
