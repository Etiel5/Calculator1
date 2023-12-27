using Tools;
using Enumerations;

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
            Texts.Questions(CalculatorInputType.EnterBool);
            if(Booleans.GetContinueOrNot())
            {
                Infinite.Infinity(firstNumber, operation, secondNumber);
            }
            else
                Texts.FinalResult(firstNumber, operation, secondNumber);
        }
    }
}