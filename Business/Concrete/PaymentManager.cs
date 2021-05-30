using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PaymentManager : IPaymentService
    {
        IPaymentDal _paymentDal;
        public PaymentManager(IPaymentDal paymentDal)
        {
            _paymentDal = paymentDal;
        }

        public void Add(Payment payment)
        {
            _paymentDal.Add(payment);
        }

        public void Delete(Payment payment)
        {
            _paymentDal.Delete(payment);
        }

        public List<Payment> GetAll()
        {
            return _paymentDal.GetAll();
        }

        public void Update(Payment payment)
        {
            _paymentDal.Update(payment);
        }
    }
}
