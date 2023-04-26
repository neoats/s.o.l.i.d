using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleResponsibility
{
    public class CustomerRepository
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"{customer} Added");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine($"{customer} Updated");
        }
        public void Delete(int customerId)
        {
            Console.WriteLine($"Customer Deleted");
        }
    }

}
