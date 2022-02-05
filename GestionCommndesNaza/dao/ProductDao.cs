using GestionCommndesNaza.dao.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionCommndesNaza.models;


namespace GestionCommndesNaza.dao
{
    public class ProductDao : IProductDao
    {
        private Model1Container container = new Model1Container();
        public ProductDao()
        {
        }

        Product IDao<Product>.Find(int id)
        {
            throw new NotImplementedException();
        }

        Product[] IDao<Product>.FindAll()
        {
            return container.Products.ToArray();
        }

        Product[] IDao<Product>.FindBy(string[] array)
        {
            throw new NotImplementedException();
        }

        Product IDao<Product>.FindOneBy(string[] array)
        {
            throw new NotImplementedException();
        }
    }
}
