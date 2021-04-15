CREATE OR ALTER PROCEDURE User_Login
@Credential varchar(60),
@Password_1 varchar(60)
As
BEGIN
TRY
	BEGIN
		SET NOCOUNT ON
		DECLARE @StudentId integer;
		DECLARE @Pass integer;
		DECLARE @ErrorMessage varchar(40), @ErrorSeverity integer, @ErrorState varchar(40);

		SELECT TOP(1) @StudentId = StudentId, @Pass = Login_password FROM Login_Credential
		WHERE Mobile = @Credential OR Email = @Credential;
	
		IF @Pass = @Password_1 
		BEGIN
			SELECT * From Student Where StudentId = @StudentId;
		END
		Else
		Begin
			RAISERROR('Error while login', 16, 1);
		End;
	END;
CATCH 
BEGIN
	    @ErrorMessage = ERROR_MESSAGE(), 
        @ErrorSeverity = ERROR_SEVERITY(), 
        @ErrorState = ERROR_STATE();

		-- return the error inside the CATCH block
		RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
END
END
Go