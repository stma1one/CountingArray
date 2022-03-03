using System;
using SortingAlgorithems;
namespace CountingArray
{
    class Program
    {
        /// <summary>
        /// בתחרות כוכב נולד מתמודדים 25 זמרים.
        /// הזוכה הוא הזמר.ת שקיבלה הכי הרבה קולות מהקהל.
        /// הקהל מצביע באמצעות בחירה במספר מתמודד
        /// (ערכים בין 1-25)
        /// כאשר מינוס 1 מסמן סיום קליטת הצבעות מהקהל
        /// כתבו תוכנית הקולטת את הצבעות הקהל לזמרים השונים
        /// בסיום התוכנית תדפיס את מספר הזמר הזוכה וכמות הקולות שקיבל.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            const int LASTVOTE = -1;//זקיף לסיום קלט
            const int CANDIDATES = 25;//כמות הזמרים
            #region אם היה רק מועמד אחד
            //int candidate;
            #endregion
            
            int[] candidates = new int[CANDIDATES];//אנחנו צריכים מונה לכל זמר (כל תא מייצג קאונטר של זמר מסוים)

            #region אם היה רק מועמד אחד -אתחול
            //candidate=0;
            #endregion

            //אתחול כל אחד מהמונים ל-0
            for (int i = 0; i < candidates.Length; i++)
            {
                candidates[i] = 0;
            }
            
            int vote;//הצבעה
            //נקלוט את ההצבעה הראשונה
            Console.WriteLine("Please Enter First Vote or -1 to end voting");
            vote =int.Parse(Console.ReadLine()) ;
            //כל עוד לא הגענו לסוף הקלט
            while(vote!=LASTVOTE)
            {

                //נעדכן את המונה של המועמד ב+1
                #region אם היה רק מועמד אחד
                //candidate++;
                #endregion

                candidates[vote - 1]++;

                //נקלוט את ההצבעה הבאה
                Console.WriteLine("Enter next Vote and -1 to End");
                vote = int.Parse(Console.ReadLine());

            }
            //נמצא את מספר הזמר הזוכה 
            //זה מספר התא שבו נמצא כמות ההצבעות המקסימלית
            int winner = SortingHelpers.MaxIndex(candidates, 0, candidates.Length - 1);
            //מכיון שתא מספר 0 מייצג את הזמר שהקוד שלו 1 ותא מספר 24 מייצג את הזמר שהקוד שלו 25, בהדפסה נוסיף 1 על מנת להדפיס 
            //את קוד הזמר כפי שהמצביעים מכירים
            Console.WriteLine($"the winner is {winner+1} and they got {candidates[winner]}");

            
           
        }
    }
}
