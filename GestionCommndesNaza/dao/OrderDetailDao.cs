using GestionCommndesNaza.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommndesNaza.models;


namespace GestionCommndesNaza.dao
{
    public class OrderDetailDao : IOrderDetailDao
    {

        public OrderDetailDao() { }
        OrderDetail IDao<OrderDetail>.Find(int id)
        {
            throw new NotImplementedException();
        }

        OrderDetail[] IDao<OrderDetail>.FindAll()
        {
            throw new NotImplementedException();
        }

        OrderDetail[] IDao<OrderDetail>.FindBy(string[] array)
        {
            throw new NotImplementedException();
        }

        OrderDetail IDao<OrderDetail>.FindOneBy(string[] array)
        {
            throw new NotImplementedException();
        }
    }
}
