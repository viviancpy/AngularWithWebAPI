using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using BWB.Api.Models;
using BWB.Api.Repositories;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BWB.Api.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly ICustomerRepo _customerRepo;

        public CustomersController(ICustomerRepo customerRepo)
        {
            _customerRepo = customerRepo;
        }

        // GET: api/customers
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerRepo.GetAllCustomers();
        }

        // GET api/customers/5
        [HttpGet("{id:int}")]
        public Customer Get(int id)
        {
            return _customerRepo.GetCustomerById(id);
        }

        // POST api/customers
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/customers/5
        [HttpPut("{id:int}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/customers/5
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
        }


    }
}
