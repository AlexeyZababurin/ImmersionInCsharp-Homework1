namespace homework
{
    class Calculator
    {
        static void Main(string[] args)
        {

            double number1;
            double number2;
            double result;
            char operation;

            Console.Write("Enter the first number: ");
            number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the operation: ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter the second number: ");
            number2 = Convert.ToDouble(Console.ReadLine());

            if (operation == '+')
            {
                result = number1 + number2;
                Console.WriteLine($"{number1} + {number2} = {result}");
            }

            else if (operation == '-')
            {
                result = number1 - number2;
                Console.WriteLine($"{number1} - {number2} = {result}");
            }

            else if (operation == '*')
            {
                result = number1 * number2;
                Console.WriteLine($"{number1} * {number2} = {result}");
            }

            else if (operation == '/')
            {
                if (number2 == 0)
                {
                    Console.WriteLine("You can't divide by zero");
                }
                else
                {
                    result = number1 / number2;
                    Console.WriteLine($"{number1} / {number2} = {result}");
                }
            }
            else
            {
                Console.WriteLine("Unknown operation");
            }
        }
    }
}
