using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ManageStudents
{
    internal class GenericList<T>
    {
        Node<T> Root;
        public void Append(T item)
        {
            if (Root == null)
            {
                Root = new Node<T>();
                Root.Value = item;
            }
            else
            {
                Node<T> temp = Root;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = new Node<T>()
                {
                    Value = item
                };
            }
        }
        public void Traverse()
        {
            Node<T> node = Root;
            while(node!=null)
            {
                Console.Write(node.Value+"----> ");
                node = node.next;
            }
        }
    }
    public class Node<T>
    {
        public T Value {  get; set; }
        public Node<T> next;
    }
}
