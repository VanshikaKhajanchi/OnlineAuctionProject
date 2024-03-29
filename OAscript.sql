USE [master]
GO
/****** Object:  Database [Online_Auction]    Script Date: 7/31/2019 9:30:52 AM ******/
CREATE DATABASE [Online_Auction]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Online_Auction', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Online_Auction.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Online_Auction_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Online_Auction_log.ldf' , SIZE = 816KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Online_Auction] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Online_Auction].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Online_Auction] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Online_Auction] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Online_Auction] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Online_Auction] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Online_Auction] SET ARITHABORT OFF 
GO
ALTER DATABASE [Online_Auction] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Online_Auction] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Online_Auction] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Online_Auction] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Online_Auction] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Online_Auction] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Online_Auction] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Online_Auction] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Online_Auction] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Online_Auction] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Online_Auction] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Online_Auction] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Online_Auction] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Online_Auction] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Online_Auction] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Online_Auction] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Online_Auction] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Online_Auction] SET RECOVERY FULL 
GO
ALTER DATABASE [Online_Auction] SET  MULTI_USER 
GO
ALTER DATABASE [Online_Auction] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Online_Auction] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Online_Auction] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Online_Auction] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Online_Auction] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Online_Auction]
GO
/****** Object:  Table [dbo].[AccountTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AccountTable](
	[AccountNo] [numeric](18, 0) IDENTITY(1,10001) NOT NULL,
	[UserID] [int] NOT NULL,
	[Balance] [money] NOT NULL,
	[Bank] [varchar](50) NULL,
	[BankAcctNo] [numeric](18, 0) NULL,
 CONSTRAINT [PK_AccountTable] PRIMARY KEY CLUSTERED 
(
	[AccountNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AuctionTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AuctionTable](
	[AuctionID] [int] IDENTITY(1,1) NOT NULL,
	[AucDate] [date] NOT NULL,
	[AucTime] [time](7) NOT NULL,
	[AucDuration] [decimal](18, 0) NULL,
	[SellerId] [int] NOT NULL,
 CONSTRAINT [PK_AuctionTable] PRIMARY KEY CLUSTERED 
(
	[AuctionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BidTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BidTable](
	[BidID] [int] IDENTITY(1,1) NOT NULL,
	[SellerID] [int] NOT NULL,
	[BuyerID] [int] NOT NULL,
	[ItemID] [int] NULL,
	[BidPrice] [money] NULL,
 CONSTRAINT [PK_BidTable] PRIMARY KEY CLUSTERED 
(
	[BidID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemTable](
	[ItemID] [int] NOT NULL,
	[ItemName] [varchar](50) NOT NULL,
	[SubCategoryID] [int] NOT NULL,
	[ItemDescription] [varchar](500) NULL,
	[SellerID] [int] NOT NULL,
	[BuyerID] [int] NULL,
	[Price] [money] NOT NULL,
	[AuctionID] [int] NULL,
	[BidID] [int] NULL,
	[ItemImage] [image] NOT NULL,
	[Duration] [datetime] NOT NULL,
	[StartDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ItemTable] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SubCategoryTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubCategoryTable](
	[SubCategoryID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[SubCategoryName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SubCategoryTable] PRIMARY KEY CLUSTERED 
(
	[SubCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransactionTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionTable](
	[TransId] [int] IDENTITY(1,1) NOT NULL,
	[SellerAccount] [numeric](18, 0) NOT NULL,
	[BuyerAccount] [numeric](18, 0) NOT NULL,
	[Amount] [money] NOT NULL,
	[TransTime] [time](7) NOT NULL,
	[TransDate] [time](7) NOT NULL,
	[ItemID] [int] NOT NULL,
 CONSTRAINT [PK_TransactionTable] PRIMARY KEY CLUSTERED 
(
	[TransId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserFName] [varchar](50) NOT NULL,
	[UserLName] [varchar](50) NOT NULL,
	[DOB] [datetime] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Phone] [numeric](10, 0) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[Country] [varchar](50) NOT NULL,
	[Zip] [numeric](10, 0) NULL,
	[Date_created] [datetime] NOT NULL,
	[AadharNumber] [varchar](50) NULL,
	[PassportNumber] [varchar](50) NULL,
	[Artist] [binary](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserID], [UserFName], [UserLName], [DOB], [Email], [Password], [Phone], [Address], [City], [Country], [Zip], [Date_created], [AadharNumber], [PassportNumber], [Artist]) VALUES (5, N'vanshika', N'Khajanchi', CAST(N'1997-04-30 00:00:00.000' AS DateTime), N'vanshikaagrawal@gmail.com', N'1234567890', CAST(235634576 AS Numeric(10, 0)), N'Indore', N'Indore', N'India', CAST(13546 AS Numeric(10, 0)), CAST(N'2019-06-07 00:00:00.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[Users] ([UserID], [UserFName], [UserLName], [DOB], [Email], [Password], [Phone], [Address], [City], [Country], [Zip], [Date_created], [AadharNumber], [PassportNumber], [Artist]) VALUES (6, N'rani', N'erwer', CAST(N'2012-02-02 00:00:00.000' AS DateTime), N'dsdgf', N'231234f', CAST(3123213 AS Numeric(10, 0)), N'12323WDE', N'RDEFRSWFR', N'GGRGR', CAST(1321 AS Numeric(10, 0)), CAST(N'2002-02-02 00:00:00.000' AS DateTime), N'1231212', N'45345345345', NULL)
INSERT [dbo].[Users] ([UserID], [UserFName], [UserLName], [DOB], [Email], [Password], [Phone], [Address], [City], [Country], [Zip], [Date_created], [AadharNumber], [PassportNumber], [Artist]) VALUES (7, N'vanshika', N'Khajanchi', CAST(N'1997-04-30 00:00:00.000' AS DateTime), N'WW@RR.COM', N'245', CAST(234235 AS Numeric(10, 0)), N'Indore', N'Indore', N'India', CAST(245245 AS Numeric(10, 0)), CAST(N'2003-02-02 00:00:00.000' AS DateTime), N'3463565', N'1111111', NULL)
INSERT [dbo].[Users] ([UserID], [UserFName], [UserLName], [DOB], [Email], [Password], [Phone], [Address], [City], [Country], [Zip], [Date_created], [AadharNumber], [PassportNumber], [Artist]) VALUES (9, N'vanshika', N'Khajanchi', CAST(N'2019-07-08 00:00:00.000' AS DateTime), N'grawal@gmail.com', N'123', CAST(1223344 AS Numeric(10, 0)), N'Indore', N'Indore', N'India', CAST(12222 AS Numeric(10, 0)), CAST(N'2019-07-18 10:05:14.637' AS DateTime), N'3434', N'1333', NULL)
INSERT [dbo].[Users] ([UserID], [UserFName], [UserLName], [DOB], [Email], [Password], [Phone], [Address], [City], [Country], [Zip], [Date_created], [AadharNumber], [PassportNumber], [Artist]) VALUES (10, N'Bhumika', N'Nikte', CAST(N'1997-07-18 00:00:00.000' AS DateTime), N'bhumika.nikte@zensar.com', N'123', CAST(1223344 AS Numeric(10, 0)), N'Indore', N'Indore', N'India', CAST(123 AS Numeric(10, 0)), CAST(N'2019-07-18 15:28:48.300' AS DateTime), N'123', N'123', NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_Users]    Script Date: 7/31/2019 9:30:52 AM ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [IX_Users] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT (getdate()) FOR [Date_created]
GO
ALTER TABLE [dbo].[AccountTable]  WITH CHECK ADD  CONSTRAINT [FK_User_Account] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[AccountTable] CHECK CONSTRAINT [FK_User_Account]
GO
ALTER TABLE [dbo].[AuctionTable]  WITH CHECK ADD  CONSTRAINT [FK_User_Auction] FOREIGN KEY([SellerId])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[AuctionTable] CHECK CONSTRAINT [FK_User_Auction]
GO
ALTER TABLE [dbo].[BidTable]  WITH CHECK ADD  CONSTRAINT [FK_BidTable_BidTable] FOREIGN KEY([BidID])
REFERENCES [dbo].[BidTable] ([BidID])
GO
ALTER TABLE [dbo].[BidTable] CHECK CONSTRAINT [FK_BidTable_BidTable]
GO
ALTER TABLE [dbo].[BidTable]  WITH CHECK ADD  CONSTRAINT [FK_buyerID] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[BidTable] CHECK CONSTRAINT [FK_buyerID]
GO
ALTER TABLE [dbo].[BidTable]  WITH CHECK ADD  CONSTRAINT [FK_ItemId] FOREIGN KEY([ItemID])
REFERENCES [dbo].[ItemTable] ([ItemID])
GO
ALTER TABLE [dbo].[BidTable] CHECK CONSTRAINT [FK_ItemId]
GO
ALTER TABLE [dbo].[BidTable]  WITH CHECK ADD  CONSTRAINT [FK_SellerId] FOREIGN KEY([SellerID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[BidTable] CHECK CONSTRAINT [FK_SellerId]
GO
ALTER TABLE [dbo].[ItemTable]  WITH CHECK ADD  CONSTRAINT [FK_AuctionID] FOREIGN KEY([AuctionID])
REFERENCES [dbo].[AuctionTable] ([AuctionID])
GO
ALTER TABLE [dbo].[ItemTable] CHECK CONSTRAINT [FK_AuctionID]
GO
ALTER TABLE [dbo].[ItemTable]  WITH CHECK ADD  CONSTRAINT [FK_BidID_Item] FOREIGN KEY([BidID])
REFERENCES [dbo].[BidTable] ([BidID])
GO
ALTER TABLE [dbo].[ItemTable] CHECK CONSTRAINT [FK_BidID_Item]
GO
ALTER TABLE [dbo].[ItemTable]  WITH CHECK ADD  CONSTRAINT [FK_BuyerID_Item] FOREIGN KEY([BuyerID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[ItemTable] CHECK CONSTRAINT [FK_BuyerID_Item]
GO
ALTER TABLE [dbo].[ItemTable]  WITH CHECK ADD  CONSTRAINT [FK_Category_Item] FOREIGN KEY([SubCategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[ItemTable] CHECK CONSTRAINT [FK_Category_Item]
GO
ALTER TABLE [dbo].[ItemTable]  WITH CHECK ADD  CONSTRAINT [FK_SubCatID] FOREIGN KEY([SubCategoryID])
REFERENCES [dbo].[SubCategoryTable] ([SubCategoryID])
GO
ALTER TABLE [dbo].[ItemTable] CHECK CONSTRAINT [FK_SubCatID]
GO
ALTER TABLE [dbo].[ItemTable]  WITH CHECK ADD  CONSTRAINT [FKSellerID_Item] FOREIGN KEY([SellerID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[ItemTable] CHECK CONSTRAINT [FKSellerID_Item]
GO
ALTER TABLE [dbo].[SubCategoryTable]  WITH CHECK ADD  CONSTRAINT [FK_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[SubCategoryTable] CHECK CONSTRAINT [FK_CategoryID]
GO
ALTER TABLE [dbo].[SubCategoryTable]  WITH CHECK ADD  CONSTRAINT [FK_SubCategoryTable_SubCategoryTable] FOREIGN KEY([SubCategoryID])
REFERENCES [dbo].[SubCategoryTable] ([SubCategoryID])
GO
ALTER TABLE [dbo].[SubCategoryTable] CHECK CONSTRAINT [FK_SubCategoryTable_SubCategoryTable]
GO
ALTER TABLE [dbo].[TransactionTable]  WITH CHECK ADD  CONSTRAINT [FK_BuyerAcct] FOREIGN KEY([BuyerAccount])
REFERENCES [dbo].[AccountTable] ([AccountNo])
GO
ALTER TABLE [dbo].[TransactionTable] CHECK CONSTRAINT [FK_BuyerAcct]
GO
ALTER TABLE [dbo].[TransactionTable]  WITH CHECK ADD  CONSTRAINT [FK_ItemID_Transaction] FOREIGN KEY([ItemID])
REFERENCES [dbo].[ItemTable] ([ItemID])
GO
ALTER TABLE [dbo].[TransactionTable] CHECK CONSTRAINT [FK_ItemID_Transaction]
GO
ALTER TABLE [dbo].[TransactionTable]  WITH CHECK ADD  CONSTRAINT [FK_SellerAcct] FOREIGN KEY([SellerAccount])
REFERENCES [dbo].[AccountTable] ([AccountNo])
GO
ALTER TABLE [dbo].[TransactionTable] CHECK CONSTRAINT [FK_SellerAcct]
GO
/****** Object:  StoredProcedure [dbo].[sp_CheckCredentials]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CheckCredentials]
	@Email varchar(50),
	@Password varchar(50)
AS
	SELECT * from Users
RETURN 0
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteAccountTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_DeleteAccountTable]
@AccountNo numeric(18,0)
as
begin
set nocount on;
delete from AccountTable
where AccountNo=@AccountNo
end

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteAuctionTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteAuctionTable]
	-- Add the parameters for the stored procedure here
	@AuctionID int
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from AuctionTable where AuctionID = @AuctionID;
END


GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteBidTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteBidTable] 
	-- Add the parameters for the stored procedure here
	@BidID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete from BidTable where BidID=@BidID
END


GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCategory]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteCategory] 
	-- Add the parameters for the stored procedure here
	@CategoryID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from Category where CategoryID = @CategoryID;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteItemTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_DeleteItemTable]
@ItemID int
as
begin
set nocount on;
delete from ItemTable
where ItemID=@ItemID
end

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteSubCategoryTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_DeleteSubCategoryTable]
@SubCategoryID int
as
begin
set nocount on;
delete from SubCategoryTable
where SubCategoryID=@SubCategoryID
end


GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteTransactionTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_DeleteTransactionTable]
@TransId int
as
begin
set nocount on;
delete from TransactionTable
where TransId=@TransId
end


GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteUsers]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteUsers] 
	-- Add the parameters for the stored procedure here
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from Users where UserID = @UserID;
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertAccountTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertAccountTable]  
@AccountNo numeric(18,0),  
@UserID int,  
@Balance money,  
@Bank varchar(50),
@BankAcctNo numeric(18,0)
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into AccountTable (AccountNo,UserID,Balance,Bank,BankAcctNo)   
           Values (@AccountNo,@UserID,@Balance,@Bank,@BankAcctNo)
		   END  

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertAuctionTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertAuctionTable]
	-- Add the parameters for the stored procedure here
	@AuctionID int,
	@AucDate date,
	@AucTime time(7),
	@AucDuration decimal(18,0),
	@SellerId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into AuctionTable(AuctionID,AucDate,AucTime,AucDuration,SellerId)values
	(@AuctionID,@AucDate,@AucTime,@AucDuration,@SellerId )
END


GO
/****** Object:  StoredProcedure [dbo].[sp_InsertBidTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertBidTable]
	-- Add the parameters for the stored procedure here
	@BidID int,
	@SellerID int,
	@BuyerID int,
	@ItemID int,
	@BidPrice money
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	insert into BidTable(SellerID,BuyerID,ItemID,BidPrice)values
	(@SellerID,@BuyerID,@ItemID,@BidPrice)
	
END


GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCategory]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertCategory] 
	-- Add the parameters for the stored procedure here
	@CategoryID int,
	@CategoryName varchar(20)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Category(CategoryID,CategoryName)values
	(@CategoryID ,@CategoryName )
END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertItemTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_InsertItemTable]  
@ItemID int,  
@ItemName varchar(50),  
@SubCategoryID int,  
@ItemDescription varchar(500),
@SellerID int,
@BuyerID int,
@Price money,
@AuctionID int,
@BidID int,
@ItemImage image,
@Duration datetime,
@StartDate datetime
  
AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into ItemTable(ItemID,ItemName,SubCategoryID,ItemDescription,SellerID,BuyerID,Price,AuctionID,BidID,ItemImage,Duration,StartDate)   
           Values (@ItemID,@ItemName,@SubCategoryID,@ItemDescription,@SellerID,@BuyerID,@Price,@AuctionID,@BidID,@ItemImage,@Duration,@StartDate)
		   END  

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertSubCategoryTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[sp_InsertSubCategoryTable] 
@SubCategoryID int,  
@CategoryID int,  
@SubCategoryName varchar(50)

AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into SubCategoryTable (SubCategoryID,CategoryID,SubCategoryName)   
           Values (@SubCategoryID,@CategoryID,@SubCategoryName)  
  
END  


GO
/****** Object:  StoredProcedure [dbo].[sp_InsertTransactionTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[sp_InsertTransactionTable] 
@TransId int,  
@SellerAccount numeric(18,0),  
@BuyerAccount numeric (18,0),
@Amount money,
@TransTime time(7),
@TransDate time(7),
@ItemID int

AS  
BEGIN  
    -- SET NOCOUNT ON added to prevent extra result sets from  
    -- interfering with SELECT statements.  
    SET NOCOUNT ON;  
  
    Insert into TransactionTable (TransId,SellerAccount,BuyerAccount,Amount,TransTime,TransDate,ItemID)   
           Values (@TransId,@SellerAccount,@BuyerAccount,@Amount,@TransTime,@TransDate,@ItemID)  
  
END  

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertUsers]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertUsers]  
	-- Add the parameters for the stored procedure here

	@UserFName varchar(50),
	@UserLName varchar(50),
	@DOB datetime,
	@Email varchar(50),
	@Password varchar(50),
	@Phone numeric(10, 0),
	@Address varchar(100),
	@City varchar(50),
	@Country varchar(50),
	@Zip numeric(10, 0),
	@AadharNumber varchar(50),
	@PassportNumber varchar(50)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	insert into Users(UserFName,UserLName,DOB,Email,Password,Phone,Address,City,Country,Zip,AadharNumber,PassportNumber)values
	(@UserFName,@UserLName,@DOB,@Email,@Password,@Phone,@Address,@City,@Country,@Zip,@AadharNumber,@PassportNumber)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ShowAccountDetails]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_ShowAccountDetails]
as
begin
select * from AccountTable
end

GO
/****** Object:  StoredProcedure [dbo].[sp_ShowAuctionDetails]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_ShowAuctionDetails]
as
begin
select * from AuctionTable
end

GO
/****** Object:  StoredProcedure [dbo].[sp_ShowBidDetails]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_ShowBidDetails]
as
begin
select * from BidTable
end


GO
/****** Object:  StoredProcedure [dbo].[sp_ShowCategoryDetails]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_ShowCategoryDetails]
as
begin
select * from	CategoryTable
end


GO
/****** Object:  StoredProcedure [dbo].[sp_ShowItemDetails]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_ShowItemDetails]
as
begin
select * from ItemTable
end

GO
/****** Object:  StoredProcedure [dbo].[sp_ShowSubCategoryDetails]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[sp_ShowSubCategoryDetails]
as
begin
select * from SubCategoryTable
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ShowTransactionDetails]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_ShowTransactionDetails]
as
begin
select * from TransactionTable
end




GO
/****** Object:  StoredProcedure [dbo].[sp_ShowUserDetails]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_ShowUserDetails]
as
begin
select UserID,UserFName,UserLName,DOB,Email,Password,Phone ,Address ,City ,Country,Zip,Date_created 
from Users
end




GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateAccountTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_UpdateAccountTable]
@AccountNo numeric(18,0),@UserID int,@Balance money,@Bank varchar(50),@BankAcctNo numeric(18,0)
as
update AccountTable
set 
UserID=@UserID,
Balance=@Balance,
Bank=@Bank,
BankAcctNo=@BankAcctNo
where AccountNo=@AccountNo

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateAuctionTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateAuctionTable]
	-- Add the parameters for the stored procedure here
	@AuctionID int,
	@AucDate date,
	@AucTime time(7),
	@AucDuration decimal(18,0),
	@SellerId int
AS update AuctionTable
set 
AucDate=@AucDate ,
AucTime=@AucTime,
AucDuration=@AucDuration,
SellerId =@SellerId 

where AuctionID = @AuctionID
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
END


GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateBidTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateBidTable]
	-- Add the parameters for the stored procedure here
	@BidID int,
	@SellerID int,
	@BuyerID int,
	@ItemID int,
	@BidPrice money
AS
update BidTable
set
SellerID=@SellerID,
BuyerID=@BuyerID,
ItemID=@ItemID,
BidPrice =@BidPrice 
where BidID= @BidID 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
END


GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCategory]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateCategory]
	-- Add the parameters for the stored procedure here
		@CategoryID int,
	    @CategoryName varchar(20)
AS update Category
set 
CategoryID=@CategoryID,
CategoryName=@CategoryName

where CategoryID=@CategoryID
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateItemTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_UpdateItemTable]
@ItemID int,@ItemName varchar(50),@SubCategoryID int,@ItemDescription varchar(500),@SellerID int,@BuyerID int,@Price money,
@AuctionID int,@BidID int,@ItemImage image,@Duration datetime,@StartDate datetime
as
BEGIN
SET nocount on;
update ItemTable
set
ItemName=@ItemName,
SubCategoryID=@SubCategoryID,
ItemDescription=@ItemDescription,
SellerID=@SellerID,
BuyerID=@BuyerID,
Price=@Price,
AuctionID=@AuctionID,
BidID=@BidID,
ItemImage=@ItemImage,
Duration=@Duration,
StartDate=@StartDate
where ItemID=@ItemID
end

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateSubCategoryTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_UpdateSubCategoryTable]
@SubCategoryID int,@CategoryID int,@SubCategoryName varchar(50)
as
update SubCategoryTable
set 
CategoryID=@CategoryID,
SubCategoryName=@SubCategoryName
where 
SubCategoryID=@SubCategoryID


GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateTransactionTable]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[sp_UpdateTransactionTable]
@TransId int,@SellerAccount numeric(18,0),@BuyerAccount numeric(18,0),@Amount money,@TransTime time(7),@TransDate time(7),@ItemID int
as
update TransactionTable
set
SellerAccount=@SellerAccount,
BuyerAccount=@BuyerAccount,
Amount=@Amount,
TransTime=@TransTime,
TransDate=@TransDate,
ItemID=@ItemID
where 
TransId=@TransId


GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateUsers]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateUsers] 
	-- Add the parameters for the stored procedure here
	@UserID int,
	@UserFName varchar(50),
	@UserLName varchar(50),
	@DOB datetime,
	@Email varchar(50),
	@Password varchar(50),
	@Phone numeric(10, 0),
	@Address varchar(100),
	@City varchar(50),
	@Country varchar(50),
	@Zip numeric(10, 0),
	@Date_created datetime
AS update Users
set 
  
	UserFName=@UserFName, 
	UserLName=@UserLName,
	DOB=@DOB,
	Email=@Email,
	Password=@Password, 
	Phone=@Phone, 
	Address=@Address, 
	City=@City,
	Country=@Country, 
	Zip=@Zip, 
	Date_created=@Date_created 

	where  UserID=@UserID
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ValidateUser]    Script Date: 7/31/2019 9:30:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_ValidateUser]
	-- Add the parameters for the stored procedure here
	@Email varchar(50),
	@Password varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	SELECT UserID FROM Users WHERE Email = @Email
	AND Password = @Password
 --   BEGIN
	
 --       SELECT 1  --Customer email exists already
 --   END
	--ELSE
	--BEGIN
	--SELECT 0
 --   END
	
    -- Insert statements for procedure here
	
END
GO
USE [master]
GO
ALTER DATABASE [Online_Auction] SET  READ_WRITE 
GO
