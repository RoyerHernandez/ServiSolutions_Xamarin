using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ServiSolutions_Xamarin.Models
{
    public class State
    {
        [Key]

        public int StateId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener maximo {1} caracteres de longitud ")]
        [Display(Name = "State_Name")]
        public string State_Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }

        public string State_Details { get; set; }

        public string Create_User { get; set; }

        public DateTime Date_Create { get; set; }

        public string Modify_User { get; set; }

        public DateTime Date_Modify { get; set; }
    }
}