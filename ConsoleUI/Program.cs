using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var item in customerManager.GetAll())
            {
                Console.WriteLine(item.CustomerName);
            }
        }
    }
}
