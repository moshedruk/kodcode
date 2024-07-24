declare @answer varchar(25) = 'Employee successfully registered';
declare @code int ;

IF EXISTS (select * from Employe where id_number = @id_Employe)
	BEGIN
		-- Block of code to execute if the inner query returned a result set
		select @code = (select code from Employe where id_number = @id_Employe);
	END
else 
	BEGIN
		insert into Employe values (@fuul_name,@id_Employe);
		select @code = @@IDENTITY;
		--insert into Passwords values (@code, @password);		
	END

IF EXISTS (select * from Passwords where userEmploye = @code)
	BEGIN
		if EXISTS (select PasswordEmploye from Passwords where PasswordEmploye = @password and StatusEmplyePasswords = 1 and userEmploye = @code)
			BEGIN
				if EXISTS (select PasswordEmploye from Passwords where PasswordEmploye = @password and StatusEmplyePasswords = 1 and userEmploye = @code and Expiration_DatePasswords>=getdate())
					BEGIN					
						if  EXISTS (select *from presence  where userEmploye = @code and exitEmplye is null)
							BEGIN
								UPDATE presence
								SET exitEmplye= GETDATE()
								WHERE userEmploye = @code and exitEmplye is null;
								select @answer = '/exit :' +  convert (nvarchar ,GETDATE(),121)
							END
						else
							BEGIN
								insert into presence values(@code ,getdate(),null)
								select @answer = 'enter_time :' + convert (nvarchar ,GETDATE(),121)
							END
					END
				else 
					BEGIN			
						select @answer ='updete password'--time enter--updete password
					END		
			END
		else
			BEGIN
				select @answer = 'password not valid'--password not valid
			END
	END
else 
	BEGIN 
		insert into Passwords values (@code ,@password ,dateadd (day ,180,getdate()),1)
		insert into OldPasswords values (@code ,@password)
	END
select @answer

