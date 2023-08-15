using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserTokenRepo : Repo, IRepo<UserToken, string, UserToken>
    {
        public UserToken Create(UserToken obj)
        {
            db.UserTokens.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<UserToken> Read()
        {
            throw new NotImplementedException();
        }

        public UserToken Read(string id)
        {
            return db.UserTokens.FirstOrDefault(t => t.TKey.Equals(id));
        }

        public UserToken Update(UserToken obj)
        {
            var token = Read(obj.TKey);
            db.Entry(token).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return token;
            return null;
        }
    }
}