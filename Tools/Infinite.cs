using Enumerations;

namespace Tools
{
    class Infinite
    {
        public static void Infinity(double firstNumber, Operations operation, double secondNumber)
        {
            firstNumber = Numbers.GetResult(firstNumber, operation, secondNumber);
            Texts.ActualNumber(firstNumber);
            Texts.Questions(CalculatorInputType.EnterOperation);
            operation = Numbers.GetOperation();
            Texts.Questions(CalculatorInputType.EnterNumber);
            secondNumber = Numbers.GetNumber();
            Texts.Questions(CalculatorInputType.EnterBool);
            if(Booleans.GetContinueOrNot())
                Infinity(firstNumber, operation, secondNumber);
            else   
                Texts.FinalResult(firstNumber, operation, secondNumber);
        }
    }
}