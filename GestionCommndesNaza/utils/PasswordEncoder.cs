using GestionCommndesNaza.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommndesNaza.utils
{
    class PasswordEncoder
    {
        public static string hash(string password)
        {
            return PasswordHashing.PasswordHasher.Hash(password);
        }

        public static User verifyPassword(User user, string password)
        {
            if (user != null && PasswordHashing.PasswordHasher.Validate(password, user.Password))
            {
                return user;
            }
            return null;
        }
    }
}
