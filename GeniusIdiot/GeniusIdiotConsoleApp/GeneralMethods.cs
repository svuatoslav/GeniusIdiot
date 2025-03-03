namespace GeniusIdiotConsoleApp
{
    public static class GeneralMethods
    {
        public static void ShuffleList<T>(List<T> list)
        {
            Random rnd = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static int CheckInt(string text, bool limiter)
        {
            int answer = 0;
            if (limiter)
            {
                while (!int.TryParse(text, out answer))
                {
                    Console.WriteLine("Пожалуйста, введите целое число!");
                    text = Console.ReadLine();
                }
            }
            return answer;
        }
    }
}