using System.Collections.Concurrent;
using System.Threading.Channels;

namespace AdvancedCsharp_Session3_Demo
{
    internal class Program
    {

        public delegate int StringsFuncDelegate (string str);
        static void Main(string[] args)
        {
            #region Delegate Ex01

            // Syntax Sugar to Declare Reference From Type StringsFuncDelegate [Delegate]
            StringsFuncDelegate X = StringsFunctions.GetCountOfUpperCaseChar;

            //Full Syntax to Declare Reference From Type StringsFuncDelegate [Delegate]
            StringsFuncDelegate reference = new StringsFuncDelegate (StringsFunctions.GetCountOfUpperCaseChar);

            // Add another method to the delegate
            reference += StringsFunctions.GetCountOfLowerCaseChar;




            // Syntax Sugar [without invoke];
            // int Result =reference.Invoke("BaYan");
            int Result = reference("BaYan");


            Console.WriteLine(Result);



            #endregion

            #region Delegate Ex02
            //int[] numbers = { 56, 88, 3, 4 };
            //SortingAlgorithm.BubbleSort(numbers , SortingAlgorithm.DescSort);
            //foreach (int i in numbers) { Console.Write(i + " "); }


            //string[] Names = { "Bo", "Ahmed", "Sara" };
            //SortingAlgorithm.BubbleSort<string>(Names , SortingAlgorithm.DescSort);
            //Console.WriteLine();
            //foreach (string i in Names) { Console.Write(i + " "); }





            #endregion

            #region Delegate EX03

            //List<int> Numbers = Enumerable.Range(0, 100).ToList();

            //List<int> OddNumbers = Helper.GetNumbersBasedOnPassedFunction(Numbers , ConditionalFunctions.CheckOdd);
            //Console.WriteLine("ODD numbers");
            //foreach (int i in OddNumbers) { Console.Write(i + " "); }
            #endregion

            #region Delegate EX03 With Generics

            //List<string> Names2 =new List<string>() { "Lylaa","Bayan", "Aya", "Ali", "SOSO" };

            //List<string> Result1 = Helper.GetElementsBasedOnPassedFunction<string>(Names2, ConditionalFunctions.CheckStringLength);

            //foreach (string name in Result1)
            //{
            //    Console.WriteLine(name);
            //}




            #endregion


            #region Built-in Delegate
            Predicate<int> Predicate; // This is Ref for function take one paramenter (int) and return bool;
            //Predicate = TestingFunctions.Test01;
            //Anonymous Founction
            Predicate = delegate (int x) { return x > 0; };
            Console.WriteLine($"Anonymous Methods : {Predicate.Invoke(10)}"); // Syntax Suger

            //Func<> DELEGATE

            Func<int, string> Func; // This is Can refer to function take  one paramenter (int) and return String
            Func =    (x) => x.ToString();// using FatArrow. (Parameter) => (Return).
            Console.WriteLine(Func.Invoke(5));

            Action action;
            action = TestingFunctions.Test03;
            action();

            Action<string> action1;
            action1 = TestingFunctions.Test04;
            action1("Bayan");
            #endregion


            #region New Feature At Delgate C#10

            Predicate<int> predicate2 = (X) => X > 0;
            //Using Var without define Data type but then we should define dataType of the parameter.
            var predicate = (int X) => X > 0;
            Func<int, string> Func2 = (X) => X.ToString();
            Action action2 = () => Console.WriteLine("Hello");





            #endregion

            #region List- Method that taked functions as parameter.

            //First Way:
            //List<int> OddNumber = Helper.GetElementsBasedOnPassedFunction(Numbers3, ConditionalFunctions.CheckOdd);
            //Second way: Anonyous function

            //List<int> OddNumber = Helper.GetElementsBasedOnPassedFunction(Numbers3, delegate (int x) { return x % 2 != 0; });
            //Third Way lamda expression: The easiest way.
            //List<int> OddNumber = Helper.GetElementsBasedOnPassedFunction(Numbers3, (X) => X % 2 != 0 );

            /*Using Methods*/

            List<int> Numbers3 = Enumerable.Range(1, 100).ToList();
            //FindAll : Retrive all elements that match the condition :  Number % 2 == 1.
            //List<int> OddNumber = Numbers3.FindAll((Number) => Number % 2 == 1);
            ////FindAll : Retrive the first element that match the condition :  Number % 2 == 1.
            //int OddNumber01 = Numbers3.Find((Number) => Number % 2 == 1);
            //foreach (int number in OddNumber) { Console.Write($"{number} "); }
            //Console.WriteLine("\n==================");
            //Console.WriteLine(OddNumber01);

            //Console.WriteLine("\n==================");
            //Numbers3.FindIndex();
            //Numbers3.FindLastIndex();
            //Numbers3.ForEach(Number => Number += 10); // InVALID : ForEach Dont change in the data.

            /* RemoveAll : Remove all numbers match the condition and return the count of numbers that removed*/
            int Count = Numbers3.RemoveAll ( Number => Number % 5 == 0 );
            //foreach(int x in Numbers3)
            //{
            //    Console.Write(x);
            //}
            Console.WriteLine("\n==================");

            Console.WriteLine(Count);


            #endregion


        }
    }

    class TestingFunctions
    {
        //public static bool Test01 (int x)
        //{
        //    return x > 0; 
        //}

        //public static string Test02(int x)
        //{
        //    return x.ToString();
        //}

        public static void Test03()
        {
            Console.WriteLine("Hello");
        }
        public static void Test04( string Name)
        {
            Console.WriteLine($"Hello {Name}");
        }
    }



    public class StringsFunctions()
    {
        //Method to Get count uppercase characters  in String.
        public static int GetCountOfUpperCaseChar(string Word) 
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word))
            {
                for (int i = 0; i < Word.Length; i++) 
                {
                    if (char.IsUpper(Word[i]))
                    {
                        count++;
                    }
                }

            }
            return count; 
        }

        //Method to Get count LoweCase characters  in String.
        public static int GetCountOfLowerCaseChar (string Word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word))
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    if (char.IsLower(Word[i]))
                    {
                        count++;
                    }
                }

            }
            return count;
        }

    }
}
