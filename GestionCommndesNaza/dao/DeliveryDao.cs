using GestionCommndesNaza.dao.interfaces;
using GestionCommndesNaza.models;
using System;

namespace GestionCommndesNaza.dao
{
    public class DeliveryDao : IDeliveryDao
    {
        public DeliveryDao()
        {
        }

        Delivery IDao<Delivery>.Find(int id)
        {
            throw new NotImplementedException();
        }

        Delivery[] IDao<Delivery>.FindAll()
        {
            throw new NotImplementedException();
        }

        Delivery[] IDao<Delivery>.FindBy(string[] array)
        {
            throw new NotImplementedException();
        }

        Delivery IDao<Delivery>.FindOneBy(string[] array)
        {
            throw new NotImplementedException();
        }
    }
}
