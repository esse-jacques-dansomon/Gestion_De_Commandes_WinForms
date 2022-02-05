using GestionCommndesNaza.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommndesNaza.service
{
    public interface IService
    {
        User searchUserByLoginAndPassword(string login, string password);
        List<Order> searchOrdersOfClient(Client client);
        List<Order> searchOrdersByEtat(string staut);
        List<Category> searchAllCategory();
        Product[] searchAllProduct();
    }
}
