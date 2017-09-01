using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileOA.Data.DataBaseContext;
using MobileOA.Data.IRepositories;
using MobileOA.Data.Repositories;
using MobileOA.Models.Entities;
using MobileOA.Services.IServices;
using MobileOA.Services.Services;

namespace MobileOA.API.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {

        #region 请求头
        /*
        Response.Headers.Add("Access-Control-Allow-Headers",
            "Origin, X-Requested-With, Content-Type, Accept,city_region_id,RegistradionID,Authorization");
        Response.Headers.Add("Access-Control-Allow-Methods","GET, PUT, POST, DELETE, OPTIONS");
        Response.Headers.Add("Access-Control-Allow-Origin","*");
        */
        #endregion
        //private IAccountService _accountService;
        
        /*public TestController(IAccountService accountService)
        {
            _accountService = accountService;
        }*/
        
        private IAccountRepository _accountRepository;
        private AccountContext _context;

        public TestController(IAccountRepository accountRepository,AccountContext context)
        {
            _context = context;
            _accountRepository = accountRepository;
            
        }
        
        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            //var result = _accountRepository.GetAll();
            //return result;
            return _context.Users.AsEnumerable();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}