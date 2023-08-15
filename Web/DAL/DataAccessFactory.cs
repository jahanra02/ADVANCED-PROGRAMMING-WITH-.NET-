using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory

    {
        public static IRepo<User, string, User> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<UserToken, string, UserToken> UserTokenData()
        {
            return new UserTokenRepo();
        }

        public static IAuth<bool> AuthData()
        {
            return new UserRepo();
        }
        public static IRepo<Ticket, string, Ticket> TicketData()
        {
            return new TicketRepo();
        }

    }
}

