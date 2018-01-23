create table tblLogin(
	username varchar(25),
	pass varchar(25) 
);

go
create procedure sp_PushAccout
	@user varchar(25),
	@pass varchar(25)
as
	insert into tblLogin values(@user,@pass);

go
create procedure sp_getData
as
	select * from tblLogin;

go
create procedure sp_delData
@username varchar(25)
as
	delete from tblLogin where username = @username;

exec sp_delData @username = 'add';

go
create procedure sp_editData
@oldUser varchar(25),
@newUser varchar(25),
@password varchar(25)
as
	update tblLogin set username = @newUser, pass = @password where username = @oldUser; 

go
create procedure sp_getUser
@username varchar(25)
as
	select * from tblLogin where username = @username;

