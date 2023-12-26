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
            int firstNumber = Numbers.GetNumber();
            Texts.Questions(CalculatorInputType.EnterOperation);
            CalculatorInputType operation = Numbers.GetOperation();
            Texts.Questions(CalculatorInputType.EnterNumber);
            int secondNumber = Numbers.GetNumber();
        }
    }
}