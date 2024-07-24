declare @code int ;
declare @answer varchar(25) = 'Updated successfully';
if EXISTS (select Code from Employe	where @id = Employe.id_number)
	BEGIN
		if EXISTS (select PasswordEmploye from Passwords where PasswordEmploye = @Oldpassword)
				BEGIN
					 if ( @password = @configPassword )
						 BEGIN									
								select @code = (select Code from Employe
								where @id = Employe.id_number)

								if EXISTS (select OldPassword from OldPasswords where userPassword = @code and OldPassword = @password)
									BEGIN
										select @answer = 'Choose a differents password'
									END
								else
									BEGIN
										UPDATE Passwords
										SET PasswordEmploye = @password
										WHERE userEmploye = @code 	
										insert into OldPasswords values (@code ,@password)
									END								
						  END						
					 else
						BEGIN	
							select @answer = 'Non-similar fields'
						END						 			
				END					
		else
			BEGIN
				select @answer = 'Incorrect statistic'
			END
	END
else 
	BEGIN
		select @answer = 'Non-existent employee'
	END
select @answer
