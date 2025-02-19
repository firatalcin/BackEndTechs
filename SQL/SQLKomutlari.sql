--Select 

select ID, CUSTOMERNAME, CITY, BIRTHDATE, DISTRICT, GENDER, NATION, AGE from CUSTOMERS

--Insert

insert into CUSTOMERS (CUSTOMERNAME, CITY, BIRTHDATE, DISTRICT, GENDER, NATION, AGE) values
('Mehmet Çınar', 'Tokat', '19550101', 'Erbaa', 'E', 'TR', 70)

--Update

update CUSTOMERS set NATION = 'TR'

--Delete

delete from CUSTOMERS

--Truncate

Truncate Table CUSTOMERS

--Where

select * from CUSTOMERS where CITY = 'İstanbul'

