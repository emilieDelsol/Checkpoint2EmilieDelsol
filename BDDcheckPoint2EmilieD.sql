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

INSERT INTO Controle (CotroleNote,FK_StudentId)
	VALUES (20,1),(15,1),(16,1),(17,1),(12,1),(15,1),(18,1),
			(20,2),(15,2),(16,2),(17,2),(12,2),(15,2),(18,2),
			(20,3),(15,3),(16,3),(7,3),(12,3),(15,3),(18,3),
			(20,4),(15,4),(16,4),(17,4),(12,4),(15,4),(18,4),
			(20,5),(15,5),(16,5),(17,5),(12,5),(15,5),(18,5),
			(20,6),(15,6),(6,6),(17,6),(12,6),(15,6),(18,6),
			(20,7),(15,7),(16,7),(1,7),(12,7),(15,7),(18,7),
			(15,8),(15,8),(16,8),(15,8),(12,8),(15,8),(18,8),
			(20,9),(15,9),(16,9),(17,9),(10,9),(15,9),(18,9),
			(20,10),(15,10),(16,10),(13,10),(12,10),(15,10),(18,10)



SELECT  Student.StudentLastName AS "Nom" , Student.StudentFirstName AS "Prénom", AVG(Controle.CotroleNote) AS "moyenne de l'étudiant: "
	from Controle INNER JOIN Student  ON StudentId=FK_StudentId
		GROUP BY StudentId,StudentLastName, StudentFirstName

