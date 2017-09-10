﻿If Exists(Select* From sys.objects Where object_id = OBJECT_ID(N'[MXFESatPatentList]') And type in (N'U'))
	Drop Table [dbo].[MXFESatPatentList]
Go
Create Table [dbo].[MXFESatPatentList]
(
	-- multi-tenancy support
	[CompanyID]			int NOT NULL DEFAULT ((0)),

	-- surrogate/natural key
	[PatentID]			int NOT NULL,

	[ValidityStartDate]	smalldatetime NOT NULL,
	[ValidityEndDate]	smalldatetime NULL,

	-- handle concurrency
	[tstamp]			timestamp NOT NULL,

	-- basic audit fields
	[CreatedByID]		uniqueidentifier NOT NULL,
	[CreatedByScreenID]	char(8) NOT NULL,
	[CreatedDateTime]	smalldatetime NOT NULL,
	[LastModifiedByID]	uniqueidentifier NOT NULL,
	[LastModifiedByScreenID]	char(8) NOT NULL,
	[LastModifiedDateTime]		smalldatetime NOT NULL,

	CONSTRAINT MXFESatPatentList_PK PRIMARY KEY
	(
		[CompanyID] ASC,
		[PatentID] ASC
	)
)