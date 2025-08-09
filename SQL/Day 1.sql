-- Idempotent Day 1 setup
IF DB_ID('Day1DB') IS NULL
BEGIN
    CREATE DATABASE Day1DB;
END
GO

USE Day1DB;
GO

IF OBJECT_ID('dbo.Students', 'U') IS NULL
BEGIN
    CREATE TABLE dbo.Students (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(100) NOT NULL,
        Age INT NULL,
        Marks INT NULL
    );
END
GO

-- Seed data (checks to avoid duplicates)
IF NOT EXISTS (SELECT 1 FROM dbo.Students WHERE Name = 'Alice')
    INSERT INTO dbo.Students (Name, Age) VALUES ('Alice', 22);

IF NOT EXISTS (SELECT 1 FROM dbo.Students WHERE Name = 'Bob')
    INSERT INTO dbo.Students (Name, Age) VALUES ('Bob', 25);

IF NOT EXISTS (SELECT 1 FROM dbo.Students WHERE Name = 'John')
    INSERT INTO dbo.Students (Name, Age, Marks) VALUES ('John', 24, 88);

SELECT * FROM dbo.Students;
