using System.Text;
using Enumerations;

namespace Tools
{
    class Texts
    {
        public static void Welcome()
        {
            Console.Clear();
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Welcome to this program.");
            stringBuilder.Append("Calculator");
            Console.WriteLine(stringBuilder);
            Console.Read();
        }
        public static void Questions(CalculatorInputType num)
        {
            Console.Clear();
            var stringBuilder = new StringBuilder();
            switch(num)
            {
                case CalculatorInputType.EnterNumber:
                    stringBuilder.AppendLine("Insert a number.");
                    break;
                
                case CalculatorInputType.EnterOperation:
                    stringBuilder.AppendLine("Choose one operation:");
                    stringBuilder.AppendLine("1. Sum");
                    stringBuilder.AppendLine("2. Subtraction");
                    stringBuilder.AppendLine("3. Multiplication");
                    stringBuilder.AppendLine("4. Division");
                    break;
                case CalculatorInputType.EnterBool:
                    stringBuilder.AppendLine("Do you want to continue?");
                    stringBuilder.AppendLine("1. Yes");
                    stringBuilder.AppendLine("2. No");
                    break;
            }
            Console.WriteLine(stringBuilder);
        }
        public static void FinalResult(double firstNumber, Operations operation, double secondNumber)
        {
            Console.Clear();
            var stringBuilder = new StringBuilder();
            double result = Numbers.GetResult(firstNumber, operation, secondNumber);

            switch (operation)
            {
                case Operations.Sum:
                stringBuilder.AppendLine($"The result of {firstNumber} plus {secondNumber} is {result}");
                    break;
                case Operations.Subtraction:
                    stringBuilder.AppendLine($"The result of {firstNumber} minus {secondNumber} is {result}");
                    break;
                case Operations.Multiplication:
                    stringBuilder.AppendLine($"The result of multiplying {firstNumber} by {secondNumber} is {result}");
                    break;
                case Operations.Division:
                    stringBuilder.AppendLine($"The result of {firstNumber} divided by {secondNumber} is {result}");
                    break;
            }

            Console.WriteLine(stringBuilder);
        }
        public static void ActualNumber(double firstNumber)
        {
            Console.Clear();
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"The actual number is: {firstNumber}");
            Console.WriteLine(stringBuilder);
            Console.Read();
        }
    }
}