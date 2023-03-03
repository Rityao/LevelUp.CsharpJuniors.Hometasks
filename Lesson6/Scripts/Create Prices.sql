USE [Lesson6]
GO

/****** Object:  Table [dbo].[Prices]    Script Date: 27.02.2023 14:28:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prices](
	[ShopItemId] [uniqueidentifier] NOT NULL,
	[DateTime] [datetime2](7) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Prices]  WITH CHECK ADD  CONSTRAINT [FK_Prices_ShopItems] FOREIGN KEY([ShopItemId])
REFERENCES [dbo].[ShopItems] ([Id])
GO

ALTER TABLE [dbo].[Prices] CHECK CONSTRAINT [FK_Prices_ShopItems]
GO