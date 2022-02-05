using GestionCommndesNaza.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommndesNaza.models;


namespace GestionCommndesNaza.dao
{
    public class DeliverDao : IDeliverDao
    {
        public DeliverDao()
        {
        }

        Deliver IDao<Deliver>.Find(int id)
        {
            throw new NotImplementedException();
        }

        Deliver[] IDao<Deliver>.FindAll()
        {
            throw new NotImplementedException();
        }

        Deliver[] IDao<Deliver>.FindBy(string[] array)
        {
            throw new NotImplementedException();
        }

        Deliver IDao<Deliver>.FindOneBy(string[] array)
        {
            throw new NotImplementedException();
        }
    }
}
