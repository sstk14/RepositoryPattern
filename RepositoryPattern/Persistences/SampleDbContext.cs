using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace RepositoryPattern.Persistences
{
    public class SampleDbContext : DbContext 
    {
        public DbSet<Entities.Person> People { get; set; }
    }
}
