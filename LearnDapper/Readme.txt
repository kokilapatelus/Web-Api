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

---------------------------------------------------------------------------------------------------------------------------







