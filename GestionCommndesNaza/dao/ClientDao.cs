using GestionCommndesNaza.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommndesNaza.models;


namespace GestionCommndesNaza.dao
{
    public class ClientDao : IClientDao
    {
        public ClientDao()
        {
        }

        Client IDao<Client>.Find(int id)
        {
            throw new NotImplementedException();
        }

        Client[] IDao<Client>.FindAll()
        {
            throw new NotImplementedException();
        }

        Client[] IDao<Client>.FindBy(string[] array)
        {
            throw new NotImplementedException();
        }

        Client IDao<Client>.FindOneBy(string[] array)
        {
            throw new NotImplementedException();
        }
    }
}
