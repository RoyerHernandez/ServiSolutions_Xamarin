using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiSolutions_Xamarin.Models
{
    public class Department
    {
        [Key]

        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres de longitud ")]
        [Display(Name = "Department_Name")]
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }

    }
}