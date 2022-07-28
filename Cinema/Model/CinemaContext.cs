using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Model
{
    internal class CinemaContext : DbContext
    {
        public CinemaContext () : base ("Data Source=.;Initial Catalog=CinemaDB;Persist Security Info=True;MultipleActiveResultSets=True") {}
        public virtual DbSet<Account> Accounts { get; set; }
    }
}
