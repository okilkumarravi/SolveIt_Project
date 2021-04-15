CREATE OR ALTER PROCEDURE User_SignUp
@Name varchar(40),
@Email varchar(60),
@mobile varchar(20),
@class varchar(2),
@password_1 varchar(60),
@role varchar(1)
As
BEGIN
SET NOCOUNT ON
	DECLARE @StudentId integer;
	INSERT INTO Student(StudentName, Email, Mobile, class, IsActive) 
	VALUES(@Name, @Email, @mobile, @class, N'Y')
	SET @StudentId = @@IDENTITY;

	Insert into Login_Credential(StudentId, email, Mobile, Login_password, Login_Role) 
							VALUES(@StudentId, @Email, @mobile, @password_1, @role);

END;
Go