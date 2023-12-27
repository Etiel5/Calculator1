using Enumerations;

namespace Tools
{
    class Numbers
    {
        public static double GetNumber()
        {
            double number;
            while(!double.TryParse(Console.ReadLine(), out number))
            {
                Texts.Questions(CalculatorInputType.EnterNumber);
            }
            return number;
        }
        public static Operations GetOperation()
        {
            Operations operation;

            while(true)
            {
                if(Enum.TryParse<Operations>(Console.ReadLine(), out operation))
                {
                    if(Enum.IsDefined(typeof(Operations), operation))
                        break;
                }

                Texts.Questions(CalculatorInputType.EnterOperation);
            }

            return operation;
        }
        public static double GetResult(double firstNumber, Operations operation, double secondNumber)
        {
            double result = 0;
            switch(operation)
            {
                case Operations.Sum:
                    result = firstNumber + secondNumber;
                    break;
                case Operations.Subtraction:
                    result = firstNumber - secondNumber;
                    break;
                case Operations.Multiplication:
                    result = firstNumber * secondNumber;
                    break;
                case Operations.Division:
                    result = firstNumber / secondNumber;
                    break;
            }

            return result;
        }
    }
}