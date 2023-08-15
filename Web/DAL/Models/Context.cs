using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    internal class Context : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<UserToken> UserTokens { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}