using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManager
{
    internal class Employee:IComparable
    {
        public string name { get; set; }
        public double Sal { get; set; }
        public int CompareTo(object obj)
        {
            var curEmp=obj as Employee;
            if (Sal > curEmp.Sal)
            {
                return 1;
            }
            else if (Sal < curEmp.Sal)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    public class NameEmployee : IComparer<Employee>
    {
        int IComparer<Employee>.Compare(Employee x, Employee y)
        //for ascending we use 1,-1,0
        //for descending we use -1,1,0
        {
            if (x.Sal > y.Sal)
            {
                return 1;
            }
            else if (x.Sal < y.Sal)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    internal class EmployeeKey
    {
        public int Key {  get; set; }
    }
}
