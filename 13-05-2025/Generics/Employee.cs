using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudents
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(int id,string name)
        {
            Id= id;
            Name= name;
        }
        public string GetName()
        {
            return Name;
        }
    }
}
