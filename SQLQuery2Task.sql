use Adventureworks2019
select * from Person.Person
--taask 1
select FirstName, LastName from Person.Person
where title is not null




--task2
select FirstName, LastName from Person.Person
 where FirstName like '%a'and LastName like '%a' 

 select FirstName, LastName from Person.Person
 where FirstName like 'a%'and LastName like 'a%' 





 --Task 3
select * from Sales.Currency 
select * from Sales.CountryRegionCurrency



select CC.CurrencyCode,CC.Name from Sales.Currency CC,Sales.CountryRegionCurrency CREC


select * from HumanResources.Department








--SELECT DATA_TYPE from INFORMATION_SCHEMA. COLUMNS where table_schema = 'Adventureworks2019' and table_name = 'HumanResources.Department'
--disp stru HumanResources.Department

--create table HR.Dept 
--( sno,DepartmentID, Name,GroupName, ModifiedData)
--values
--select * from HumanResources.Department

--create schema HR.Dept
--select * from schema HR
--go
--select * into HR.Dept from HumanResources.Department



--SET IDENTITY_INSERT HR.Dept ON

--insert into select [HumanResources.Department]
--( sno,DepartmentID, Name,GroupName, ModifiedData)
--select sno,DepartmentID, Name,GroupName, ModifiedData 
--from HumanResources.Department
--SET IDENTITY_INSERT HR.Dept OFF
--select * from HR.Dept









--Task 4
drop table HR.Dept

create table HR.Dept
(
DepartmentID numeric(2),
Name Varchar(50),
GroupName Varchar(50),
ModifiedDate date
)
insert into HR.Dept select * from HumanResources.Department

-- select * from HR3





--Task 5

--select * from new_employees1
--SET IDENTITY_INSERT new_employees  ON
USE Adventureworks2019;  
go
CREATE TABLE new_employees1  
(  
 SNo int IDENTITY(1,1),  
 fname varchar (20),  
 lname varchar(30),
 depatmt char(20),  
 city varchar(30)
);  
--drop table  new_employees1 
insert into new_employees1 values('Valmiki','M','IT','Mumbai') 
insert into new_employees1 values('Raama','S','Civil','Mumbai') 
insert into new_employees1 values('Swathi Priya','S','Construction','Mumbai') 
insert into new_employees1 values('Hanuman','K','Networking','Mumbai') 
insert into new_employees1 values('Sita','N','Development','Mumbai')
insert into new_employees1 values('Arjun','B','Application Manager','Mumbai') 
insert into new_employees1 values('Shalini','D','Product Designer','Mumbai') 
insert into new_employees1 values('Ragavi','M','Administration Management','Mumbai') 
insert into new_employees1 values('Sandra','R','Team Leader','Mumbai') 
insert into new_employees1 values('Sweatha','P','Tester','Mumbai') 
insert into new_employees1 values('Aishwarya','T','Organizer','Mumbai')
insert into new_employees1 values('Varshini','D','Supplier','Mumbai') 
insert into new_employees1 values('Riya','C','Deployment Team','Mumbai') 
insert into new_employees1 values('Yalini','O','End User','Mumbai') 
insert into new_employees1 values('Rani','P','Worker','Mumbai') 
insert into new_employees1 values('Mani','T','Solution team','Mumbai') 
insert into new_employees1 values('Deepika','Cleaning Managemnt','IT','Mumbai')
insert into new_employees1 values('Sharan','B','Ticketing Team','Mumbai') 
insert into new_employees1 values('Senthil Kumar','M','Designer','Mumbai')
insert into new_employees1 values('Meenakshi','C','Full Stack Developer','Mumbai') 






--Task 6
 
Perform inner join operation to display businessentityid,addresstypeid from
humanresources.department and Person.BusinessEntityAddress

SELECT B.businessentityid,B.addresstypeid 
     FROM humanresources.department A 
      INNER JOIN Person.BusinessEntityAddress B
	  on A.ModifiedDate = B.ModifiedDate
        --ON A.emp_dept = B.dpt_code;


		
select * from Person.BusinessEntityAddress

select * from HumanResources.department





--Task 7


select  distinct GroupName from HumanResources.Department




--Task 8

Select  p.StandardCost,sum(Pr.ListPrice+Pr.StandardCost) as SumOfListPrice_S
from Production.ProductCostHistory p
join Production.Product Pr
on Pr.StandardCost=p.StandardCost group by p.StandardCost




--Task 9


select DATEDIFF(YEAR,StartDate,EndDate) as YearsOnRole
from
HumanResources.EmployeeDepartmentHistory





--Task 10

select Sum(SalesQuota+5000) as total 
from Sales.SalesPersonQuotaHistory 
where SalesQuota>100000 group by SalesQuota order by SalesQuota asc 






--Task 11


Select max(TaxRate) as MAX_TaxRate from Sales.SalesTaxRate




--Task 12


select DepartmentID,Em.BusinessEntityID,ShiftID,BirthDate,FLOOR(DATEDIFF(DAY, BirthDate, GETDATE()) / 365.25) AS AGE
FROM HumanResources.Employee Em 
JOIN HumanResources.EmployeeDepartmentHistory EmDH ON EmDH.BusinessEntityID = Em.BusinessEntityID



--Task 13

CREATE VIEW HumanResources.Name_age
AS 
select DepartmentID,Em.BusinessEntityID,ShiftID,BirthDate,FLOOR(DATEDIFF(DAY, BirthDate, GETDATE()) / 365.25) AS AGE
FROM HumanResources.Employee Em 
JOIN HumanResources.EmployeeDepartmentHistory EmDH ON EmDH.BusinessEntityID = Em.BusinessEntityID

--Select * from sys.views
--Select * from sys.procedures





--Task 14

select * from HumanResources.Department
select * from [HumanResources].[EmployeeDepartmentHistory]
select * from [HumanResources].[EmployeePayHistory]





--Task 15

select Dp.DepartmentID,MAX(EPH.Rate)Rate from HumanResources.Department Dp
JOIN HumanResources.EmployeeDepartmentHistory EmDH ON EmDH.DepartmentID = Dp.DepartmentID
JOIN HumanResources.EmployeePayHistory EPH ON EPH.BusinessEntityID =EmDH.BusinessEntityID
GROUP BY Dp.DepartmentID ORDER BY Dp.DepartmentID




--Task 16

SELECT 
FirstName,MiddleName,Title,AddressTypeID,per.BusinessEntityID
from person.person per
LEFT JOIN person.BusinessEntityAddress BEAD ON per.BusinessEntityID =BEAD.BusinessEntityID
WHERE per.Title IS NOT NULL



--Task 17


Select ProductID,LocationID,Shelf
from Production.ProductInventory where (ProductID between 300 and 350) and (LocationID =50) or (Shelf='E')





--Task 18

SELECT Proinvent.LocationID,Shelf,Name
FROM Production.ProductInventory Proinvent 
JOIN Production.Location Proloc
ON 
Proinvent.LocationID=Proloc.LocationID






--Task 19

Select AddressID,AddressLine1,AddressLine2,statpro.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince statpro
join Person.Address Peradd
on
statpro.StateProvinceID=Peradd.StateProvinceID





--Task 20


select CREC.CurrencyCode,SUM(SAOHEAD.SubTotal+SAOHEAD.TaxAmt) As Total
from Sales.SalesOrderHeader SAOHEAD
INNER JOIN Sales.SalesTerritory STER ON SAOHEAD.TerritoryID = STER.TerritoryID
INNER JOIN Sales.CountryRegionCurrency CREC ON CREC.CountryRegionCode = STER.CountryRegionCode
GROUP BY CurrencyCode





