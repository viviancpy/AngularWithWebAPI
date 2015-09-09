using BWB.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BWB.Api.Repositories
{
    public class CustomerRepo: ICustomerRepo
    {
        private readonly IEnumerable<Customer> _fakeCustomers;
        public CustomerRepo()
        {
            _fakeCustomers = new[] {
                new Customer {
                    CustomerId = 1234, FirstName="Alan", MiddleName="John", LastName="Smith", DateOfBirth=new DateTime(1970, 3, 5), HomePhone="04218793",
                    AddressLines = new [] { "123 College Street", "Te Aro", "Wellington", "New Zealand"}
                },
                new Customer {
                    CustomerId = 113432, FirstName="Barry", MiddleName="Henry", LastName="Wood", DateOfBirth=new DateTime(1965, 12, 13), HomePhone="095897789", MobilePhone="021348971",
                    AddressLines = new [] { "245 George Road", "Mt Eden", "Auckland", "New Zealand"}
                },
                new Customer {
                    CustomerId = 54879, FirstName="William", MiddleName="Barry", LastName="Wilson", DateOfBirth=new DateTime(1950, 4, 25), HomePhone="048972166", MobilePhone="02345822",
                    AddressLines = new [] { "456 High Street", "Lower Hutt", "Wellington", "New Zealand"}
                },
                new Customer {
                    CustomerId = 8989889, FirstName="Nicole", LastName="Kidman", DateOfBirth=new DateTime(1967, 6, 20), HomePhone="04897465", MobilePhone="02348572",
                    AddressLines = new [] { "16 High Street", "Lower Hutt", "Wellington", "New Zealand"}
                },
            };
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _fakeCustomers;
        }

        public Customer GetCustomerById(int id)
        {
            return _fakeCustomers.FirstOrDefault(c => c.CustomerId == id);
        }
    }
        
}
