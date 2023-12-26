using System.Text;
using Enumerations;

namespace Tools
{
    class Texts
    {
        public static void Welcome()
        {
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
            }
            Console.WriteLine(stringBuilder);
        }
    }
}