using BWB.Api.Models;
using System.Collections.Generic;

namespace BWB.Api.Repositories
{
    public interface ICustomerRepo
    {
        IEnumerable<Customer> GetAllCustomers();
        Customer GetCustomerById(int id);
    }
}
