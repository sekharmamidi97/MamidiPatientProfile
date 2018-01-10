Create Table NewRegisteredUsers
(
  registeredUserId int identity(1,1) not null primary key,
  firstName varchar(50) not null,
  lastName varchar(50) not null,
  emailAddress varchar(50) not null,
  password varchar(50) not null,
  salt varchar(100) not null
);