USE student_maintenance
GO

CREATE PROC DeleteStudent
	@Student_ID INT
AS
BEGIN
	UPDATE Student
	SET Student_Number = NULL, Year = NULL, Person_ID = NULL, Program_ID = NULL
	WHERE Student_ID = @Student_ID;
END