USE student_maintenance
GO

CREATE PROC StudentNum_Click
	@Student_Number INT
AS

BEGIN
	SELECT
			p.Last_Name, 
			p.Given_Name, 
			p.Middle_Name, 
			s.Student_Number, 
			pr.Program_Description, 
			s.Year,
			p.Person_ID
		FROM 
			Person p
			INNER JOIN Student s ON p.Person_ID = s.Person_ID
			INNER JOIN Program pr ON s.Program_ID = pr.Program_ID
		WHERE s.Student_Number = @Student_Number
END