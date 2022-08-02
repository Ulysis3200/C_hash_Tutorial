// See https://aka.ms/new-console-template for more information
using System;
namespace Hello_World
{
    class Hello
    {
        public static void Main(string[] args)
        {
            int new_variable;
            Console.WriteLine("Hello World");
            Tutidentifiers name = new Tutidentifiers();
            new_variable = name.Nothing();
            Console.WriteLine(new_variable);
            Calculator result = new Calculator();
            result.Calculate();
        }
    }
}
