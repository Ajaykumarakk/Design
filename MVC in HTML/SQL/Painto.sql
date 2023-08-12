create table Painto
(
Id int not null primary key identity(1,1),
Name nvarchar (200) not null,
Email nvarchar (200) not null,
Phonenumber bigint not null,
Massage nvarchar (200) not null
)

Create or Alter Procedure insertinfo(@Name nvarchar (200),@Email nvarchar (200),@Phonenumber bigint,@Massage nvarchar (1000))
as
begin
insert into Painto(Name,Email,Phonenumber,Massage) values(@Name,@Email,@Phonenumber,@Massage)
end

Exec insertinfo 'Ajay','Ajay@123',9126998734,'Hi'

select * from Painto