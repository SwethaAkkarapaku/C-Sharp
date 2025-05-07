using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddUser("Swetha", "12345", "swetha@gmail.com", 22);//in positioned arguments order is important
            //bool Result = AddUser("pooja", "98765", "pooja@gmail.com", 24);
            //DepositSalary(1200,23,2000);
            //AddUser(DisplayName: "name1", email: "name1@gmail.com", password: "pass1", Age: 20);//order is not important for named parameters
            //AddUser("Swetha", "12345", "swetha@gmail.com");//age is omitted if we give the argument value in declaration of the method known as default value

            //double sal = 1234;
            //Console.WriteLine($"before increment :{sal}");
            //IncrementSal(ref sal, out double bonus);//arguments will passed by ref and out
            //Console.WriteLine($"after increment :{sal} bonus:{bonus}");
            //IncrementSal(ref sal, out double bonus2, 20);

            dynamic obj = "swetha";//it will check the type at runtime
            Console.WriteLine(obj.Length);

            var obj2 = "swetha";//it will check the type at compile time // var is implicitly assigned value
            Console.WriteLine(obj2.Length);

        }
        //static bool AddUser(string DisplayName, string password, string email,int Age=23)//age is default parameter here
        //{
        //    Console.WriteLine($"{DisplayName}: {password} : {email} : {Age}");
        //    return true;
        //}
        //static void DepositSalary(params double[] sal)//variable number of arguments
        //{
        //    double net = sal[0] + sal[1] + sal[2];
        //    Console.WriteLine($"Net Earnings : {net}");
        //    //Console.WriteLine($"Salary deposited : {sal}");
        //    //Console.WriteLine($"Net Earnings : {sal}");
        //}
        //static bool IncrementSal(ref double InitialSal,out double bonus)
        //{
        //    bonus = InitialSal * 0.1;
        //    InitialSal = InitialSal * 1.2;
        //    Console.WriteLine($"inside method :{InitialSal} bonus:{bonus}");
        //    return true;
        //}
        ////overloading methods
        //static bool IncrementSal(ref double InitialSal, out double bonus,double deductions=120)
        //{
        //    bonus = InitialSal * 0.1;
        //    InitialSal = (InitialSal * 1.2)-deductions;
        //    Console.WriteLine($"inside IncrementSal method with deductions :{InitialSal} bonus:{bonus}");
        //    return true;
        //}
    }
}
