CREATE DATABASE LitrevresourceDB
go
USE LitrevresourceDB
go
CREATE table Resource_table
(
    Res_IdNum int identity (1000,1) primary key,
    Res_WebLink varchar (150) not null,
    Res_Type varchar (50) not null,
    Res_DoiNum varchar (50),
    Res_DateAccessed Date not null,
    Res_Category varchar (50) not null,
    Res_Reference varchar (100),
    Res_MainPoint varchar (2000) not null,
    Res_Notes varchar (3000) not null

);
go
INSERT into Resource_table values('weblink1','book','j/12345','2021/12/12','tftp','www.example1.com','main point1','some notes1');
INSERT into Resource_table values('weblink2','journal','h/12345','2021/10/10','misc','www.example2.com','main point2','some notes2');
INSERT into Resource_table values('weblink3','webpage','l/12345','2021/11/11','routing','www.example3.com','main point3','some notes3');

select * from Resource_table;