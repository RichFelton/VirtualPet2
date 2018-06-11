using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        public string EmployeeName { get; set; }

        public Employee() // default constructor
        {

        }

        public Employee(string employeeName) //loaded constructor
        {
            EmployeeName = employeeName;
        }

        public abstract void ManagerHours();

        public abstract void VolunteerHours();
    }
}
