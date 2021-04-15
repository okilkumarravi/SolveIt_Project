CREATE DATABASE SolveItDB;
Drop TABLE IF EXISTS Login_Credential;
Drop TABLE IF EXISTS Student;
CREATE TABLE Student (
	StudentId integer IDENTITY(1,1) PRIMARY KEY, 
	StudentName varchar(60) NOT NULL,
	Email varchar(60),
	Mobile varchar(20) NOT NULL,
	class varchar(10) NOT NULL,
	IsActive varchar(1) NOT NULL);

CREATE TABLE Login_Credential (Credential_id int IDENTITY(1,1) PRIMARY KEY,
	StudentId integer, 
	Email varchar(60),
	Mobile varchar(2) NOT NULL,
	Login_password varchar(60) NOT NULL,
	Login_Role varchar(1),
	FOREIGN KEY (StudentId) REFERENCES Student(StudentId)
);