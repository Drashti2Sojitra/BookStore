using BookStore.Models.ViewModels;
using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models.DataModels;

namespace BookStore.Repository
{
    public class UserRepository
    {
        BookStoreContext _context = new BookStoreContext();

        public string Email { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Roleid { get; set; }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

  

        public User Register(LoginModel model)
        {
           return _context.Users.FirstOrDefault(c=> c.Email.Equals(model.Email) && c.Password.Equals(model.Password));
        }
       /* public User Register(RegisterModel model)
        {
            User user = new User();
            {
                user.Email = model.Email;
                user.Password = model.Password;
                FirstName = model.FirstName;
                    LastName = model.LastName;
            }
            var entry = _context.Users.Add(user);
            return entry.Entity;
        }*/
    }
}
 