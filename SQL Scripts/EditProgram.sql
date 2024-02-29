USE student_maintenance
GO

CREATE PROC EditProgram
	@Program_ID INT,
	@Program_Description varchar(200)
AS
BEGIN
	UPDATE Program
	SET Program_Description = @Program_Description
	WHERE Program_ID = @Program_ID;
END