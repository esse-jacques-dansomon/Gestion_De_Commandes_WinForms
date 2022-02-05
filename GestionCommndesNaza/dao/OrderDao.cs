using GestionCommndesNaza.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommndesNaza.models;


namespace GestionCommndesNaza.dao
{
    public class OrderDao : IOrderDao
    {
        private Model1Container container = new Model1Container();
        public OrderDao()
        {
        }

        Order IDao<Order>.Find(int id)
        {
            throw new NotImplementedException();
        }

        Order[] IDao<Order>.FindAll()
        {
            throw new NotImplementedException();
        }

        Order[] IDao<Order>.FindBy(string[] array)
        {
            throw new NotImplementedException();
        }

        Order IDao<Order>.FindOneBy(string[] array)
        {
            throw new NotImplementedException();
        }

        public List<Order> findOrdersByStatut(string statut)
        {
           return container.Orders.Where(o => o.Statut == statut).ToList();
        }
    }
}
