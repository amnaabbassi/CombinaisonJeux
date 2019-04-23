using System;

namespace CombinaisonJeux
{
    class Program
    {
        static void Main(string[] args)
        {
            Combinatoire combinatoire = new Combinatoire(26,1,2);

            ulong result = combinatoire.CalculCombinatoire();

            Console.WriteLine("Le nombre de combinaison possible est " + result);
            Console.ReadLine();
        }
        
    }
}
