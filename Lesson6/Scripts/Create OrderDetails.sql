USE [Lesson6]
GO

/****** Object:  Table [dbo].[OrderDetails]    Script Date: 27.02.2023 14:59:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[OrderDetails](
	[OrderId] [uniqueidentifier] NOT NULL,
	[ShopItemId] [uniqueidentifier] NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Amount] [float] NOT NULL,
	[Sum] [decimal](18, 0) NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Orders] ([Id])
GO

ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders]
GO

ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_ShopItemId] FOREIGN KEY([ShopItemId])
REFERENCES [dbo].[ShopItems] ([Id])
GO

ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_ShopItemId]
GO