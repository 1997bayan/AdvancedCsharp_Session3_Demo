using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedCsharp_Session3_Demo
{
    internal class ConditionalFunctions

    {
        public static bool CheckOdd(int Number)
        {
            return Number % 2 == 1;
        }

        public static bool CheckEven(int Number)
        {
            return Number % 2 == 0;
        }

        public static bool CheckDivisableBySeven(int Number)
        {
            return Number % 7 == 0;
        }

        public static bool CheckStringLength (string word)
        {
            return word?.Length > 4;
        }



    }
}
