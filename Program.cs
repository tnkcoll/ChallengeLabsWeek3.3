using System.Dynamic;

namespace ChallengeLabsWeek3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] indicies = new int[2];

            string numbers = GetIntegersFromUser();
            double target = GetTargetFromUser();
            indicies = AnalyzeNumbers(numbers, target);

            if (indicies[0] == 0 && indicies[1] == 0)
            {
                Console.WriteLine("No two numbers added up to the target.");
            }
            else if(indicies[0] != 0 || indicies[1] != 0)
            { 
                Console.WriteLine($"The target was reached! The indicies of the 2 numbers are {indicies[0]} and {indicies[1]}");
            }
        }

        static string GetIntegersFromUser()
        {
            string numbers = "";
            Console.WriteLine("This program get a series of numbers from the user as well as a target number. It will check to see if 2 digits from the numbers can add up to the target.");
            do
            {
                Console.WriteLine("Enter a series of numbers.");
                numbers = Console.ReadLine();
            }while (numbers == "");

            return numbers;
        }

        static int GetTargetFromUser()
        {
            string target = "";
            do
            {
                Console.WriteLine("Enter a target number.");
                target = Console.ReadLine();
            } while (target == "");

            return Convert.ToInt32(target);
        }

        static int[] AnalyzeNumbers(string numbers, double target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                double num1 = char.GetNumericValue(numbers[i]);

                for(int j = i + 1; j < numbers.Length; j++)
                {
                    double num2 = char.GetNumericValue(numbers[j]);

                    if ((num1 + num2) == target)
                    {
                        int[] indicies = { i, j };
                        return indicies;
                    }
                }
            }
            int[] noIndicies = { 0, 0 };
            return noIndicies;
        }
    }
}
