using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudents
{
    internal class ObjectManager//Object based class
    {
        private Object[] obj = new Object[4];
        public void Add(Object ob, int position)//boxing happens 
        {
            obj[position] = ob;
        }
        public Object Get(int position)
        {
            return obj[position];
        }
        public Object[] GetAll()
        {
            return obj;
        }
    }
}
