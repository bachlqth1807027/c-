using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = "Aptech Computer Center"; 
            string word;
            int strt = 0;
            int cnt = -1;
            int idx = -1;
            
            Console.WriteLine("Enter a String \n" + st);
            Console.WriteLine("Enter a word to search");
            word = Console.ReadLine();
            
            while (strt != -1)
            {
                strt = st.IndexOf(word, idx + 1);
                cnt += 1;
                idx = strt;
            }
            Console.Write("Word  '{0}' found " + cnt + " time in the string.\n", word);  

            Console.ReadKey();
        }
    }
}