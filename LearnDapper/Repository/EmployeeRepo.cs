using LearnDapper.Model;
using LearnDapper.Model.Data;
using Dapper;
using System.Data;

namespace LearnDapper.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DapperDBContext context;
        public EmployeeRepo(DapperDBContext context)
        {
            this.context = context;
        }

        public async Task<string> Create(Employee employee)
        {
            string response = string.Empty;
            string query = "Insert into tbl_employee(name,email,phone,designation) values (@name,@email,@phone,@designation)";
            var parameters = new DynamicParameters();
            parameters.Add("name", employee.name, DbType.String);
            parameters.Add("email",employee.email,DbType.String);
            parameters.Add("phone", employee.phone, DbType.String);
            parameters.Add("designation", employee.designation, DbType.String);

            using (var connection = this.context.CreateConnection()) 
            {
                await connection.ExecuteAsync(query, parameters);
                response = "Created";
            }
            return response;

        }

        public async Task<string> Update(Employee employee, int code)
        {
            string response = String.Empty;
            string query = "Update tbl_employee set name=@name, email=@email,phone=@phone,designation=@designation where code=@code";
            var parameters = new DynamicParameters();
            parameters.Add("code", employee.code, DbType.Int32);
            parameters.Add("name", employee.name, DbType.String);
            parameters.Add("email",employee.email,DbType.String);
            parameters.Add("phone", employee.phone,DbType.String);
            parameters.Add("designation",employee.designation,DbType.String);

            using (var connection = this.context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
                response = "Record Updated";

            }
            return response;
        
        
        }


        public async Task<List<Employee>> GetAll()
        {
            string query = "Select * from tbl_employee";
            using (var connection = this.context.CreateConnection())
            {
                var employeeList = await connection.QueryAsync<Employee>(query);
                return employeeList.ToList();
            }

        }

        public async Task<Employee> GetByCode(int code)
        {
            string query ="Select * from tbl_employee where code=@code";
            using (var connection = this.context.CreateConnection())
            {
                var emp = await connection.QueryFirstOrDefaultAsync<Employee>(query,new {code});
                return emp;
            }
        }

        public async Task<string> Remove(int code)
        {
            string response = string.Empty;
            string query = "Delete From tbl_employee where code=@code";
            using (var connection = this.context.CreateConnection())
            {
                var emp = await connection.ExecuteAsync(query,new {code});
                response = "Deleted";
            }
            return response;
        }

      
    }
}
