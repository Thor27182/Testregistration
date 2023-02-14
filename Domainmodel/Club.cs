using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domainmodel
{
    public class Club
    {
        public List<User> Users { get; }

        public Club() => Users = new List<User>();

        public void RegisterUser(User newUser)
        {
            if (Users.Any(user => user.Username == newUser.Username))
            {
                throw new NotImplementedException();
            }
            else
            {
                Users.Add(newUser);
            }
        }
    }
}
