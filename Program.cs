using Tools;
using Enumerations;
using System.Security.Claims;

namespace Calculator
{
    class Calculator
    {
        static void Main()
        {
            Texts.Welcome();
            Texts.Questions(CalculatorInputType.EnterNumber);
            double firstNumber = Numbers.GetNumber();
            Texts.Questions(CalculatorInputType.EnterOperation);
            Operations operation = Numbers.GetOperation();
            Texts.Questions(CalculatorInputType.EnterNumber);
            double secondNumber = Numbers.GetNumber();
            Texts.Result(firstNumber, operation, secondNumber);
        }
    }
}