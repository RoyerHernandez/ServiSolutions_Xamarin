using ServiSolutions_Xamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiSolutions_Xamarin.Clases
{
    public class CombosHelper : IDisposable
    {
        private  static ServiSolutionsContext db = new ServiSolutionsContext();

        public static List<Department> GetDepartments()
        {
            var departments = db.Departments.ToList();
            departments.Add(new Department
            {
                DepartmentId = 0,
                Name = "[Select a department...]",
            });
            return departments.OrderBy(d => d.Name).ToList();
        }

        public static List<State> GetStates()
        {
            var states = db.States.ToList();
            states.Add(new State
            {
                StateId = 0,
                State_Name = "[Select a State...]"
            });
            return states.OrderBy(d => d.State_Name).ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}