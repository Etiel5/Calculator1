using Enumerations;

namespace Tools
{
    class Numbers
    {
        public static int GetNumber()
        {
            int number;
            while(!int.TryParse(Console.ReadLine(), out number))
            {
                Texts.Questions(CalculatorInputType.EnterNumber);
            }
            return number;
        }
        public static CalculatorInputType GetOperation()
        {
            CalculatorInputType operation;
            
            while(true)
            {
                if(Enum.TryParse<CalculatorInputType>(Console.ReadLine(), out operation))
                {
                    if(Enum.IsDefined(typeof(CalculatorInputType), operation))
                        break;
                }

                Texts.Questions(CalculatorInputType.EnterOperation);
            }

            return operation;
        }
    }
}