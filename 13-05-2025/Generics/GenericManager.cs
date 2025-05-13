using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ManageStudents
{
    internal class GenericManager<T> where T : Employee
        //where T : class,new()//accepts only reference datatype
        //where T : struct//struct only allows value datatype and not allowing to create reference datatype like Class(Employee)
    {
        T[] Values = new T[5];//array of any data type
        public void Add(T val, int position)
        {
            Values[position] = val;
        }
        public T Get(int id)
        {
            return Values[id];
        }
        public T[] GetAll()
        {
            return Values;
        }
        public string increment(int pos)
        {
            return Values[pos].GetName()+" and "+ Values[pos].Id;
        }
    }
    //internal class ContractEmployee:Employee//derived class of employee class is accessable
    //{

    //}
}
