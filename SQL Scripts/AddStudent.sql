USE student_maintenance
GO

CREATE PROC AddStudent
	@Student_Number varchar(10),
	@Year INT,
	@Program_ID varchar(200)
AS
IF EXISTS (SELECT 1 FROM Person WHERE Person_ID = '1')
BEGIN
	INSERT INTO Student(Student_Number, Year, Program_ID)
	VALUES(@Student_Number, @Year, @Program_ID)
	UPDATE Student
	SET Person_ID = Student_ID
END
ELSE
BEGIN
    PRINT 'Person table does not have any values. Cannot add student.'
END