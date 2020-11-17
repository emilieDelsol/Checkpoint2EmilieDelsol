DROP DATABASE IF EXISTS DataCheckPoint2 
GO

CREATE DATABASE DataCheckPoint2
GO

USE DataCheckPoint2
CREATE TABLE Promotion(
	PromotionId INT PRIMARY KEY IDENTITY(1, 1),
	PromotionName VARCHAR(100) NOT NULL,
)	
GO 

CREATE TABLE Student (
	StudentId INT PRIMARY KEY IDENTITY(1, 1),
	StudentName VARCHAR(90) NOT NULL,
	FK_PromotionId INT FOREIGN KEY REFERENCES [Promotion](PromotionId) NOT NULL
)
GO 

CREATE TABLE Controle(
	ControleId INT PRIMARY KEY IDENTITY(1, 1),
	CotroleNote DECIMAL NOT NULL,
	FK_StudentId INT FOREIGN KEY REFERENCES [Student](StudentId) NOT NULL
)
GO
INSERT INTO Promotion (PromotionName) 
	VALUES ('C#'),('JS')
GO
INSERT INTO Student (StudentName, FK_PromotionId)
	VALUES ('EmilieD',1),('Maïlys',1),('Colas',1),('Hervé',1),('Adrien',1),
			('EmilieA',2),('Rooarii',2),('Lisa-Lou',2),('Jessica',2),('Flavien',2)