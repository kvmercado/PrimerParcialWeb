CREATE DATABASE [Estampilla];

USE [Estampilla]

CREATE TABLE [dbo].[Estampilla](
[NContrato] [nvarchar](10) NOT NULL PRIMARY KEY,
[ObjContrato] [nvarchar](20) NULL,
[VContrato] [numeric](20, 0) NULL,
[ApoyaCovid19] [nvarchar](2) NULL,
[VEstampilla] [numeric](28, 0) NULL,
) 
GO

COMMIT