using LearnAPI.Helper;
using LearnAPI.Model;
using LearnAPI.Repos.Models;

namespace LearnAPI.Service
{
    public interface ICustomerService 
    {
        Task<List<CustomerModel>> Getall();
        Task<CustomerModel> Getbycode(string code);

        Task<APIresponse> Remove(string code);

        Task<APIresponse> Create(CustomerModel model);

        Task<APIresponse> Update (CustomerModel model, string code);



    }
}
