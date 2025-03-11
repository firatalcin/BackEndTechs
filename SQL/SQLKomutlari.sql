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

--And Operatörü

select * from CUSTOMERS where CITY = 'İstanbul' and DISTRICT = 'Beylikdüzü'

--Or Operatörü

select * from CUSTOMERS where CITY = 'İstanbul' or CITY = 'Erzurum'

--Distinct

select Distinct AGE from CUSTOMERS where CITY = 'İstanbul'

--Order By

select * from CUSTOMERS order by CITY, DISTRICT asc

-- Top

select top 1 * from CUSTOMERS order by CUSTOMERNAME 

-- Aggregate Functions

select Count(Id), Min(AMOUNT), Max(TOTALPRICE), SUM(PRICE), AVG(AMOUNT) from SALES

-- Group By

select CITY, SUM(TOTALPRICE) as TOTALPRICE from SALES group by CITY order by Sum(TOTALPRICE) desc



