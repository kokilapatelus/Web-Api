using LearnDapper.Model;

namespace LearnDapper.Repository
{
    public interface IEmployeeRepo
    {
        Task<List<Employee>> GetAll();
    }
}
