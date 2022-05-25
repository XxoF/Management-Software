use master
go

CREATE DATABASE [Final_Application]
 ON  PRIMARY 
( NAME = N'[Final_Application]', FILENAME = N'D:\Selfstudy\Software Enginnering\TDTU\final\Management-Software\database\Final_Application.mdf')



use [Final_Application]
go

CREATE TABLE [dbo].[tblUsers](
	[UserID] [nchar](20) NOT NULL PRIMARY KEY,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nchar](20) NOT NULL,
	[Active] [bit] NOT NULL DEFAULT 1,
)
GO

