USE student_maintenance
GO

CREATE PROC AddPerson
	@Last_Name varchar(100),
	@Given_Name varchar(100),
	@Middle_Name varchar(100)
AS
BEGIN
	INSERT INTO Person(Last_Name, Given_Name, Middle_Name)
	VALUES(@Last_Name, @Given_Name, @Middle_Name)
END