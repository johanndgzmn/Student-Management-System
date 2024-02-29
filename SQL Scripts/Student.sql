CREATE TABLE Student (
    Student_ID INT PRIMARY KEY,
    Student_Number VARCHAR(10) CHECK (LEN(Student_Number) = 10),
    Year INT CHECK (Year BETWEEN 1 AND 5),
    Person_ID INT,
    Program_ID INT,
    FOREIGN KEY (Person_ID) REFERENCES Person(Person_ID),
	FOREIGN KEY (Program_ID) REFERENCES Program(Program_ID)
);