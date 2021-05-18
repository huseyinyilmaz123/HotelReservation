using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPaymentService
    {
        void Add(Payment payment);
        void Update(Payment payment);
        void Delete(Payment payment);
        List<Payment> GetAll();
    }
}
