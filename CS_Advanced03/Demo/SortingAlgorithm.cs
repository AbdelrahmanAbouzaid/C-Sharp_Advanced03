using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    //delegate bool ConditionDelegate(int x, int y);
    delegate bool ConditionDelegate<T>(T x, T y);
    internal class SortingAlgorithm
    {
        public static void BubbleSort<T>(T[] arr , ConditionDelegate<T> reference)
        {
            if (arr?.Length > 0)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (reference.Invoke(arr[j] , arr[j + 1]))
                            Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
        #region MyRegion
        //public static void BubbleSortAscending(int[] arr)
        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (SortingCondition.IsGreater(arr[j], arr[j + 1]))
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //            }
        //        }
        //    }
        //}
        //public static void BubbleSortDescending(int[] arr)
        //{
        //    if (arr?.Length > 0)
        //    {
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            for (int j = 0; j < arr.Length - i - 1; j++)
        //            {
        //                if (SortingCondition.IsLess(arr[j], arr[j + 1]))
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //            }
        //        }
        //    }
        //} 
        #endregion

        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

    }
}
