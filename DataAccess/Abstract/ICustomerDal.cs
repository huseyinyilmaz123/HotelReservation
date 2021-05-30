using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Bu interface bizim Customer ile ilgili veritabanında yapacağımız operasyonları içeren interface 
    public interface ICustomerDal:IEntityRepository<Customer>
    {
        
    }
}
