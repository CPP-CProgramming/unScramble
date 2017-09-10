using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unScramble
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWordUnscramble = true;
            

           
            do
            {
                Console.WriteLine("Please enter the option - F for file and M for Manual");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.WriteLine("Enter scrambled words file name");
                        ExecuteScrambleWordsInFileScenario();
                        break;

                    case "M":
                        Console.WriteLine("Enter scrambled words manually");
                        ExecuteScrambleWordsManualEntryScenario();
                        break;

                    default:
                        Console.Write("Option was not recognized");
                        break;

                    
                }

                var continueWordUnscrambleDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue? Y/N");
                    continueWordUnscrambleDecision = (Console.ReadLine() ?? string.Empty);
                } while (!continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase) && !continueWordUnscrambleDecision.Equals("N", StringComparison.OrdinalIgnoreCase));

                continueWordUnscramble = continueWordUnscrambleDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);
        }

        private static void ExecuteScrambleWordsInFileScenario()
        {
            throw new NotImplementedException();
        }
        private static void ExecuteScrambleWordsManualEntryScenario()
        {
            throw new NotImplementedException();
        }
    }
}
