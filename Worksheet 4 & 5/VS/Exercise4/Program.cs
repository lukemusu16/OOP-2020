using Exercise4;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Kid KidObject = new Kid();
            Child child = new Child();
            Child2 child2 = new Child2();

            Console.WriteLine(KidObject.PrintMessage());
            Console.WriteLine(child.PrintMessage());
            Console.WriteLine(child2.PrintMessage());
        }
    }
}