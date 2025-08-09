CREATE DATABASE Day1DB;

use Day1DB;

CREATE TABLE Students ( Id INT PRIMARY KEY IDENTITY, Name NVARCHAR(100), Age INT )

INSERT INTO Students (Name, Age) VALUES ('Alice', 22), ('Bob', 25);

SELECT * FROM Students;

