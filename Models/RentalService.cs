using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CarRent2.Models
{
    internal class RentalService
    {
        public List<Car> Cars { get; set; } = new List<Car> { };
        public List<Customer> Customers { get; set; } = new List<Customer> { };

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
    }
}
