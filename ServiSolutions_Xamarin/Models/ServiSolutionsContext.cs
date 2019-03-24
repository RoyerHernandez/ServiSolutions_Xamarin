using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServiSolutions_Xamarin.Models
{
    public class ServiSolutionsContext : DbContext
    {

        public ServiSolutionsContext() : base("DefaultConnection") //Hereda el Superconstructor de la clase
        {

        }

        public DbSet<Department> Departments { get; set; }

        public System.Data.Entity.DbSet<ServiSolutions_Xamarin.Models.City> Cities { get; set; }
    }
}