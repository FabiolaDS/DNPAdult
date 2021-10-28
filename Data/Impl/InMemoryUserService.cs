using System;
using System.Collections.Generic;
using System.Linq;
using Family.Data;

namespace Family.Data.Impl
{
    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User
                {
                    password = "123456",
                    userName = "Fabiola"
                },
                new User
                {
                    password = "123456",
                    userName = "Jakob"
                },
                new User
                {
                    password = "123456",
                    userName = "Kasper"
                }
            }.ToList();
        }


        public User ValidateUser(string userName, string password)
        {
            User first = users.FirstOrDefault(user => user.userName.Equals(userName));
            if (first == null)
            {
                throw new Exception("User not found");
            }

            if (!first.password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return first;
        }
    }
}