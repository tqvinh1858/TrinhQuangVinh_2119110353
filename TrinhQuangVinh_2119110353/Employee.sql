create database HR 
go
use HR
go
create table Employee_2119110353(
IdEmployee nvarchar(60), 
NameEmp nvarchar(255), 
PlaceBirth nvarchar(255),
IdDepartment nvarchar(60),
DateBirth date, 
Gender int
)

insert into Employee_2119110353 (IdEmployee,NameEmp,DateBirth,Gender,PlaceBirth,IdDepartment) values ('C53418', N'Trần Tiến','2000/10/11', 1,N'Hà Nội','IT')
insert into Employee_2119110353 (IdEmployee,NameEmp,DateBirth,Gender,PlaceBirth,IdDepartment) values ('X53416', N'Nguyễn Cường','1999/07/21', 0,N'Đắk Lắk','KT')
insert into Employee_2119110353 (IdEmployee,NameEmp,DateBirth,Gender,PlaceBirth,IdDepartment) values ('M53417', N'Nguyễn Hào','2001/12/25', 1,N'TP.Hồ Chí Minh','KSNB')

go
create table Department_2119110353(
IdDepartment nvarchar(60), 
NameDep nvarchar(255))

insert into Department_2119110353 values ('IT', N'Công Nghệ Thông Tin')
insert into Department_2119110353 values ('KT', N'Kế toán')
insert into Department_2119110353 values ('KSNB', N'Kiểm soát nội bộ')

select*from Employee_2119110353

select*from Department_2119110353

--Tạo store
--1.Insert
go
create proc spInsertEmployee
@IdEmployee nvarchar(60), 
@NameEmp nvarchar(255), 
@PlaceBirth nvarchar(255),
@IdDepartment nvarchar(60),
@DateBirth date, 
@Gender int
as
begin
    insert Employee_2119110353(IdEmployee,NameEmp,DateBirth,Gender,PlaceBirth,IdDepartment) values(@IdEmployee,@NameEmp,@DateBirth,@Gender,@PlaceBirth,@IdDepartment)
end

--2.Update
go
create proc spUpdateEmployee
@IdEmployee nvarchar(60), 
@NameEmp nvarchar(255), 
@PlaceBirth nvarchar(255),
@IdDepartment nvarchar(60),
@DateBirth date, 
@Gender int
as
begin
    update Employee_2119110353
    set
        IdEmployee = @IdEmployee,
        NameEmp = @NameEmp,
        DateBirth = @DateBirth,
		Gender=@Gender,
		PlaceBirth=@PlaceBirth,
		IdDepartment=@IdDepartment
    where IdEmployee = @IdEmployee
end

--3.Delete
go
create proc spDeleteEmployee
@IdEmployee int
as
begin
    delete Employee_2119110353 where IdEmployee = @IdEmployee
end
