using Microsoft.EntityFrameworkCore;
using sample.webapiRestful.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.webapiRestful.Data
{
    public class samplewebapiContext: DbContext
    {
        public samplewebapiContext(DbContextOptions<samplewebapiContext> options): base(options) 
        { 
        
        }
        public DbSet<Catagories> Catagories { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            base.OnModelCreating (modelBuilder);
        }
    }
}
