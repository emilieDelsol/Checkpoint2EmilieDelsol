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
	StudentLastName VARCHAR(90) NOT NULL,
	StudentFirstName VARCHAR(90) NOT NULL,
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
INSERT INTO Student (StudentFirstName,StudentLastName, FK_PromotionId)
	VALUES ('Emilie', 'Delsol',1),('Maïlys','Dumas',1),('Colas','Durcy',1),('Hervé','Meste',1),('Adrien','Zapico',1),
			('Emilie', 'Anglade',2),('Rooarii','Manuel',2),('Lisa-Lou', 'Kara',2),('Jessica','Giraud',2),('Flavien','Besseau',2)