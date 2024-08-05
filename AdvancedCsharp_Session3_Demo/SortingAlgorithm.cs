using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp_Session3_Demo
{
    //public  delegate bool SortFunReferenceDelegate (int L, int R);
    public delegate bool SortFunReferenceDelegate<T>(T L, T R);



    internal class SortingAlgorithm
    {
        #region Bubble Sort Non-Generics
        //public static void BubbleSort(int[] arr, SortFunReferenceDelegate SortFunReference)
        //{
        //    if (arr is not null)
        //    {
        //        //0 =>
        //        for (int i = 0; i < arr.Length; i++)
        //        {

        //            //internal loop if arr.enghth = 4 , 0 => 3 {4,6,3,5}

        //            for (int j = 0; j < arr.Length - 1 - i; j++)
        //            {
        //                if ((SortFunReference.Invoke(arr[j], arr[j + 1])))
        //                {
        //                    Swap(ref arr[j], ref arr[j + 1]);
        //                }

        //            }
        //        }

        //    }
        //} 
        #endregion

        #region Bubble Sort Generics

        public static void BubbleSort<T> (T[] arr, SortFunReferenceDelegate<T> SortFunReference)
        {
            if (arr is not null)
            {
                //0 =>
                for (int i = 0; i < arr.Length; i++)
                {

                    //internal loop if arr.enghth = 4 , 0 => 3 {4,6,3,5}

                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if ((SortFunReference.Invoke(arr[j], arr[j + 1])))
                        {
                            Swap(ref arr[j], ref arr[j + 1]);
                        }

                    }
                }

            }
        }
        private static void Swap<T>(ref T X, ref T Y)
        {
            T temp = X;
            X = Y;
            Y = temp;
        }
        #endregion

        #region int
        public static bool AscSort(int L, int R)
        {
            return (L > R);
        }

        public static bool DescSort(int L, int R)
        {
            return (L < R);
        }
        #endregion


        #region String
        public static bool AscSort(string L, string R)
        {
            return (L.Length > R.Length);
        }

        public static bool DescSort(string L, string R)
        {
            return (L.Length < R.Length);
        } 
        #endregion
        #region Non-Generics Swap
        //private static void Swap(ref int X, ref int Y)
        //{
        //    int temp = X;
        //    X = Y;
        //    Y = temp;
        //} 
        #endregion

    }
}
