using AutoMapper;
using LearnAPI.Model;
using LearnAPI.Repos.Models;

namespace LearnAPI.Helper
{
    public class AutoMapperHandler : Profile
    {
        public AutoMapperHandler() {

            CreateMap<TblCustomer, CustomerModel>().ForMember(item => item.StatusName, option => option.
            MapFrom(item => item.IsActive.Value ? "Active": "InActive"));
        }
    }
}
