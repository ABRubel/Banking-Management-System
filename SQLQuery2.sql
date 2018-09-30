create database bank
use bank
drop table Customer
CREATE TABLE Customer(
username varchar(50),
pass varchar(50),
email varchar(50),
age int,
balance decimal(9,2),
PRIMARY KEY (email)
);
select * from Customer

exec _update @Name ="Fayez@gmail.com",
	@Amount =500
exec _update @Name ="Rubel@gmail.com",
	@Amount =500
exec _update @Name ="rifat@gmail.com",
	@Amount =500

create proc _Deposit
(
	@Name varchar(50),
	@Amount decimal(9,2)
)
as
UPDATE Customer
SET balance=balance+@Amount
WHERE email=@Name
Return


create  proc SelectCustomer
(
	@Name varchar(50)
)
as
Begin
	return(Select balance from Customer WHERE email=@Name)
End
Go

create proc WithdrawUpdate
(
	@Name varchar(50),
	@Amount decimal(9,2)
)
as
UPDATE Customer
SET balance=balance-@Amount
WHERE email=@Name
Return



select * from Customer
exec _withdraw @Name ="Fayez@gmail.com",
	@Amount =500
exec _withdraw @Name ="Rubel@gmail.com",
	@Amount =5000
exec _withdraw @Name ="rifat@gmail.com",
	@Amount =500


create  proc SelectCustomerForTransfer
(
	@TEmail varchar(50)
)
as
Begin
	return(Select count(*) from Customer WHERE email=@TEmail)
End


create proc _Transfer
(
	@Name varchar(50),
	@TEmail varchar(50),
	@Amount decimal(9,2)
)
as
UPDATE Customer
SET balance=balance-@Amount
WHERE email=@Name;
UPDATE Customer
SET balance=balance+@Amount
WHERE email=@TEmail
Return