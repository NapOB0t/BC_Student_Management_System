USE BCStudentSystem;
GO
CREATE PROCEDURE spUpdateStudent
(
 @studentNum INT , 
 @Name VARCHAR(50),
 @Surname VARCHAR(50),
 @studentImage VARBINARY(MAX),
 @DateOFBirth DateTime ,
 @Phone VARCHAR(50),
 @Address VARCHAR(50),
 @ModuleCode INT,
 @Gender  VARCHAR(50)

)
AS
BEGIN
	UPDATE BCStudents
	SET StudentNumber = @StudentNum , StudentName = @Name ,
		StudentSurname =@Surname , StudentImage = @studentImage , DOB = @DateOFBirth ,
		PhoneNumber = @Phone , HomeAddress = @Address , ModuleCode = @ModuleCode
	WHERE  StudentNumber = @studentNum
END 

GO
------------------------------------------------------------------------------------------------
USE BCStudentSystem
GO
CREATE PROCEDURE spADDStudent
(
 @studentNum INT , 
 @Name VARCHAR(50),
 @Surname VARCHAR(50),
 @studentImage VARBINARY(MAX),
 @DateOFBirth DateTime ,
 @Phone VARCHAR(50),
 @Address VARCHAR(50),
 @ModuleCode INT,
 @Gender  VARCHAR(50)

)

AS

BEGIN

	INSERT INTO BCStudents 
	VALUES (@studentNum , @Name , @Surname, @studentImage ,@DateOFBirth ,@Phone,@Address,@ModuleCode , @Gender)

END

GO

----------------------------------------------------------------------------------------------
USE BCStudentSystem;
GO 
CREATE PROCEDURE spDeleteStudent
(
	@studNum INT


)
AS
BEGIN 
	DELETE From BCStudents WHERE StudentNumber = @studNum

END

GO


------------------------------------------------------------------------------------------------

USE BcStudentSystem;

GO

CREATE PROCEDURE spStudentSearch
(
	@StudNum INT

)
AS
BEGIN
		SELECT*FROM BCStudents WHERE  StudentNumber = @StudNum;
END

GO

------------------------------------------------------------------------------------------------
------------------------------------------------------------------------------------------------
USE BCStudentSystem; 
GO
CREATE PROCEDURE spModuleUpdate --
(
	@mcode INT,
	@mName VARCHAR(100),
	@mDescription VARCHAR(300),
	@Links VARCHAR(500)
)
AS
BEGIN
	UPDATE BCModules 
	SET ModuleCode = @mcode , ModuleName = @mName , ModuleDescription = @mDescription ,
	Links = @Links 
	WHERE ModuleCode = @mcode
END

GO
---------------------------------------------------------------------------------------------
USE BCStudentSystem; 
GO
CREATE PROCEDURE spModuleDelete --
(
	@mcode INT

)
AS
BEGIN
	DELETE  FROM BCStudents WHERE StudentNumber = @mcode
END

GO
--------------------------------------------------------------------------------------------------------------
USE BCStudentSystem; 
GO
CREATE PROCEDURE spModuleADD --
(
	@mcode INT,
	@mName VARCHAR(100),
	@mDescription VARCHAR(300),
	@Links VARCHAR(500)
)
AS
BEGIN
	INSERT INTO BCModules 
	VALUES(  @mcode ,  @mName , 
	@mDescription, @Links )

END

GO 

----------------------------------------------------------------------------------------------------------------
USE BCStudentSystem; 
GO
CREATE PROCEDURE spModuleSearch --
(
	@mcode INT
	
)
AS
BEGIN
	SELECT * FROM BCModules WHERE ModuleCode = @mcode
END
