USE student_maintenance
GO

CREATE PROC EditStudent
	@Student_ID INT,
	@Student_Number varchar(10),
	@Year INT,
	@Program_ID INT
AS
BEGIN
	UPDATE Student
	SET Student_Number = @Student_Number, Year = @Year, Program_ID = @Program_ID, Person_ID = Student_ID
	WHERE Student_ID = @Student_ID;
END