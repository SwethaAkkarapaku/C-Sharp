using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudents
{
    internal class EmployeeManager
    {
        private Employee[] employees= new Employee[3];
        public void AddEmployee(Employee employee,int sno)
        {
            employees[sno] = employee;
        }
        public Employee GetEmployee(int sno)
        {
            return employees[sno];
        }
        public Employee[] GetAllEmployees()
        {
            return employees;
        }
    }
}
