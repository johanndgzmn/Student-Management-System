USE student_maintenance
GO

CREATE PROC AddProgram
	@Program_Description varchar(200)
AS
BEGIN
	INSERT INTO Program(Program_Description)
	VALUES(@Program_Description)
END