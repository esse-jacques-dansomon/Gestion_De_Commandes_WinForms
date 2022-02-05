using GestionCommndesNaza.dao;
using GestionCommndesNaza.service;

namespace GestionCommndesNaza.fabrique
{
    public class Fabrique
    {

        public static IService GetServiceInstance()
        {
            return new Service(
                categoryDao: new CategoryDao(),
                clientDao: new ClientDao(),
                deliverDao: new DeliverDao(),
                deliveryDao: new DeliveryDao(),
                orderDao: new OrderDao(),
                orderDetailDao: new OrderDetailDao(),
                paymentDao: new PaymentDao(),
                productDao: new ProductDao(),
                userDao: new UserDao()
            );
        }
    }
}
