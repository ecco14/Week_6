using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_6
{
    class Program
    {
        static void Main(string[] args)
        {
            PostEntry1();
            LetterCount1();
        }

        

        public static void PostEntry1()
        {
            string input = "";

            List<string> poster = new List<string>(); //Instance created

            do
            {

                Console.WriteLine("Please enter a name "); //Self explanatory
                input = Console.ReadLine();
                poster.Add(input);

                int tab = poster.Count();
                switch(tab)                                 //Used a switch statement with the list count as the switch.
                {
                    case 1:                                 //No names entered. Exits the program.

                        break;

                    case 2:
                        Console.WriteLine(poster[0] + " liked your post.");         //1 name entered.
                        break;

                    case 3:
                        Console.WriteLine(poster[0] + " and " + poster[1] + " liked your post. ");     //2 names entered.
                        break;

                    case 4:
                        Console.WriteLine(poster[0] + "," + poster[1] + " and " + tab + " others liked your post "); //3 names entered
                        break;

                    case 5:
                        Console.WriteLine(poster[0] + "," + poster[1] + " and " + tab + " others liked your post "); //4 names entered.
                        break;

                }
               

            } 
            while (input != "");


           


        }
        private static void LetterCount1()
        {
            char userInput = ' ';
            int count = 0;
            string sentence;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            Console.WriteLine("Please enter a sentence and the program will count the characters: ");
            sentence = Console.ReadLine();
             
            

            charCount.Add(userInput, count);
                
             foreach(var character in sentence)
             {
                 if(character !=' ')
                 {
                     if(!charCount.ContainsKey(character))
                     {
                         charCount.Add(character, 1);
                     }

                     else
                     {
                         charCount[character]++;

                     }
                      
                 }

             }

             foreach (var character in charCount)
             {
                 Console.WriteLine("{0} || {1}", character.Key, character.Value);

             }

        }
    }
}
