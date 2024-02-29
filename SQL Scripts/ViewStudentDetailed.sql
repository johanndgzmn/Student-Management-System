USE student_maintenance
GO

CREATE PROC ViewStudentDetailed
AS
BEGIN
    SELECT 
        p.Last_Name, 
        p.Given_Name, 
        p.Middle_Name, 
        s.Student_Number, 
        pr.Program_Description, 
        s.Year
    FROM 
        Person p
        INNER JOIN Student s ON p.Person_ID = s.Person_ID
        INNER JOIN Program pr ON s.Program_ID = pr.Program_ID
END