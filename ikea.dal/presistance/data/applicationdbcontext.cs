using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ikea.dal.models.departments;
using Microsoft.EntityFrameworkCore;

namespace ikea.dal.presistance.data
{
    public class applicationdbcontext:DbContext
    {
        public applicationdbcontext(DbContextOptions<applicationdbcontext> options):base(options) { 
        
        
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("sever=. ;database=ikea;trusted_connection=true;trustservercertificate=true");
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        #region dbset

        public DbSet <Department> Depatments { get; set; }  
        #endregion

    }
}
