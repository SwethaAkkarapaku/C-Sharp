using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataManager
{
    internal class ObjBasedColTest
    {
        ArrayList arrayList = new ArrayList();
        public void TestArrayList()
        {
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add("swetha");//not type safety
            arrayList.Add(true);// not type safety
            Console.WriteLine(arrayList[1]);//index access, index startswith 0
            int ItemCount=arrayList.Count;//property
            int val=(int)arrayList[0];//unboxing, typecast required
            object[] arr=arrayList.ToArray();//to convert arraylist to array
            arrayList.RemoveAt(0);//remove based on the index position
            arrayList.Clear();//remove all elements
        }
        public void TestStack()
        {
            Stack stack=new Stack();
            stack.Push(1);//adding element at the top of the stack
            stack.Push(2);
            stack.Pop();//remove and return element from top of the stack
            int nCount=stack.Count;
            //stack[0] index access not allowed ,applicable for IList Interface implemented classes
            foreach (object obj1 in stack)
            {
                Console.WriteLine(obj1.ToString());
            }
            object obj=stack.Peek();//return element from top of the stack
        }
        public void TestHashTable()
        {
            Hashtable ht=new Hashtable();//key value pair
            ht.Add(1, 1);
            ht.Add(2, 2);
            ht.Add(3, "swetha");
            ht[2] = 138;
            if( ht.ContainsKey(2))
            {

            }
            Console.WriteLine(ht[2]);
            EmployeeKey employeeKey1 = new EmployeeKey() { Key = 12 };
            //EmployeeKey employeeKey2 = new EmployeeKey() { Key = 12 };
            Employee employee = new Employee()
            {
                name = "swetha"
            };
            ht.Add(employeeKey1, employee);
            //ht.Add(employeeKey2, employee);
            foreach(var key  in ht.Keys)
            {
                Console.WriteLine(key.ToString());
            }
        }

    }
}
