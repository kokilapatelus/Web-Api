using Azure.Core;
using LearnDapper.Model;
using LearnDapper.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearnDapper.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepo repo;
        public EmployeeController(IEmployeeRepo repo) { 
            this.repo = repo;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll() { 
        
            var _listemp = await this.repo.GetAll();
            if(_listemp != null)
            {
                return Ok( _listemp);
            }
            else
            {
                return NotFound();
            }

        }
        [HttpGet("GetBycode/{code}")]
        public async Task<IActionResult> GetBycode(int code)
        {
            var _listemp = await this.repo.GetByCode(code);
            if(_listemp != null)
            {
                return Ok(_listemp);
            }
            else { 
                return NotFound(); 
            }
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] Employee emp)
        {
            var _result = await this.repo.Create(emp);
            return Ok(_result);
            
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] Employee emp, int code)
        {
            var _result = await this.repo.Update(emp, code);
            return Ok(_result);
        }
        [HttpDelete("Remove")]
        public async Task<IActionResult> Remove(int code)
        {
            var _result = await this.repo.Remove(code);
            return Ok(_result);
        }


    }
}
