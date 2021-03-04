create database RealtyAgency
go

use RealtyAgency
go

create table UserRoles
(
RoleID int primary key identity,
RoleName varchar(25) not null
)
go

insert into UserRoles(RoleName) 
values	('Клиент'),
		('Риелтор'),
		('Администратор')
go

create table Users
(
UserID int primary key identity,
UserLogin varchar(25) not null unique,
UserPassword varchar(25) not null,
UserRole int foreign key references UserRoles(RoleID) 
on update cascade
on delete cascade not null
)
go

insert into Users(UserLogin, UserPassword, UserRole)
values	('login','password','2'),
		('login1','password1','2'),
		('login2','password2','2'),
		('login3','password3','2'),
		('login4','password4','2'),
		('login5','password5','2'),
		('login6','password6','2'),
		('login7','password7','2'),
		('login8','password8','2'),
		('login9','password9','2'),
		('login10','password10','2')
go

insert into Users(UserLogin, UserPassword, UserRole)
values	('client','passoword12','1'),
		('client1','passoword13','1'),
		('client2','passoword14','1'),
		('client3','passoword15','1'),
		('client4','passoword16','1'),
		('client5','passoword17','1'),
		('client6','passoword18','1'),
		('client7','passoword19','1'),
		('client8','passoword20','1'),
		('client9','passoword21','1'),
		('client10','passoword22','1'),
		('client11','passoword23','1'),
		('client12','passoword24','1'),
		('client13','passoword25','1'),
		('client14','passoword26','1'),
		('client15','passoword27','1'),
		('client16','passoword28','1'),
		('client17','passoword29','1'),
		('client18','passoword30','1'),
		('client19','passoword31','1'),
		('client20','passoword32','1'),
		('client21','passoword33','1'),
		('client22','passoword34','1'),
		('client23','passoword35','1'),
		('client24','passoword36','1'),
		('client25','passoword37','1')
go

create table Rieltors
(
RieltorID int primary key identity,
FirstName varchar(25) not null,
MiddleName varchar(25) not null,
LastName varchar(25) not null,
DealShare float not null,
AuthData int foreign key references Users(UserID)
on update cascade
on delete cascade not null
)
go

create table Clients
(
ClientID int primary key identity,
FirstName varchar(25) not null,
MiddleName varchar(25) not null,
LastName varchar(25) not null,
Phone varchar(16) not null,
Email varchar(100) not null,
AuthData int foreign key references Users(UserID)
on update cascade
on delete cascade not null
)
go

create view GetAuthData
(UserLogin, UserPassword, UserRole)
as
select Users.UserLogin, Users.UserPassword, UserRoles.RoleName
from Users inner join UserRoles on Users.UserRole = UserRoles.RoleID
go

create procedure GetAuthorizedUserData
@userlogin varchar(25) 
as
	begin
		select Clients.FirstName, Clients.MiddleName
		from Clients inner join Users on Users.UserID = Clients.AuthData
		where Users.UserLogin = @userlogin
	end
go

execute GetAuthorizedUserData 'client'
go


create procedure CreateNewClient
@surname varchar(25), @name varchar(25), @lastName varchar(25), @email varchar(100), @phone varchar(16), @authData int
as
	begin
		insert into Clients(FirstName, MiddleName, LastName, Email, Phone, AuthData)
		values	(@surname, @name, @lastName, @email, @phone, @authData)
	end
go

create procedure CreateNewUser
@login varchar(25), @password varchar(25), @secretKey varchar(10)
as
	if exists (select UserLogin from Users where UserLogin = @login)
		begin
			rollback transaction
			raiserror('Пользователь с таким логином уже существует!',0,1)
		end
	else
		begin
			insert into Users(UserLogin, UserPassword, UserRole, SecretKey)
			values(@login, @password, '1', @secretKey)
		end
go


create view GetLastUserID
(ID)
as
select max(UserID) from Users
go

select * from GetLastUserID