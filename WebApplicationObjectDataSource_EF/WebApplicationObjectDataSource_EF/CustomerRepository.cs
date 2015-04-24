using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        BancoDeDados ctx = new BancoDeDados();
        public List<Customer> GetCustomers()
        {
            return (from c in ctx.Customers
                   select c).Distinct().ToList();
        }

        public List<Customer> GetCustomer(string CustomerID)
        {


            return (from c in ctx.Customers
                    where c.CustomerID == CustomerID
                    select c).Distinct().ToList();
        }

        public void UpdateCustomer(Customer c)
        {
            Customer ca = (from customer in ctx.Customers
                           where customer.CustomerID == c.CustomerID
                           select customer).First();
            ca.Address = c.Address;
            ca.City = c.City;
            ca.CompanyName = c.CompanyName;
            ca.ContactName = c.ContactName;
            ca.ContactTitle = c.ContactTitle;
            ca.Country = c.Country;
            ca.Fax = c.Fax;
            ca.Phone = c.Phone;
            ca.PostalCode = c.PostalCode;
            ca.Region = c.Region;
            ctx.SaveChanges();
        }

        public void InsertCustomer(Customer c)
        {
            ctx.Customers.Add(c);
            ctx.SaveChanges();
        }

        public void DeleteCustomer(string CustomerID)
        {
            Customer c = (from customer in ctx.Customers
                          where customer.CustomerID == CustomerID
                          select customer).First();
            ctx.Customers.Remove(c);
            ctx.SaveChanges();
        }
    }
}