using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ObjectManager objectManager = new ObjectManager();
            //objectManager.Add(8, 0);
            //objectManager.Add(13, 1);//boxing to unbox this we use type casting it will reduce the performance so we generics
            //Console.WriteLine(objectManager.Get(0));
            //Console.WriteLine(objectManager.Get(1));
            //Console.WriteLine(objectManager.GetAll());

            //ObjectManager objectManager1 = new ObjectManager();
            //objectManager1.Add("hello", 0);
            //objectManager1.Add("World", 1);
            //Console.WriteLine(objectManager1.Get(0)+" "+ objectManager1.Get(1));

            //ObjectManager objectManager2 = new ObjectManager();
            //objectManager2.Add(new Employee(), 0);
            //objectManager2.Add(new Employee(), 1);
            ////Console.WriteLine(objectManager2.Name);


            //GenericManager<int> genericManager = new GenericManager<int>();
            //genericManager.Add(23, 0);
            //genericManager.Add(40, 1);
            //Console.WriteLine(genericManager.Get(1));

            //StudentMarks st=new StudentMarks();
            //st.AddMark(65, 0);
            //st.AddMark(77, 1);
            //int mark = st.GetMark(0);
            //Console.WriteLine(mark);

            //GenericManager<ContractEmployee> conEmp = new GenericManager<ContractEmployee>();
            //possible even though we mention the type Employee in [ class GenericManager<T> where T : Employee ]

            //GenericManager<Employee> generic = new GenericManager<Employee>();
            //Employee emp = new Employee(12, "swetha");
            ////this line will not get executed when we use internal class GenericManager<T> where T : struct
            ////this where is tell as generic constraints  to add restrictions to the given generic class
            //generic.Add(emp, 0);
            //Console.WriteLine(generic.increment(0));

            GenericList<int> genericList = new GenericList<int>();
            genericList.Append(10);
            genericList.Append(20);
            genericList.Traverse();
        }
    }
}
