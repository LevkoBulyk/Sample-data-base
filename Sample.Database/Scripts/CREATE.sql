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
	Eg FLOAT,
	hw FLOAT,
	Symmetry NVARCHAR(100),
	Comment NTEXT,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_Matrix_Id PRIMARY KEY (Id),
	
);
GO

CREATE TABLE Percentege
(
	Id INT NOT NULL,
	Number INT NOT NULL,
	Element_id INT NOT NULL,
	[Disabled] BIT NOT NULL,
	Matrix_id INT NOT NULL,
	Dopant_id INT NOT NULL
	CONSTRAINT  PK_Percentege_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Percentege_MatrixID FOREIGN KEY(Matrix_id) REFERENCES Matrix(Id),
	CONSTRAINT FK_Percentege_DopantID FOREIGN KEY(Dopant_id) REFERENCES Dopant(Id)
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

	CONSTRAINT PK_Dopant_Id PRIMARY KEY (Id),
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
	CONSTRAINT FK_CompaundTo_PercentegeID FOREIGN KEY(Percents_id) REFERENCES Percentege(Id),
	CONSTRAINT FK_CompaundTo_CompoundID FOREIGN KEY(Compaund_id) REFERENCES Compound(Id)
);
GO

CREATE TABLE Compound
(
	Id INT NOT NULL,
	User_id INT NOT NULL,
	Visibility INT NOT NULL,
	Eg FLOAT,
	hw FLOAT,
	Symmetry NVARCHAR(100),
	Comment NTEXT,
	[Disabled] BIT NOT NULL

	CONSTRAINT Compound PRIMARY KEY (Id)
	CONSTRAINT FK_Compound_UsersID FOREIGN KEY(User_id) REFERENCES Users(Id),
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

	CONSTRAINT Matrix PRIMARY KEY (Id),
	CONSTRAINT FK_SpectralLine_CompountID FOREIGN KEY(OriginOfLine) REFERENCES Dopant(Id),

);
GO

CREATE TABLE Spectrum
(
	Id INT NOT NULL IDENTITY,
	Compound_id int NOT NULL,
	SpectrumType int NOT NULL,
	[Disabled] BIT NOT NULL

	CONSTRAINT Matrix PRIMARY KEY (Id),
	CONSTRAINT FK_Spectrum_CompountID FOREIGN KEY(Compound_id) REFERENCES SpectralLine(Id)
);
GO