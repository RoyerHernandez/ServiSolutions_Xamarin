using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiSolutions_Xamarin.Models
{
    public class City
    {
        [Key]

        public int CityId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres de longitud ")]
        [Display(Name ="City_Name")]
        public string City_Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(1, double.MaxValue, ErrorMessage = "You must select a {0}")]
        public int StateId { get; set; }

        public virtual State State { get; set; }

        public string City_Details { get; set; }

        public string Create_User { get; set; }

        public DateTime Date_Create{ get; set; }

        public string Modify_User { get; set; }

        public DateTime Date_Modify { get; set; }

    }
}