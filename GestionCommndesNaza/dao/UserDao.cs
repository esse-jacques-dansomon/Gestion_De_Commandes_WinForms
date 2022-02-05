using GestionCommndesNaza.dao.interfaces;
using GestionCommndesNaza.models;
using GestionCommndesNaza.utils;
using System;
using System.Linq;


namespace GestionCommndesNaza.dao
{
    public class UserDao : IUserDao
    {
        private Model1Container manager = new Model1Container();

        public UserDao()
        {
        }

        public User findUserByLoginOrUsername(string login, string password)
        {
            User user = manager.Users.Where(s => s.Login == login).SingleOrDefault();
            return PasswordEncoder.verifyPassword(user, password);
        }
        User IDao<User>.Find(int id)
        {
            return manager.Users.Find(id);
        }

        User[] IDao<User>.FindAll()
        {
            return manager.Users.ToArray();
        }

        User[] IDao<User>.FindBy(string[] array)
        {
            return manager.Users.ToArray();

        }

        User IDao<User>.FindOneBy(string[] array)
        {
            throw new NotImplementedException();
        }
    }
}
