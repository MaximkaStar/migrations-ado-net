using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFramework1
{
    public class UserContext : DbContext
    {
        public UserContext() : base("DbConnection") {}
        
        public DbSet<Person>  persons { get; set; } 
    }
}
