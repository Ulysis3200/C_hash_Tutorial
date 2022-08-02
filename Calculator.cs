using System;

public class Calculator
{
    public double Calculate()
    {
        double a = 0;
        double b = 0;
        double c = 0;
        Console.WriteLine("........Calculator ........");
        Console.WriteLine("Enter number a and press Enter : ");
        string? input1 = Console.ReadLine();
        while (!double.TryParse(input1, out a))
        {
            Console.WriteLine($"{input1} is not a valid input, Please enter a valid input");
            input1 = Console.ReadLine();
        }
        Console.WriteLine("Enter number b and press Enter : ");
        string? input2 = Console.ReadLine();
        while(!double.TryParse(input2, out b))
        {
            Console.WriteLine($"{input2} is not a valid input, Please enter a valid input");
            input2 = Console.ReadLine();
        }
        Console.WriteLine("Choose an option........");
        Console.WriteLine("\t1: Addition");
        Console.WriteLine("\t2: Substraction");
        Console.WriteLine("\t3: Multiplication");
        Console.WriteLine("\t4: Division");
        switch (Console.ReadLine())
        {
            case "1":  Console.WriteLine(a + b);
                break;
            case "2": Console.WriteLine(a - b);
                break;
            case "3": Console.WriteLine(a * b);
                break;
            case "4": while(b == 0)
                {
                    Console.WriteLine("Enter a nonzero value");
                    b = Convert.ToDouble(Console.ReadLine());
                } 
                Console.WriteLine(a / b);
                break;
            default: Console.WriteLine("Select a valid option!");
                break;

        }
        Console.WriteLine("Please press any key to exit..");
        Console.ReadKey();
        return 0;

    }
}
