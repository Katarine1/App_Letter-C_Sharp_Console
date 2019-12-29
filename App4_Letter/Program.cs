using System;
using App4_Letter.Model;

namespace App4_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\t# -- Letter -- #\n");
            Letters letter = new Letters();
            Console.Write("\t\tEnter a Phrase: ");
            string name = Console.ReadLine();
            string letters = letter.LetterA(name);
            Console.WriteLine("\t\t" + letters + "\n\n");
        }
    }
}
