using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        List<Customer> GetCustomer(string CustomerID);
        void UpdateCustomer(Customer c);
        void InsertCustomer(Customer c);
        void DeleteCustomer(string CustomerID);
    }
}
