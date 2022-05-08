
USE [IptDemo]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 9/05/2022 1:10:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 9/05/2022 1:10:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Currency] [nvarchar](20) NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateModified] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facilities]    Script Date: 9/05/2022 1:10:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facilities](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FacilityName] [nvarchar](200) NOT NULL,
	[BookingCountryId] [int] NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[MaturityDate] [datetime2](7) NOT NULL,
	[Limit] [decimal](18, 2) NOT NULL,
	[ProposalId] [int] NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateModified] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Facilities] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proposals]    Script Date: 9/05/2022 1:10:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proposals](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProposalName] [nvarchar](200) NOT NULL,
	[CustomerGrpName] [nvarchar](200) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Description] [nvarchar](2000) NOT NULL,
	[StatusId] [int] NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateModified] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Proposals] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProposalStatuses]    Script Date: 9/05/2022 1:10:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProposalStatuses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateModified] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ProposalStatuses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220505074158_InitialCreate', N'6.0.4')
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 
GO
INSERT [dbo].[Countries] ([Id], [Name], [Currency], [DateCreated], [DateModified]) VALUES (2, N'Australia', N'AUD', CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
SET IDENTITY_INSERT [dbo].[Facilities] ON 
GO
INSERT [dbo].[Facilities] ([Id], [FacilityName], [BookingCountryId], [StartDate], [MaturityDate], [Limit], [ProposalId], [DateCreated], [DateModified]) VALUES (3, N'Facility11
', 2, CAST(N'2020-03-31T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-31T00:00:00.0000000' AS DateTime2), CAST(225000000.00 AS Decimal(18, 2)), 2, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Facilities] ([Id], [FacilityName], [BookingCountryId], [StartDate], [MaturityDate], [Limit], [ProposalId], [DateCreated], [DateModified]) VALUES (4, N'Facility12
', 2, CAST(N'2020-03-31T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-31T00:00:00.0000000' AS DateTime2), CAST(125000000.00 AS Decimal(18, 2)), 2, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Facilities] ([Id], [FacilityName], [BookingCountryId], [StartDate], [MaturityDate], [Limit], [ProposalId], [DateCreated], [DateModified]) VALUES (6, N'Facility31
', 2, CAST(N'2020-03-31T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-31T00:00:00.0000000' AS DateTime2), CAST(305000000.00 AS Decimal(18, 2)), 2, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Facilities] ([Id], [FacilityName], [BookingCountryId], [StartDate], [MaturityDate], [Limit], [ProposalId], [DateCreated], [DateModified]) VALUES (7, N'Facility32
', 2, CAST(N'2020-03-31T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-31T00:00:00.0000000' AS DateTime2), CAST(235000000.00 AS Decimal(18, 2)), 4, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Facilities] ([Id], [FacilityName], [BookingCountryId], [StartDate], [MaturityDate], [Limit], [ProposalId], [DateCreated], [DateModified]) VALUES (8, N'Facility33
', 2, CAST(N'2020-03-31T00:00:00.0000000' AS DateTime2), CAST(N'2023-10-31T00:00:00.0000000' AS DateTime2), CAST(325000000.00 AS Decimal(18, 2)), 4, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Facilities] ([Id], [FacilityName], [BookingCountryId], [StartDate], [MaturityDate], [Limit], [ProposalId], [DateCreated], [DateModified]) VALUES (9, N'Facility33
', 2, CAST(N'2021-04-20T00:00:00.0000000' AS DateTime2), CAST(N'2023-09-30T00:00:00.0000000' AS DateTime2), CAST(325000000.00 AS Decimal(18, 2)), 4, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Facilities] OFF
GO
SET IDENTITY_INSERT [dbo].[Proposals] ON 
GO
INSERT [dbo].[Proposals] ([Id], [ProposalName], [CustomerGrpName], [Date], [Description], [StatusId], [DateCreated], [DateModified]) VALUES (2, N'proposal1
', N'customerGrpName1
', CAST(N'2021-12-10T00:00:00.0000000' AS DateTime2), N'Detailed description1
', 1, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Proposals] ([Id], [ProposalName], [CustomerGrpName], [Date], [Description], [StatusId], [DateCreated], [DateModified]) VALUES (3, N'proposal2
', N'customerGrpName2
', CAST(N'2017-01-13T00:00:00.0000000' AS DateTime2), N'Detailed description2
', 1, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Proposals] ([Id], [ProposalName], [CustomerGrpName], [Date], [Description], [StatusId], [DateCreated], [DateModified]) VALUES (4, N'proposal3
', N'customerGrpName3
', CAST(N'2020-05-01T00:00:00.0000000' AS DateTime2), N'Detailed description3
', 1, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Proposals] ([Id], [ProposalName], [CustomerGrpName], [Date], [Description], [StatusId], [DateCreated], [DateModified]) VALUES (5, N'proposal4
', N'customerGrpName4
', CAST(N'2014-06-17T00:00:00.0000000' AS DateTime2), N'Detailed description4
', 1, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Proposals] ([Id], [ProposalName], [CustomerGrpName], [Date], [Description], [StatusId], [DateCreated], [DateModified]) VALUES (6, N'proposal5
', N'customerGrpName5
', CAST(N'2012-08-20T00:00:00.0000000' AS DateTime2), N'Detailed description5
', 1, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Proposals] ([Id], [ProposalName], [CustomerGrpName], [Date], [Description], [StatusId], [DateCreated], [DateModified]) VALUES (7, N'proposal6
', N'customerGrpName6
', CAST(N'2017-08-02T00:00:00.0000000' AS DateTime2), N'Detailed description6
', 1, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Proposals] ([Id], [ProposalName], [CustomerGrpName], [Date], [Description], [StatusId], [DateCreated], [DateModified]) VALUES (8, N'proposal7
', N'customerGrpName7
', CAST(N'2012-08-20T00:00:00.0000000' AS DateTime2), N'Detailed description7
', 1, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Proposals] ([Id], [ProposalName], [CustomerGrpName], [Date], [Description], [StatusId], [DateCreated], [DateModified]) VALUES (9, N'proposal8
', N'customerGrpName8
', CAST(N'2021-12-19T00:00:00.0000000' AS DateTime2), N'Detailed description8
', 1, CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Proposals] OFF
GO
SET IDENTITY_INSERT [dbo].[ProposalStatuses] ON 
GO
INSERT [dbo].[ProposalStatuses] ([Id], [Status], [DateCreated], [DateModified]) VALUES (1, N'In Preparation', CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[ProposalStatuses] ([Id], [Status], [DateCreated], [DateModified]) VALUES (2, N'In Support', CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[ProposalStatuses] ([Id], [Status], [DateCreated], [DateModified]) VALUES (3, N'In Approve', CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[ProposalStatuses] ([Id], [Status], [DateCreated], [DateModified]) VALUES (4, N'Approved', CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2), CAST(N'2022-05-07T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[ProposalStatuses] OFF
GO
/****** Object:  Index [IX_Facilities_BookingCountryId]    Script Date: 9/05/2022 1:10:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_Facilities_BookingCountryId] ON [dbo].[Facilities]
(
	[BookingCountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Facilities_ProposalId]    Script Date: 9/05/2022 1:10:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_Facilities_ProposalId] ON [dbo].[Facilities]
(
	[ProposalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Proposals_StatusId]    Script Date: 9/05/2022 1:10:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_Proposals_StatusId] ON [dbo].[Proposals]
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Facilities]  WITH CHECK ADD  CONSTRAINT [FK_Facilities_Countries_BookingCountryId] FOREIGN KEY([BookingCountryId])
REFERENCES [dbo].[Countries] ([Id])
GO
ALTER TABLE [dbo].[Facilities] CHECK CONSTRAINT [FK_Facilities_Countries_BookingCountryId]
GO
ALTER TABLE [dbo].[Facilities]  WITH CHECK ADD  CONSTRAINT [FK_Facilities_Proposals_ProposalId] FOREIGN KEY([ProposalId])
REFERENCES [dbo].[Proposals] ([Id])
GO
ALTER TABLE [dbo].[Facilities] CHECK CONSTRAINT [FK_Facilities_Proposals_ProposalId]
GO
ALTER TABLE [dbo].[Proposals]  WITH CHECK ADD  CONSTRAINT [FK_Proposals_ProposalStatuses_StatusId] FOREIGN KEY([StatusId])
REFERENCES [dbo].[ProposalStatuses] ([Id])
GO
ALTER TABLE [dbo].[Proposals] CHECK CONSTRAINT [FK_Proposals_ProposalStatuses_StatusId]
GO
/****** Object:  StoredProcedure [dbo].[SP_GetProposalsWithFacilities]    Script Date: 9/05/2022 1:10:44 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_GetProposalsWithFacilities]
AS
BEGIN
	SELECT p.Id as ProposalId,
	   p.ProposalName,
	   p.CustomerGrpName,
	   p.Date,
	   p.Description,
	   ps.Status,
	   t.Id as FacilityId,
	   t.FacilityName,
	   t.Name Country,
	   t.Currency,
	   t.StartDate,
	   t.MaturityDate,
	   t.Limit
	FROM Proposals AS p with(nolock)
	JOIN ProposalStatuses AS ps with(nolock) ON p.StatusId = ps.Id
	LEFT JOIN (
		SELECT  f.Id,
				f.BookingCountryId,
				f.FacilityName,
				f.Limit,
				f.MaturityDate,
				f.StartDate,
				f.ProposalId,
				c.Currency,
				c.Name
		FROM Facilities AS f  with(nolock)
		LEFT JOIN Countries AS c with(nolock) ON f.BookingCountryId = c.Id
	) AS t ON p.Id = t.ProposalId
END
GO
USE [master]
GO
ALTER DATABASE [IptDemo] SET  READ_WRITE 
GO
