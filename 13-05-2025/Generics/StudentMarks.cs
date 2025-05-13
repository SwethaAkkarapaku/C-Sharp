using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudents
{
    internal class StudentMarks
    {
        private int[] marks=new int[10];
        public void AddMark(int mark,int sno)
        {
            marks[sno] = mark;
        }
        public int GetMark(int id)
        {
            return marks[id];
        }
        public int[] GetAllMark()
        {
            return marks;
        }
    }
}
