using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithems
{
    public class SortingHelpers

    {
        /// <summary>
        /// פעולה המחזירה את המיקום המקסימלי במערך
        /// בין שני מיקומים
        /// הנחות יסוד: 
        /// start<=end
        /// start>=0
        /// end<=arr.Length-1
        /// </summary>
        /// <param name="arr"> מערך מספרים</param>
        /// <param name="start">מיקום ממנו להתחיל לחפש</param>
        /// <param name="end"> מיקום האחרון לחיפוש</param>
        /// <returns>מיקום של הערך המקסימלי במערך</returns>
        public static int MaxIndex(int[] arr, int start, int end)
        {
            int maxindex = start;
            int maxvalue = arr[start];
            for (int i = start + 1; i <= end; i++)
            {
                if (arr[i] > maxvalue)
                {
                    maxvalue = arr[i];
                    maxindex = i;
                }
            }
            return maxindex;
        }

        /// <summary>
        /// פעולה המחזירה את המיקום המינימלי במערך
        /// בין שני מיקומים
        /// הנחות יסוד: 
        /// start<=end
        /// start>=0
        /// end<=arr.Length-1
        /// </summary>
        /// <param name="arr"> מערך מספרים</param>
        /// <param name="start">מיקום ממנו להתחיל לחפש</param>
        /// <param name="end"> מיקום האחרון לחיפוש</param>
        /// <returns>מיקום של הערך המינימלי במערך</returns>
        public static int MinIndex(int[] arr, int start, int end)
        {
            int minindex = start;
            int minvalue = arr[start];
            for (int i = start + 1; i <= end; i++)
            {
                if (arr[i] < minvalue)
                {
                    minvalue = arr[i];
                    minindex = i;
                }
            }
            return minindex;
        }

        /// <summary>
        /// פעולה המקבלת מערך ומחליפה את הערכים בין התאים 
        /// i, j
        /// </summary>
        /// <param name="arr">מערך מספרים שלמים</param>
        /// <param name="i"> מיקום התא הראשון</param>
        /// <param name="j">מיקום התא השני</param>
        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        /// <summary>
        /// פעולה המזיזה את הערכים שמאלה בין שני מיקומים
        /// </summary>
        /// <param name="arr">מערך מספרים שלמים</param>
        /// <param name="from">נקודת התחלה של ההזזה</param>
        /// <param name="to">נקודת סיום של ההזה</param>
        public static void Shift(int[] arr, int from, int to)
        {
            for (int i = from; i > to; i--)
            {
                arr[i] = arr[i - 1];
            }
        }

        /// <summary>
        /// חיפוש בינארי במערך
        /// אריה במדבר
        /// </summary>
        /// <param name="arr">מערך ממוין</param>
        /// <param name="x">הערך לחיפוש</param>
        /// <returns>אמת אם נמצא שקר אחרת</returns>
        public static bool BinarySearch(int[] arr, int x)
        {
            int left = 0, right = arr.Length - 1,middle;

            while(left<=right)
            {
                middle = (left + right) / 2;
                if (arr[middle] == x)
                    return true;
                if(x>middle)
                {
                    left = middle + 1;

                }
                else
                {
                    right = middle - 1;
                }

            }

            return false;


        }

    }
}
