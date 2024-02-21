using AutoMapper;
using LearnAPI.Helper;
using LearnAPI.Model;
using LearnAPI.Repos;
using LearnAPI.Repos.Models;
using LearnAPI.Service;
using Microsoft.EntityFrameworkCore;

namespace LearnAPI.Container
{
    public class CustomerService : ICustomerService
    {
        private readonly LeanrnContextb _context;
        private readonly IMapper _mapper;
        public CustomerService(LeanrnContextb context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;   
        }

        public async Task<APIresponse> Create(CustomerModel data)
        {
            APIresponse response = new APIresponse();
            try
            {
                TblCustomer _customer = this._mapper.Map<CustomerModel,TblCustomer>(data);
                await this._context.TblCustomers.AddAsync(_customer);
                await this._context.SaveChangesAsync();
                response.ResponseCode = 201;
                response.Result = data.Code;

            }
            catch (Exception ex)
            {
                response.ResponseCode = 400;
                response.ErrorMessage = ex.Message;
                
            }
            return response;


        }

        public  async Task<List<CustomerModel>> Getall()
        {
            List<CustomerModel> _response = new List<CustomerModel>();
            var data = await this._context.TblCustomers.ToListAsync();
            if(data != null )
            {
                _response = this._mapper.Map<List<TblCustomer>, List<CustomerModel>>(data);
            }

            return _response;

        }

        public  async Task<CustomerModel> Getbycode(string code)
        {
            CustomerModel _response = new CustomerModel();
            var data = await this._context.TblCustomers.FindAsync();
            if (data != null)
            {
                _response = this._mapper.Map<List<TblCustomer>, List<CustomerModel>>(data);
            }

            return _response;

        }

        public Task<APIresponse> Remove(string code)
        {
            throw new NotImplementedException();
        }

        public Task<APIresponse> Update(CustomerModel model, string code)
        {
            throw new NotImplementedException();
        }
    }
}
