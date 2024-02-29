USE student_maintenance
GO

CREATE PROC DeletePerson
	@Person_ID INT
AS
BEGIN
	UPDATE Person
	Set Last_Name = NULL, Given_Name = NULL, Middle_Name = NULL
	WHERE Person_ID = @Person_ID;
END