using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore
{
    public class DataContext : DbContext
    {
        public DataContext(): base ("tblEmployee") 
        {
            if (!Database.Exists("tblEmployee"))
                Database.SetInitializer(new DropCreateDatabaseAlways<DataContext>());
        }
        public DbSet<tblEmployee> Employees { get; set;}
    }
}
