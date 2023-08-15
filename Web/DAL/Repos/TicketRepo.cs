using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TicketRepo : Repo, IRepo<Ticket, string, Ticket>
    {
        public Ticket Create(Ticket obj)
        {
            db.Tickets.Add(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var ex = Read(id);
            db.Tickets.Remove(ex);
            return db.SaveChanges() > 0;
        }

        public List<Ticket> Read()
        {
            return db.Tickets.ToList();
        }

        public Ticket Read(string id)
        {
            return db.Tickets.Find(id);
        }

        public Ticket Update(Ticket obj)
        {
            var ex = Read(obj.TicketId);
            db.Entry(ex).CurrentValues.SetValues(obj);
            if (db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}