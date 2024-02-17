using LearnDapper.Model;
using LearnDapper.Model.Data;

namespace LearnDapper.Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DapperDBContext context;
        public EmployeeRepo(DapperDBContext context)
        {
            this.context = context;
        }
        public Task<List<Employee>> GetAll()
        {
            
        }
    }
}
