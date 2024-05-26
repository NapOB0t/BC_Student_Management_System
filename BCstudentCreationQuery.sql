Create DATABASE BCStudentSystem; --Create the database 

GO 

USE BCStudentSystem;

CREATE TABLE BCStudents -- Create the Student Table
(
	StudentNumber INT NOT NULL PRIMARY KEY,
	StudentName VARCHAR(50),
	StudentSurname VARCHAR(50),
	StudentImage varbinary(max),
	DOB DATETIME ,
	PhoneNumber VARCHAR(50),
	HomeAddress VARCHAR(50),
	ModuleCode INT ,

);

GO

USE BCStudentSystem;

CREATE TABLE BCModules -- Creates the module table with all the details of the modules.
(
	ModuleCode INT NOT NULL PRIMARY KEY ,
	ModuleName VARCHAR(100),
	ModuleDescription VARCHAR(300),
	Links VARCHAR(500) 

);

GO

USE BCStudentSystem

CREATE TABLE StudentModule -- Create the studentModule Table that is used to create 
(
	ModuleCode INT FOREIGN KEY REFERENCES BCModules(ModuleCode),
	StudentNumber INT FOREIGN KEY REFERENCES BCStudents (StudentNumber),
	Grade INT 

);
