using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; 

            
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            
            Console.WriteLine("OBJECT-ORIENTED PROGRAMMING\r");
            Console.WriteLine("Calculator ni Sarmiento :'> \n");

            while (!endApp)
            {
                
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                
                Console.Write("Input your first number then click enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("INVALID!!! Please input an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                
                Console.Write("Input another number then click again the enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("INVALID!!! Please input an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                
                Console.WriteLine("Choose your operator below: ");
                Console.WriteLine("\t+ = Add");
                Console.WriteLine("\t- = Subtract");
                Console.WriteLine("\t* = Multiply");
                Console.WriteLine("\t/ = Divide");
                Console.Write("What operator will you choose? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation is INVALID!!! \n");
                    }
                    else Console.WriteLine("TOTAL= {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("EROOR!!! \n - Details: " + e.Message);
                }

                Console.WriteLine("Thank you for using 'Calcu ni Sarmiento' Enjoy! =) \n");

                
                Console.Write("Type 'n' then click ENTER to close the application, or click any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;
        }
    }
}