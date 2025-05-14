namespace GeniusIdiot.Common
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

        public static int? CheckInt(string? text, ref bool limiter, IMessage message, string errorMessage = "Пожалуйста, введите целое число!")
        {
            if (limiter)
            {
                int answer;

                while (!int.TryParse(text, out answer))
                {
                    message.Write(errorMessage);
                    text = message.Read();
                }

                return answer;
            }
            else
                return null;
        }
        public static int CheckInt(string? text, IMessage message, string errorMessage = "Пожалуйста, введите целое число!")
        {
            int answer;

            while (!int.TryParse(text, out answer))
            {
                message.Write(errorMessage);
                text = message.Read();
            }

            return answer;
        }
        public static double CheckDouble(string? text, IMessage message, string errorMessage = "Пожалуйста, введите число!")
        {
            double answer;

            while (!double.TryParse(text, out answer))
            {
                message.Write(errorMessage);
                text = message.Read();
            }

            return answer;
        }
        public static T CheckNumber<T>(string? text, IMessage message, string errorMessage = "Пожалуйста, введите число!")
            where T : IParsable<T> // probloms if string ?
        {
            T? result;

            while (!T.TryParse(text, null, out result))
            {
                message.Write(errorMessage);
                text = message.Read();
            }

            return result;
        }
    }
}