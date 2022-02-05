using GestionCommndesNaza.dao.interfaces;
using GestionCommndesNaza.models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GestionCommndesNaza.service
{
    public class Service : IService
    {
        private ICategoryDao categoryDao;
        private IClientDao clientDao;
        private IDeliverDao deliverDao;
        private IDeliveryDao deliveryDao;
        private IOrderDao orderDao;
        private IOrderDetailDao orderDetailDao;
        private IPaymentDao paymentDao;
        private IProductDao productDao;
        private IUserDao userDao;
        public Model1Container container = new Model1Container();

        public Service(ICategoryDao categoryDao,
                       IClientDao clientDao,
                       IDeliverDao deliverDao,
                       IDeliveryDao deliveryDao,
                       IOrderDao orderDao,
                       IOrderDetailDao orderDetailDao,
                       IPaymentDao paymentDao,
                       IProductDao productDao,
                       IUserDao userDao)
        {
            this.CategoryDao = categoryDao;
            this.ClientDao = clientDao;
            this.DeliverDao = deliverDao;
            this.DeliveryDao = deliveryDao;
            this.OrderDao = orderDao;
            this.OrderDetailDao = orderDetailDao;
            this.PaymentDao = paymentDao;
            this.ProductDao = productDao;
            this.UserDao = userDao;
        }

        private IUserDao UserDao { get => userDao; set => userDao = value; }
        private IProductDao ProductDao { get => productDao; set => productDao = value; }
        private IPaymentDao PaymentDao { get => paymentDao; set => paymentDao = value; }
        private IOrderDetailDao OrderDetailDao { get => orderDetailDao; set => orderDetailDao = value; }
        private IOrderDao OrderDao { get => orderDao; set => orderDao = value; }
        private IDeliveryDao DeliveryDao { get => deliveryDao; set => deliveryDao = value; }
        private IDeliverDao DeliverDao { get => deliverDao; set => deliverDao = value; }
        private IClientDao ClientDao { get => clientDao; set => clientDao = value; }
        private ICategoryDao CategoryDao { get => categoryDao; set => categoryDao = value; }


        public User searchUserByLoginAndPassword(string login, string password)
        {
            return this.UserDao.findUserByLoginOrUsername(login, password);
        }

        public List<Order> searchOrdersOfClient(Client client)
        {
            throw new NotImplementedException();
        }

        public List<Order> searchOrdersByEtat(string staut)
        {
            return orderDao.findOrdersByStatut(staut);
        }

        public List<Category> searchAllCategory()
        {
            return this.CategoryDao.FindAll().ToList();
        }

        public Product[] searchAllProduct()
        {
            return productDao.FindAll();
        }

        public Model1Container Container { get => container; }

    }

}
