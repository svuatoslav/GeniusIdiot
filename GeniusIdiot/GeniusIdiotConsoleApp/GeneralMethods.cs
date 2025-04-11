using System;
using System.Xml;

namespace GeniusIdiotConsoleApp
{
    public static class GeneralMethods
    {
        public static void ShuffleList<T>(List<T> list)
        {
            var rnd = new Random();
            var n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static int CheckInt(string? text, bool limiter, string errorMessage = "Пожалуйста, введите целое число!")
        {
            int answer = 0;
            if (limiter)
            {
                while (!int.TryParse(text, out answer))
                {
                    Console.WriteLine(errorMessage);
                    text = Console.ReadLine();
                }
            }
            return answer;
        }
        public static int CheckInt(string? text, string errorMessage = "Пожалуйста, введите целое число!")
        {
            int answer;

            while (!int.TryParse(text, out answer))
            {
                Console.WriteLine(errorMessage);
                text = Console.ReadLine();
            }

            return answer;
        }
        public static double CheckDouble(string? text, string errorMessage = "Пожалуйста, введите число!")
        {
            double answer;

            while (!double.TryParse(text, out answer))
            {
                Console.WriteLine(errorMessage);
                text = Console.ReadLine();
            }

            return answer;
        }
        public static T CheckNumber<T>(string? text, string errorMessage = "Пожалуйста, введите число!") 
            where T : IParsable<T> // probloms if string ?
        {
            T? result;

            while (!T.TryParse(text, null, out result))
            {
                Console.WriteLine(errorMessage);
                text = Console.ReadLine();
            }

            return result;
        }
    }
}