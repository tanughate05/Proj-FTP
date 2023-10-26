use SqlServerDatabase1;

create table materials (ItemCode nvarchar(50) NULL, ItemPrice [float] NULL, NewPrice [float] NULL)
go

select * from  materials

insert into materials(ItemCode, ItemPrice,NewPrice) values ('Item1',15,0)
go

select * from materials

Delete from materials where ItemCode='test';



