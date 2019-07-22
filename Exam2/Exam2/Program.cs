using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string st; //khai bao chuoi ban dau
            string word; //khai bao chuoi con can tim
            int strt = 0;
            int cnt = -1;
            int idx = -1;
            
            Console.WriteLine("Enter a String");
            st = Console.ReadLine();
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