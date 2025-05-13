using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManager;

namespace GenericsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericCollectionTest genericCollectionTest = new GenericCollectionTest();
            genericCollectionTest.TestList2();

            //ObjBasedColTest objBasedColTest = new ObjBasedColTest();
            //objBasedColTest.TestHashTable();
            //GenericAdd(12, 13);
            //GenericAdd(14.5, 15.5);
        }
        public static int Add(int t1, int t2)
        {
            return (t1 + t2);
        }
        public static double Add(double t1, double t2)
        {
            return (t1 + t2);
        }
        public static void GenericAdd<T>(T t1, T t2)
        {
            Console.WriteLine(t1 + " " + t2);
        }
    }
    public interface ICalc<T,K>
    {
        K DoOperation(T inp);
    }
    public class MyClass :ICalc<int,string>
    {
        public string DoOperation(int inp)
        {
            return inp.ToString();
        }
    }
    public interface IMyCompare<T> where T : class //generic interface
    {
        bool Compare(T a, T b);
    }
    public class MyClass2: IMyCompare<string>
    {
        public bool Compare(string a, string b)
        {
            return a.Equals(b);
        }
    }
}
