USE [Lesson6]
GO

/****** Object:  Table [dbo].[Shipments]    Script Date: 27.02.2023 14:59:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Shipments](
	[Id] [uniqueidentifier] NOT NULL,
	[StockId] [uniqueidentifier] NOT NULL,
	[SkuId] [uniqueidentifier] NOT NULL,
	[Amount] [float] NOT NULL,
	[DateTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Shipments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Shipments_SKU] FOREIGN KEY([SkuId])
REFERENCES [dbo].[StockKeepingUnits] ([Id])
GO

ALTER TABLE [dbo].[Shipments] CHECK CONSTRAINT [FK_Shipments_SKU]
GO

ALTER TABLE [dbo].[Shipments]  WITH CHECK ADD  CONSTRAINT [FK_Shipments_Stocks] FOREIGN KEY([StockId])
REFERENCES [dbo].[Stocks] ([Id])
GO

ALTER TABLE [dbo].[Shipments] CHECK CONSTRAINT [FK_Shipments_Stocks]
GO