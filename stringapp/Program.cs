using System;
using System.Linq;

namespace stringapp
{
    internal class Program
    {
        static void Compare(out bool theSame)
        {
            Console.WriteLine("Compare 2 words\n Please, input 2 words or sentences");
            var fWord = Convert.ToString(Console.ReadLine());
            var sWord = Convert.ToString(Console.ReadLine());

            if (fWord == sWord)
                theSame = true;
            else
                theSame = false;
        }

        static void Analyze()
        {
            Console.WriteLine("Please, input a word or sentence");
            var fWord = Convert.ToString(Console.ReadLine());

            int indexOfLetter = 0;
            int indexOfDigit = 0;
            int indexOfOther = 0;

            for (int i = 0; i < fWord.Length; i++)
            {
                if (char.IsLetter(fWord[i]))
                    indexOfLetter++;
                else if (char.IsDigit(fWord[i]))
                    indexOfDigit++;
                else
                    indexOfOther++;
            }
            Console.WriteLine($"Quantity of letters - {indexOfLetter}\n" +
                $"Quantity of numbers - {indexOfDigit}\n" +
                $"Quantity of other special characters - {indexOfOther}");
        }

        static void Sort() 
        {
            Console.WriteLine("Please, input a word or sentence"); //работает с нижним регистром

            String fWord = Convert.ToString(Console.ReadLine());

            fWord = String.Concat(fWord.OrderBy(ch => ch));

            Console.WriteLine(fWord);
        }

        static void Duplicate()
        {
            Console.WriteLine("Compare 2 words\n Please, input 2 words or sentences");
            var fWord = Convert.ToString(Console.ReadLine());
            var sWord = Convert.ToString(Console.ReadLine());

            for(int i = 0; i < fWord.Length; i++)
                for(int j = 0; j < sWord.Length; j++)
                    if(fWord[i] == sWord[j])
                        Console.Write(fWord[i]+" ");

        }//such realization will return all matches, i.e. the mathed chars will be displayed more than once (in case several matches) - but accroding to home work conditions, the matched char display must be once for every char
        static void Main(string[] args)
        {
            bool theSame;

            Console.WriteLine("Choose the action\n1.Compare\n2.Analyze\n3.Sort\n4.Duplicate");
            int switcher = Convert.ToInt16((Console.ReadLine()));
            switch (switcher)
            {
                case 1:
                    Compare(out theSame);
                    Console.WriteLine(theSame);
                    break;
                case 2:
                    Analyze();
                    break;
                case 3:
                    Sort();
                    break;
                case 4:
                    Duplicate();
                    break;
                default:
                    Console.WriteLine("Input wrong action");
                    break;
            }
        }
    }
}
//checked
