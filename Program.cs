using System;

namespace CodeWars
{
    class Program
    {

        public static void Main(string[] args)
        {
           

        }

        public static string SpinWords(string sentence)
        {
            string sentence1 = sentence;
            string reverse = "";

            for (int i = sentence1.Length - 1; i >= 0; i--)
            {
                reverse += sentence1[i];
            }

            return reverse;
        }

        



    }
}
