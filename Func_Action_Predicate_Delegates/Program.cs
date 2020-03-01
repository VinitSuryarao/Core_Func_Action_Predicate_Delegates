using System;

namespace Func_Action_Predicate_Delegates
{
    class Program
    {
        public int _Result;
  


        // Use for Func 
         delegate int Mathamatic(int x, int y);

        // Use for Action
         delegate void DisplayData(string x);

        // Use for Predicate
        delegate bool CheckDigit(int x);

        static void Main(string[] args)
        {
            // Func Delegate is use when funcion returns any values
            // Func Delegates With Anonymous Method
            Mathamatic objAddition = new Mathamatic
                (
                delegate (int x, int y)
                {
                    return x + y;
                }
                );

            int _Result = objAddition(50,60);
            Console.WriteLine("Func with Anonymous Method Addition is " + _Result.ToString());

            // Func Delegates With Lambda Expression
            Func<int, int, int> Addition = (x,y) => x + y;
            _Result = Addition(50, 80);
            Console.WriteLine("Func with Lambda Expression Addition is " + _Result.ToString());


            // *****************************************************************************************************************


            // Action Delegate is use when funcion does not returns any values
            // Actioin Delegates With Anonymous Method
            DisplayData objDisplay = new DisplayData
                (
                delegate (string x)
                {
                    Console.WriteLine( x);
                }
                );

            objDisplay("Action with Anonymous Method");


            // Action Delegates With Lambda Expression
            Action<string> DisplyData = (x) => Console.WriteLine(x); ;
            DisplyData("Action with Lambda Expression");


            // *****************************************************************************************************************

            // Predicate Delegate is use when funcion returns true/false values
            // Predicate Delegates With Anonymous Method
            CheckDigit objCheckOddEven = new CheckDigit
                (
                delegate (int x)
                {
                    return x % 2 == 0;
                }
                );

            bool chkOddEven = objCheckOddEven(15);
            Console.WriteLine("Predicate with Anonymous Method Check Odd Even is " + chkOddEven);


            // Predicate Delegates With Lambda Expression
            Predicate<int> oddEvenCheck = x =>  x % 2 == 0;
            bool oddevenchk = oddEvenCheck(56);
            Console.WriteLine("Predicate with Lambda Expr ession Check Odd Even is " + oddevenchk);



            Console.ReadLine();
        }
    }
}
