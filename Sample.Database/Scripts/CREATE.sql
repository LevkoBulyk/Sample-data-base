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

CREATE TABLE Dopant
(
	Id INT NOT NULL IDENTITY,
	Name NVARCHAR(100) NOT NULL,
	Valense NVARCHAR(100) NOT NULL,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_Dopant_Id PRIMARY KEY (Id),
);
GO

CREATE TABLE Percentage
(
	Id INT NOT NULL IDENTITY,
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

CREATE TABLE Users
(
	Id INT NOT NULL IDENTITY,
	Name NVARCHAR(100) NOT NULL,
	Password NVARCHAR(100) NOT NULL,
	Departament NVARCHAR(100),
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_Users_Id PRIMARY KEY (Id)
);
GO


CREATE TABLE Compound
(
	Id INT NOT NULL IDENTITY,
	Visibility INT NOT NULL,
	Eg FLOAT,
	hw FLOAT,
	Symmetry NVARCHAR(100),
	Comment NTEXT,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_Compound_Id PRIMARY KEY (Id)
);
GO

CREATE TABLE PercentToCompound
(
	Id INT NOT NULL IDENTITY,
	Percents_id INT NOT NULL,
	Compaund_id INT NOT NULL,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_tblWorker_Id PRIMARY KEY (Id),
	CONSTRAINT FK_CompaundTo_PercentegeID FOREIGN KEY(Percents_id) REFERENCES Percentage(Id),
	CONSTRAINT FK_CompaundTo_CompoundID FOREIGN KEY(Compaund_id) REFERENCES Compound(Id)
);
GO

CREATE TABLE Spectrum
(
	Id INT NOT NULL IDENTITY,
	Compound_id int NOT NULL,
	SpectrumType int NOT NULL,
	SourceLink NTEXT,
	User_id INT NOT NULL,
	Visibility INT,
	Temperature float,
	Preasure float,
	Wavelength float,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_Spectrum_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Spectrum_CompountID FOREIGN KEY(Compound_id) REFERENCES Compound(Id),
	CONSTRAINT FK_Spectrum_UsersID FOREIGN KEY(User_id) REFERENCES Users(Id)
);
GO

CREATE TABLE SpectralLine
(
	Id INT NOT NULL IDENTITY,
	Spectrum_id int NOT NULL,
	Wavelength float NOT NULL,
	Width float,
	RelativeIntensity float,
	Transition NVARCHAR(100),
	Comment NVARCHAR(100),
	OriginOfLine INT,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_SpectralLine_Id PRIMARY KEY (Id),
	CONSTRAINT FK_SpectralLine_CompountID FOREIGN KEY(OriginOfLine) REFERENCES Dopant(Id),
	CONSTRAINT FK_SpectralLine_SpectrumID FOREIGN KEY(Spectrum_id) REFERENCES Spectrum(Id),
);
GO

CREATE TABLE Decay
(
	Id INT NOT NULL IDENTITY,
	SpectralLine_id int NOT NULL,
	Time float NOT NULL,
	ExtWavelength float NOT NULL,
	LumWavelength float NOT NULL,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_Decay_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Decay_SpectralLineID FOREIGN KEY(SpectralLine_id) REFERENCES SpectralLine(Id)
);
GO

CREATE TABLE SpectrumImg
(
	Id INT NOT NULL IDENTITY,
	Spectrum_id int NOT NULL,
	Img float NOT NULL,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_SpectrumImg_Id PRIMARY KEY (Id),
	CONSTRAINT FK_SpectrumImg_SpectrumID FOREIGN KEY(Spectrum_id) REFERENCES Spectrum(Id)
);
GO

CREATE TABLE SpectrumData
(
	Id INT NOT NULL IDENTITY,
	Spectrum_id int NOT NULL,
	Data float NOT NULL,
	[Disabled] BIT NOT NULL

	CONSTRAINT PK_SpectrumData_Id PRIMARY KEY (Id),
	CONSTRAINT FK_SpectrumData_SpectrumID FOREIGN KEY(Spectrum_id) REFERENCES Spectrum(Id)
);
GO