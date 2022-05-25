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

Insert Into [tblUsers] VALUES('1', 'User Test 1', '1', '1')
Insert Into [tblUsers] VALUES('User1', 'User Test 2', '123456', '1')
Insert Into [tblUsers] VALUES('User2', 'User Test 3', '123456', '1')
Insert Into [tblUsers] VALUES('User3', 'User Test 4', '123456', '1')


CREATE TABLE [dbo].[tblProduct](
	[ID] [nchar](20) NOT NULL PRIMARY KEY,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [decimal](18,2) NOT NULL,
	[Quantity] [decimal](10,0) NOT NULL ,
)
GO

Insert Into [tblProduct] VALUES('1', 'Dep di trong nha', '50000', '100')
Insert Into [tblProduct] VALUES('2', 'Chuot khong day', '69000', '30')
Insert Into [tblProduct] VALUES('3', 'Ao thun nam', '45000', '10')
Insert Into [tblProduct] VALUES('4', 'Day microphone', '10000', '30')
Insert Into [tblProduct] VALUES('5', 'Iphone 13', '13000000', '15')
Insert Into [tblProduct] VALUES('6', 'Lot chuot may tinh', '15000', '200')