using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp_Session3_Demo
{


    
    //public delegate bool ConditionalFuncDelegate(int Number);
    public delegate bool ConditionalFuncDelegate<T>(T Number);
    internal static class Helper
    {
        //public static List <int> GetNumbersBasedOnPassedFunction (List<int> numbers , ConditionalFuncDelegate condition )
        //{

        //    List<int> result = new List<int>();
        //    if (numbers is not null && condition is not null )
        //    {
        //        for (int i = 0; i < numbers.Count; i++)
        //            //if (condition?.Invoke(numbers[i]) == true)
        //            //OR use syntax suger and check above if condition is not null
        //            if (condition(numbers[i]))
        //                  result.Add(numbers[i]);
        //                    return result;
        //    }
        //    return result; // if numbers is Null it will return empty result
        //}


        public static List<T> GetElementsBasedOnPassedFunction <T>(List<T> Elements, ConditionalFuncDelegate<T> condition)
        {

            List<T> result = new List<T>();
            if (Elements is not null && condition is not null)
            {
                for (int i = 0; i < Elements.Count; i++)
                    //if (condition?.Invoke(numbers[i]) == true)
                    //OR use syntax suger and check above if condition is not null
                    if (condition(Elements[i]))
                        result.Add(Elements[i]);
                return result;
            }
            return result; // if numbers is Null it will return empty result
        }



    }
}
