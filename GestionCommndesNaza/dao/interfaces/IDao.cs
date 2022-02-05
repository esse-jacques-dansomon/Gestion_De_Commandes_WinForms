using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestionCommndesNaza.dao.interfaces
{
    /**
     * Find()
     * FindOneBy()
     * FindAll()
     * FindBy()
     * 
     */

    public interface IDao<T>
    {
        T Find(int id);
        T[] FindAll();
        T[] FindBy(string[] array);
        T FindOneBy(string[] array);
    }
}
