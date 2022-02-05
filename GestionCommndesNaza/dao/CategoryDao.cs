using GestionCommndesNaza.dao.interfaces;
using GestionCommndesNaza.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommndesNaza.dao
{
    public class CategoryDao : ICategoryDao
    {
        Model1Container container = new Model1Container();
        public CategoryDao()
        {
        }

        public Category Find(int id)
        {
            throw new NotImplementedException();

        }

        public Category[] FindAll()
        {
            return container.Categories.ToArray();
        }

        public Category[] FindBy(string[] array)
        {
            throw new NotImplementedException();
        }

        public Category FindOneBy(string[] array)
        {
            throw new NotImplementedException();
        }
    }
}
