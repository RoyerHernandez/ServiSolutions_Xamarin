using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ServiSolutions_Xamarin.Models
{
    public class ServiSolutionsContext : DbContext
    {

        public ServiSolutionsContext() : base("DefaultConnection") //Hereda el Superconstructor de la clase
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<ServiSolutions_Xamarin.Models.City> Cities { get; set; }

        public System.Data.Entity.DbSet<ServiSolutions_Xamarin.Models.State> States { get; set; }
    }
}