How to Commit Changes on GitHub Repository in Visual Studio.

Clone the Repository

On Project in Solution, Right Click and Select Git Option.

Select Commit/Stash Option.

It will open Git Changes menu.  Now Click on Plus item next to Changes to move all the changes in the staging area.

Once staged, write a message and click on Commit Staged Button.

Now Click a UpArrow(Push) to Remote branch.

Go to Github.com and Create a pull request and merge the branch in to master branch.

----------------------------------------------------------------------------------------------------------------
How to Copy SQL Script File into Database

Create a blank database with the same name appear in the Use Db statement at first Line.

Select all content with control+A and copy the entire script.

Go to Database and Connect then Open New Query Window & Paste the Script

Now Execute the Query. It will add database structure in the database.

--------------------------------------------------------------------------------------------------
Create a Asp.net Core Web Api with .Net 7.

Install below nuget packages.

Dapper
Microsoft.Data.SqlClient

New Api Controller Empty.
----------------------------------------------------------------------------------------------------

In appsetting.json file create a Connection String configuration.

Create a Model employee.cs to map SQL Table column name and values.

Create a DBContext Class to establish connection between SQL Server and application.
	Inject IConfiguration dependancies and hold the value of configuration object into a private readonly variable
	with the help of constructor.
	Create a new SqlConnection Object to hold Sql connection CreateConnection Method. (Import necessary namespace)

Now Register DBContext Class in to service container of Programme.cs File.

builder.Services.AddTransient<DapperDBContext>();

---------------------------------------------------------------------------------------------------------------------------

Create A Repository to hold the data

Create a EmployeeRepo.cs class and IEmployeeRepo.cs interface to hold the data receive from SQL Database

Declare a method below in the interface and implement in EmployeeRepo Class.

IEmployeeRepo.cs

Task<List<Employee>> GetAll();


EmployeeRepo.cs Class

Inject DapperDB Class in the constructor of EmployeeRepo Class and hold the value of dbcontext in private variable.

Register IEmployee Interface and EmployeeRepo Class in the programme.cs file to add dependancies.

builder.Services.AddTransient<IEmployeeRepo, EmployeeRepo>();


---------------------------------------------------------------------------------------------------------------------------
.Net Error & Solution.

CS1503 : 
          can not convert from LearnAPI.Repos.Models.TblCustomer to System.Collection.GenericList<LearnAPI.Repos.Models.TblCustomer

Solution:  

 CS0029 : Can not implicitly Convert type System.Collection.Generic.List<dynamic> to
          System.Collection.Generic.List<LearnDapper.Model.Employee>
 Solution:  Here we have not passed <Employee> type in QueryAsync(query) method. Make sure to import respective namespace
           var emplist = await connection.QueryAsync(query) should be
            
           var emplist = await connection.QueryAsync<Employee>(query);

CS8618  :  Non-nullable property 'name' must contain a non-null value when existing constructor.  Consider
           declaring the field as nullable.

First Build the project after registering our EmployeeRepo depencies in programme.cs file.


CS1983:  The return type of an async method must be void,Task, Task<T>

