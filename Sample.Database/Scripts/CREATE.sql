USE master;
GO

IF EXISTS(SELECT 1 FROM sys.databases WHERE Name = 'Samples')
BEGIN
	DROP DATABASE Samples
END;
GO

CREATE DATABASE Samples;
GO

USE Samples;
GO

CREATE TABLE Matrix
(
	Id INT NOT NULL IDENTITY,
	Name NVARCHAR(100) NOT NULL,
	Percents_id INT NOT NULL,
	Eg FLOAT,
	hw FLOAT,
	Symmetry NVARCHAR(100),
	Comment NTEXT,
	[Disabled] BIT NOT NULL

	CONSTRAINT Matrix PRIMARY KEY (Id)
);
GO

CREATE TABLE Percentege
(
	Id INT NOT NULL,
	Number INT NOT NULL,
	Element_id INT NOT NULL,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_tblWorker_Id PRIMARY KEY (Id),
);
GO

CREATE TABLE Dopant
(
	Id INT NOT NULL,
	Name NVARCHAR(100) NOT NULL,
	Element_id INT NOT NULL,
	Percents_id INT NOT NULL,
	Valense NVARCHAR(100) NOT NULL,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_tblWorker_Id PRIMARY KEY (Id),
);
GO

CREATE TABLE Compaund_To
(
	Id INT NOT NULL,
	Percents_id INT NOT NULL,
	Compaund_id INT NOT NULL,
	Valense NVARCHAR(100) NOT NULL,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_tblWorker_Id PRIMARY KEY (Id),
);
GO

CREATE TABLE Compound
(
	Id INT NOT NULL IDENTITY,
	User_id INT NOT NULL,
	Visibility INT NOT NULL,
	Eg FLOAT,
	hw FLOAT,
	Symmetry NVARCHAR(100),
	Comment NTEXT,
	[Disabled] BIT NOT NULL

	CONSTRAINT Matrix PRIMARY KEY (Id)
);
GO

CREATE TABLE Users
(
	Id INT NOT NULL IDENTITY,
	Name NVARCHAR(100) NOT NULL,
	Password NVARCHAR(100) NOT NULL,
	Departament NVARCHAR(100),
	[Disabled] BIT NOT NULL

	CONSTRAINT Matrix PRIMARY KEY (Id)
);
GO

CREATE TABLE SpectralLine
(
	Id INT NOT NULL IDENTITY,
	Spectral_id int NOT NULL,
	Wavelength float NOT NULL,
	Width NVARCHAR(100),
	RelInt float,
	Transition NVARCHAR(100),
	Comment NVARCHAR(100),
	OriginOfLine INT,
	[Disabled] BIT NOT NULL

	CONSTRAINT Matrix PRIMARY KEY (Id)
);
GO

CREATE TABLE Spectrum
(
	Id INT NOT NULL IDENTITY,
	Compound_id int NOT NULL,
	SpectrumType int NOT NULL,
	[Disabled] BIT NOT NULL

	CONSTRAINT Matrix PRIMARY KEY (Id)
);
GO