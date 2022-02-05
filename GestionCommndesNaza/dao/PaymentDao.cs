

using GestionCommndesNaza.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommndesNaza.models;


namespace GestionCommndesNaza.dao
{
    public class PaymentDao : IPaymentDao
    {
        public PaymentDao()
        {
        }

        Payment IDao<Payment>.Find(int id)
        {
            throw new NotImplementedException();
        }

        Payment[] IDao<Payment>.FindAll()
        {
            throw new NotImplementedException();
        }

        Payment[] IDao<Payment>.FindBy(string[] array)
        {
            throw new NotImplementedException();
        }

        Payment IDao<Payment>.FindOneBy(string[] array)
        {
            throw new NotImplementedException();
        }
    }
}
