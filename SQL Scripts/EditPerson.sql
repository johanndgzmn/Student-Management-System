USE student_maintenance
GO

CREATE PROC EditPerson
	@Person_ID INT,
	@Last_Name varchar(100),
	@Given_Name varchar(100),
	@Middle_Name varchar(100)
AS
BEGIN
	UPDATE Person
	SET Last_Name = @Last_Name, Given_Name = @Given_Name, Middle_Name = @Middle_name
	WHERE Person_ID = @Person_ID;
END