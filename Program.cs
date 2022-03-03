using System;
using SortingAlgorithems;
namespace CountingArray
{
    class Program
    {

        static void Main(string[] args)
        {
            const int LASTVOTE = -1;
            const int CANDIDATES = 25;
            int[] candidates = new int[CANDIDATES];//כמות הסופרים המתמודדים
            //אתחול כל אחד מהמונים ל-0
            for (int i = 0; i < candidates.Length; i++)
            {
                candidates[i] = 0;
            }
            
            int vote;

            Console.WriteLine("Please Enter First Vote or -1 to end voting");
            vote =int.Parse(Console.ReadLine()) ;
            while(vote!=LASTVOTE)
            {
                candidates[vote - 1]++;

                Console.WriteLine("Enter next Vote and -1 to End");
                vote = int.Parse(Console.ReadLine());

            }
            int winner = SortingHelpers.MaxIndex(candidates, 0, candidates.Length - 1);
            Console.WriteLine($"the winner is {winner+1} and they got {candidates[winner]}");

            
           
        }
    }
}
