using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class SimpleCalculator
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator (+, -, *, /): ");
            char operatorSymbol = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result;
            switch (operatorSymbol)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("Cannot divide by zero");
                    }
                    result = num1 / num2;
                    break;
                default:
                    throw new InvalidOperationException("Invalid operator");
            }

            Console.WriteLine("Result: " + result);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("An unexpected error occurred: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
