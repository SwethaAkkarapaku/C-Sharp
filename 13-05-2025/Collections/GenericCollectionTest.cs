using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static DataManager.Employee;

namespace DataManager
{
    internal class GenericCollectionTest
    {
        public void TestList()
        {
            var li = new List<int>();
            li.Add(15);
            li.Add(2);
            li.Add(36);
            li.Add(4);
            li.Add(5);
            li.Add(67);
            for(int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
            foreach(int val in li)
            {
                Console.WriteLine(val);
            }
            //li.RemoveAt(0);
            li.Sort();
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
            List<int> found = li.FindAll((val) => val % 2 != 0);
            foreach (int val in found)
            {
                Console.WriteLine(val);
            }
        }
        public void TestList2()
        {
            var li = new List<Employee>();
            li.Add(new Employee()
            {
                name="name1",
                Sal=12000
            });
            li.Add(new Employee()
            {
                name = "name2",
                Sal = 20000
            });
            li.Add(new Employee()
            {
                name = "name3",
                Sal = 10000
            });
            //li.RemoveAt(0);
            //li.Sort();//rise an exception
            li.Sort(new NameEmployee());//to overcome that we are using IComparer interface because we have multiple objects
            //if we have single object then we 
            foreach (Employee val in li)
            {
                Console.WriteLine(val.name);
            }
        }
        public void TestSortedList()
        {
            SortedList<EmployeeKey,Employee> slist= new SortedList<EmployeeKey,Employee>();

        }
    }
}
