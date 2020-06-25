CREATE TABLE Library_Member_Login 
(
	login_ID int not null primary key,
    LM_username varchar(25) NOT NULL unique,
    LM_password varchar(25) NOT NULL unique
);
CREATE TABLE LM_student 
(
    enrollement int NOT NULL primary key,
    full_name varchar(25) NOT NULL ,
	department  varchar(25) NOT NULL,
	login_ID int NOT NULL FOREIGN KEY REFERENCES Library_Member_Login(login_ID)
);
CREATE TABLE LM_staff 
(
    staff_no int NOT NULL primary key,
    full_name varchar(25) NOT NULL ,
	designation  varchar(25) NOT NULL,
	login_ID int NOT NULL FOREIGN KEY REFERENCES Library_Member_Login(login_ID)
);

select * from Library_Member_Login
select * from LM_student
select * from LM_staff

