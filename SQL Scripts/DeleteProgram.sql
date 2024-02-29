USE student_maintenance
GO

CREATE PROC DeleteProgram
	@Program_ID INT
AS
BEGIN
	UPDATE Program
	SET Program_Description = NULL
	WHERE Program_ID = @Program_ID;
END