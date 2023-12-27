using Enumerations;

namespace Tools
{
    class Booleans
    {
        public static bool GetContinueOrNot()
        {
            ContinueOrNot answer;
            while(true)
            {
                if(Enum.TryParse<ContinueOrNot>(Console.ReadLine(), out answer))
                {
                    if(Enum.IsDefined(typeof(ContinueOrNot), answer))
                        break;
                }

                Texts.Questions(CalculatorInputType.EnterBool);
            }

            if(answer == ContinueOrNot.Yes)
                return true;
            else
                return false;
        }
    }
}