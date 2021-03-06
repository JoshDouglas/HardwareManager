SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Admin]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Admin](
	[AdminID] [smallint] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Lease]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Lease](
	[LeaseID] [smallint] IDENTITY(1,1) NOT NULL,
	[HardwareID] [smallint] NULL,
	[ShippingID] [smallint] NULL,
	[AssetTag] [varchar](50) NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[ReturnedDate] [datetime] NULL,
	[ReplacedAsset] [varchar](50) NULL,
 CONSTRAINT [PK_Lease] PRIMARY KEY CLUSTERED 
(
	[LeaseID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Warranty]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Warranty](
	[WarrantyID] [smallint] IDENTITY(1,1) NOT NULL,
	[ShippingID] [smallint] NULL,
	[HardwareID] [smallint] NULL,
	[ReturnNum] [varchar](50) NULL,
	[ProblemDesc] [varchar](50) NULL,
	[SentDate] [datetime] NULL,
	[RecieveDate] [datetime] NULL,
	[RequestDate] [datetime] NULL,
 CONSTRAINT [PK_Warranty] PRIMARY KEY CLUSTERED 
(
	[WarrantyID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Shipping]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Shipping](
	[ShippingID] [smallint] IDENTITY(1,1) NOT NULL,
	[ShippingNum] [varchar](50) NULL,
 CONSTRAINT [PK_Shipping] PRIMARY KEY CLUSTERED 
(
	[ShippingID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[User](
	[UserID] [smallint] IDENTITY(1,1) NOT NULL,
	[LocationID] [smallint] NULL,
	[PurposeID] [smallint] NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[Longitude] [decimal](10, 5) NULL,
	[Latitude] [decimal](10, 5) NULL,
	[LoginName] [varchar](50) NULL,
	[CustomSoftware] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Purpose]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Purpose](
	[PurposeID] [smallint] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Purpose] PRIMARY KEY CLUSTERED 
(
	[PurposeID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserSoftware]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[UserSoftware](
	[UserSoftwareID] [smallint] IDENTITY(1,1) NOT NULL,
	[UserID] [smallint] NULL,
	[SoftwareID] [smallint] NULL,
 CONSTRAINT [PK_UserSoftware] PRIMARY KEY CLUSTERED 
(
	[UserSoftwareID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Software]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Software](
	[SoftwareID] [smallint] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Software] PRIMARY KEY CLUSTERED 
(
	[SoftwareID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Location]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Location](
	[LocationID] [smallint] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
	[Notes] [varchar](200) NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetModel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/12/2010
-- Description:	Gets a model.
-- =============================================

CREATE PROCEDURE [dbo].[GetModel]

@ModelName varchar(50)

AS

SELECT
	Manufacturer.CompanyName,
	Model.ModelName,
	Model.Description,
	Model.PartNumber
FROM
	Model
	INNER JOIN
	Manufacturer ON Model.ManufacturerId = Manufacturer.ManufacturerID
WHERE
	Model.ModelName = @ModelName' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetManufacturer]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/12/2010
-- Description:	Returns a manufacturer.
-- =============================================

CREATE PROCEDURE [dbo].[GetManufacturer]

@CompanyName varchar(50)

AS

SELECT
	CompanyName,
	ReturnAddress,
	PhoneNum,
	ReturnInstructions
FROM
	Manufacturer
WHERE
	CompanyName = @CompanyName' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteManufacturer]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Deletes a manufacturer.
-- =============================================

CREATE PROCEDURE [dbo].[DeleteManufacturer]

@CompanyName varchar(50),
@Success int OUTPUT

AS

DECLARE @ManufacturerID int
SET @ManufacturerID = (SELECT ManufacturerID FROM Manufacturer WHERE CompanyName = @CompanyName)

DELETE FROM
	Manufacturer
WHERE
	ManufacturerID = @ManufacturerID

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllManufactuerNames]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Returns the names of all manufacturers.
-- =============================================

CREATE PROCEDURE [dbo].[GetAllManufactuerNames]

AS

SELECT
	CompanyName
FROM
	Manufacturer' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllModelNames]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Returns all model names.
-- =============================================

CREATE PROCEDURE [dbo].[GetAllModelNames]

AS

SELECT
	ModelName
FROM
	Model' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteModel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Deletes a model.
-- =============================================

CREATE PROCEDURE [dbo].[DeleteModel]

@ModelName varchar(50),
@Success int OUTPUT

AS

DECLARE @ModelID int
SET @ModelID = (SELECT ModelID FROM Model WHERE ModelName = @ModelName)

DELETE FROM
	Model
WHERE
	ModelID = @ModelID

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Hardware]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Hardware](
	[HardwareID] [smallint] IDENTITY(1,1) NOT NULL,
	[UserID] [smallint] NULL,
	[ModelID] [smallint] NULL,
	[SerialNumber] [varchar](50) NULL,
	[Notes] [varchar](500) NULL,
	[IsLeased] [bit] NULL,
	[HostName] [varchar](50) NULL,
 CONSTRAINT [PK_Hardware] PRIMARY KEY CLUSTERED 
(
	[HardwareID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Model]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Model](
	[ModelID] [smallint] IDENTITY(1,1) NOT NULL,
	[ManufacturerID] [smallint] NULL,
	[Description] [varchar](500) NULL,
	[ModelName] [varchar](50) NULL,
	[PartNumber] [varchar](50) NULL,
 CONSTRAINT [PK_Model] PRIMARY KEY CLUSTERED 
(
	[ModelID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Manufacturer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Manufacturer](
	[ManufacturerID] [smallint] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) NULL,
	[ReturnAddress] [varchar](100) NULL,
	[PhoneNum] [varchar](50) NULL,
	[ReturnInstructions] [varchar](500) NULL,
 CONSTRAINT [PK_Manufacturer] PRIMARY KEY CLUSTERED 
(
	[ManufacturerID] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteAdmin]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Deletes an admin.
-- =============================================

CREATE PROCEDURE [dbo].[DeleteAdmin]

@UserName varchar(50),
@Success int OUTPUT

AS

DECLARE @AdminID int
SET @AdminID = (SELECT AdminID FROM Admin WHERE UserName = @UserName)

DELETE FROM
	Admin
WHERE
	AdminID = @AdminID

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAdmins]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Returns all the admin usernames.
-- =============================================

CREATE PROCEDURE [dbo].[GetAdmins]

AS

SELECT
	UserName
FROM
	Admin' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertAdmin]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/12/2010
-- Description:	Inserts a new admin.
-- =============================================

CREATE PROCEDURE [dbo].[InsertAdmin]

@UserName varchar(50),
@Password varchar(50),
@Success int OUTPUT

AS

DECLARE @Dupe varchar(50)
SET @Dupe = (SELECT AdminID FROM Admin WHERE UserName = @UserName)

-- Don''t insert duplicates.
IF @Dupe IS NULL
	BEGIN
		INSERT INTO
			Admin(UserName, Password)
		VALUES
			(@UserName, @Password)
	END
ELSE
	BEGIN
		SET @Success = 0 
		RETURN
	END


IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END




' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ValidateAdmin]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 10/12/2010
-- Description:	Validates an admin login.
-- =============================================

CREATE PROCEDURE [dbo].[ValidateAdmin]

@UserName varchar(50),
@Password varchar(50),
@Success int OUTPUT

AS

DECLARE @tempPassword varchar(50)
SET @tempPassword = (SELECT Password FROM Admin WHERE UserName = @UserName)

IF @Password = @tempPassword
	BEGIN
		SET @Success = 1
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 0
		RETURN
	END

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertHardware]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Inserts a new hardware.
-- =============================================

CREATE PROCEDURE [dbo].[InsertHardware]

@SerialNumber varchar(50),
@User varchar(50),
@Notes varchar(500),
@Model varchar(50),
@HasLease bit,
@AssetTag varchar(50),
@StartDate datetime,
@EndDate datetime,
@ReplacedAsset varchar(50)

AS

DECLARE @UserID int
SET @UserID = (SELECT UserID FROM [User] WHERE LoginName = @User)

DECLARE @ModelID int
SET @ModelID = (SELECT ModelID FROM Model WHERE ModelName = @Model)

DECLARE @DupeCheck int
SET @DupeCheck = (SELECT HardwareID FROM Hardware WHERE SerialNumber = @SerialNumber)

-- Check for duplicates.
IF @DupeCheck IS NOT NULL
	BEGIN
		RETURN
	END

INSERT INTO
	Hardware(UserID, ModelID, SerialNumber, Notes, IsLeased)
VALUES
	(@UserID, @ModelID, @SerialNumber, @Notes, @HasLease)

DECLARE @HardwareID int
SET @HardwareID = @@IDENTITY

-- Insert lease if there is one.
IF @HasLease = 1
	BEGIN
		INSERT INTO
			Lease(HardwareID, AssetTag, StartDate, EndDate, ReplacedAsset)
		VALUES
			(@HardwareID, @AssetTag, @StartDate, @EndDate, @ReplacedAsset)
	END



' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetHardware]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Returns all the information for a hardware.
-- =============================================

CREATE PROCEDURE [dbo].[GetHardware]

@SerialNumber varchar(30)

AS

SELECT
	Hardware.SerialNumber,
	[User].LoginName,
	Location.Description AS ''LDescription'',
	Hardware.Notes,
	Model.ModelName,
	Manufacturer.CompanyName,
	Hardware.IsLeased,
	Lease.AssetTag,
	Lease.StartDate,
	Lease.EndDate,
	Lease.ReplacedAsset
FROM
	Hardware
	INNER JOIN
	[User] ON Hardware.UserID = [User].UserID
	INNER JOIN
	Location ON [User].LocationID = Location.LocationID
	INNER JOIN
	Model ON Hardware.ModelID = Model.ModelID
	INNER JOIN
	Manufacturer ON Model.ManufacturerID = Manufacturer.ManufacturerID
	LEFT JOIN
	Lease ON Hardware.HardwareID = Lease.HardwareID
WHERE
	SerialNumber = @SerialNumber' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateHardware]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 04/05/2010
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[UpdateHardware]

@SerialNumber varchar(50),
@User varchar(50),
@Notes varchar(500),
@Model varchar(50),
@HasLease bit,
@AssetTag varchar(50),
@StartDate datetime,
@EndDate datetime,
@ReplacedAsset varchar(50),
@Success int OUTPUT

AS

DECLARE @UserID int
SET @UserID = (SELECT UserID FROM [User] WHERE LoginName = @User)

DECLARE @ModelID int
SET @ModelID = (SELECT ModelID FROM Model WHERE ModelName = @Model)

DECLARE @HardwareID int
SET @HardwareID = (SELECT HardwareID FROM Hardware WHERE SerialNumber = @SerialNumber)

UPDATE
	Hardware
SET
	UserID = @UserID,
	ModelID = @ModelID,
	Notes = @Notes,
	IsLeased = @HasLease
WHERE
	HardwareID = @HardwareID

DECLARE @LeaseID int
SET @LeaseID = (SELECT LeaseID FROM Lease WHERE HardwareID = @HardwareID)

-- Update the lease.
IF @HasLease = 1 AND @LeaseID IS NOT NULL
	BEGIN
		UPDATE 
			Lease
		SET
			AssetTag = @AssetTag,
			StartDate = @StartDate,
			EndDate = @EndDate,
			ReplacedAsset = @ReplacedAsset
		WHERE
			LeaseID = @LeaseID
	END

-- Insert the lease.
IF @HasLease = 1 AND @LeaseID IS NULL
	BEGIN
		INSERT INTO
			Lease(HardwareID, AssetTag, StartDate, EndDate, ReplacedAsset)
		VALUES
			(@HardwareID, @AssetTag, @StartDate, @EndDate, @ReplacedAsset)
	END

-- Delete the lease.
IF @HasLease = 0
	BEGIN
		DELETE FROM
			Lease
		WHERE
			LeaseID = @LeaseID
	END

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteHardware]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Deletes hardware and its lease information from the database.
-- =============================================

CREATE PROCEDURE [dbo].[DeleteHardware]

@SerialNumber varchar(50),
@Success int OUTPUT

AS

DECLARE @HardwareID int
SET @HardwareID = (SELECT HardwareID FROM Hardware WHERE SerialNumber = @SerialNumber)

DELETE FROM
	Lease
WHERE
	HardwareID = @HardwareID

DELETE FROM
	Hardware
WHERE
	HardwareID = @HardwareID

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Delete a user.
-- =============================================

CREATE PROCEDURE [dbo].[DeleteUser]

@LoginName varchar(50),
@Success int OUTPUT

AS

DECLARE @UserID int
SET @UserID = (SELECT UserID FROM [User] WHERE LoginName = @LoginName)

DELETE FROM
	[User]
WHERE
	UserID = @UserID

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UpdateUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Updates a user.
-- =============================================

CREATE PROCEDURE [dbo].[UpdateUser]

@FirstName varchar(50),
@LastName varchar(50),
@PhoneNumber varchar(50),
@LoginName varchar(50),
@Location varchar(50),
@Purpose varchar(50),
@Success int OUTPUT

AS

DECLARE @PurposeID smallint
SET @PurposeID = (SELECT PurposeID FROM Purpose WHERE Description = @Purpose)

DECLARE @LocationID smallint
SET @LocationID = (SELECT LocationID FROM Location WHERE Description = @Location)

DECLARE @UserID smallint
SET @UserID = (SELECT UserID FROM [User] WHERE LoginName = @LoginName)

UPDATE
	[User]
SET
	FirstName = @FirstName,
	LastName = @LastName,
	PhoneNumber = @PhoneNumber,
	LocationID = @LocationID,
	PurposeID = @PurposeID
WHERE
	UserID = @UserID

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllUsers]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Returns all users.
-- =============================================

CREATE PROCEDURE [dbo].[GetAllUsers]

AS

SELECT
	LoginName
FROM
	[User]' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/12/2010
-- Description:	Inserts a user.
-- =============================================

CREATE PROCEDURE [dbo].[InsertUser]


@FirstName varchar(50),
@LastName varchar(50),
@PhoneNumber varchar(50),
@LoginName varchar(50),
@Location varchar(50),
@Purpose varchar(50),
@Success int OUTPUT

AS

DECLARE @PurposeID smallint
SET @PurposeID = (SELECT PurposeID FROM Purpose WHERE Description = @Purpose)

DECLARE @LocationID smallint
SET @LocationID = (SELECT LocationID FROM Location WHERE Description = @Location)

DECLARE @Dupe varchar(50)
SET @Dupe = (SELECT UserID FROM [User] WHERE LoginName = @LoginName)

-- Don''t insert duplicates.
IF @Dupe IS NULL
	BEGIN
		INSERT INTO
			[User](FirstName, LastName, PhoneNumber, LoginName, LocationID, PurposeID)
		VALUES
			(@FirstName, @LastName, @PhoneNumber, @LoginName, @LocationID, @PurposeID)
	END
ELSE
	BEGIN
		SET @Success = 0
		RETURN
	END

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END



' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetUser]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/12/2010
-- Description:	Returns a user.
-- =============================================

CREATE PROCEDURE [dbo].[GetUser]

@LoginName varchar(50)

AS

SELECT
	[User].FirstName,
	[User].LastName,
	[User].PhoneNumber,
	[User].LoginName,
	Location.Description AS ''LDescription'',
	Purpose.Description AS ''PDescription''
FROM
	[User]
	INNER JOIN
	Location ON [User].LocationID = Location.LocationID
	INNER JOIN
	Purpose ON [User].PurposeID = Purpose.PurposeID
WHERE
	[User].LoginName = @LoginName' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllPurpose]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Returns all purposes.
-- =============================================

CREATE PROCEDURE [dbo].[GetAllPurpose]

AS

SELECT
	Description
FROM
	Purpose' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetAllLocationNames]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Return all locations descriptions.
-- =============================================

CREATE PROCEDURE [dbo].[GetAllLocationNames]

AS

SELECT
	Description
FROM
	Location' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteLocation]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/20/2010
-- Description:	Deletes a location.
-- =============================================

CREATE PROCEDURE [dbo].[DeleteLocation]

@Description varchar(50),
@Success int OUTPUT

AS

DECLARE @LocationID int
SET @LocationID = (SELECT LocationID FROM Location WHERE Description = @Description)

DELETE FROM
	Location
WHERE
	LocationID = @LocationID

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertLocation]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/12/2010
-- Description:	Inserts a location.
-- =============================================

CREATE PROCEDURE [dbo].[InsertLocation]

@Description varchar(50),
@Notes varchar(200),
@Success int OUTPUT

AS

DECLARE @Dupe varchar(50)
SET @Dupe = (SELECT LocationID FROM Location WHERE Description = @Description)

-- Don''t insert duplicates.
IF @Dupe IS NULL
	BEGIN
		INSERT INTO
			Location(Description, Notes)
		VALUES
			(@Description, @Notes)
	END
ELSE
	BEGIN
		SET @Success = 0
		RETURN
	END

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END


' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetLocation]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/12/2010
-- Description:	Returns a location.
-- =============================================

CREATE PROCEDURE [dbo].[GetLocation]

@Description varchar(50)

AS

SELECT
	Description,
	Notes
FROM
	Location
WHERE
	Description = @Description' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertModel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/12/2010
-- Description:	Inserts a model.
-- =============================================

CREATE PROCEDURE [dbo].[InsertModel]

@Manufacturer varchar(50),
@Description varchar(500),
@ModelName varchar(50),
@PartNumber varchar(50),
@Success int OUTPUT

AS

DECLARE @Dupe int
SET @Dupe = (SELECT ModelID FROM Model WHERE ModelName = @ModelName)

DECLARE @ManufacturerID int
SET @ManufacturerID = (SELECT ManufacturerID FROM Manufacturer WHERE CompanyName = @Manufacturer)

IF @Dupe IS NULL
	BEGIN
		INSERT INTO
			Model(ManufacturerID, Description, ModelName, PartNumber)
		VALUES
			(@ManufacturerID, @Description, @ModelName, @PartNumber)
	END
ELSE
	BEGIN
		SET @Success = 0
		RETURN
	END

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END
' 
END
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[InsertManufacturer]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- =============================================
-- Author:		Josh Douglas
-- Create date: 03/12/2010
-- Description:	Inserts a manufacturer.
-- =============================================

CREATE PROCEDURE [dbo].[InsertManufacturer]

@CompanyName varchar(50),
@ReturnAddress varchar(100),
@PhoneNum varchar(50),
@ReturnInstructions varchar(500),
@Success int OUTPUT

AS

DECLARE @Dupe varchar(50)
SET @Dupe = (SELECT ManufacturerID FROM Manufacturer WHERE CompanyName = @CompanyName)

-- Don''t insert duplicates.
IF @Dupe IS NULL
	BEGIN
		INSERT INTO
			Manufacturer(CompanyName, ReturnAddress, PhoneNum, ReturnInstructions)
		VALUES (@CompanyName, @ReturnAddress, @PhoneNum, @ReturnInstructions)
	END
ELSE
	BEGIN
		SET @Success = 0
		RETURN
	END

IF @@ERROR <> 0
	BEGIN
		SET @Success = 0
		RETURN
	END
ELSE
	BEGIN
		SET @Success = 1
		RETURN
	END

' 
END
