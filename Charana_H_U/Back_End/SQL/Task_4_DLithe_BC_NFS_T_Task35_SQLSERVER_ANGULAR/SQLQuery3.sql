create database insurence;

use insurence;

create table UserRegistration
(
id int primary key identity,
Name varchar(25),
Email varchar(25),
PhoneNumber varchar(25),
Password varchar(25),
ConfirmPassword varchar(25)
);

insert into UserRegistration values('Charan','charan@gmail.com','9480808080','charanhu10','charanhu10');

select * from UserRegistration;

