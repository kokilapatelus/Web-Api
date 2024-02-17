using LearnDapper.Model;

namespace LearnDapper.Repository
{
    public interface IEmployeeRepo
    {
        Task<List<Employee>> GetAll();

        Task<Employee> GetByCode(int code);

        Task<string> Create(Employee employee);

        Task<string> Update(Employee employee, int code);

        Task<string> Remove(int code);


    }
}
