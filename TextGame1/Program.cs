using System;

namespace TextGame1
{
    class Program
    {
        public static List<string> positiveAnswers = new List<string> { "yes", "yessir", "yes'm", "affirmative", "yeah", "ye", "sure", "i guess so", "sure why not", "certainly", "yesh", "of course", "decidedly so", "uh huh" };
        public static List<string> negativeAnswers = new List<string> { "no", "nada", "negative", "three", "probably not", "no way", "certainly not", "yeah right", "absolutely not", "no way jose" };
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write(".");
            Thread.Sleep(100);
            Console.Write("Should I call you Jimmy?");
            string response = Console.ReadLine() ?? string.Empty;
            response = response.Trim();

            CheckResponse(response.ToLower());
        }

        public static bool CheckResponse(string response)
        {
            bool isPositive = false;

            if (positiveAnswers.Contains(response))
            {
                Console.WriteLine("Excellent. That's what we like to hear!");
                isPositive = true;
            }
            else if (positiveAnswers.Contains(response))
            {
                Console.WriteLine("Oh. Well that's too bad...");
            }
            else
            {
                Console.WriteLine("Hmmm. Well that's not the response I expected.");
            }

            return isPositive;
        }

        

        
    }
}