namespace Session05
{
    internal class Program
    {

        #region Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
        public static void AddValToNum(int Num)
        {
            Num += 10;
        }

        //When a variable is passed by value to a function, a copy of the actual value is passed.
        //This means that the function works with the copy,
        //and any changes made to the variable inside the function do not affect the original variable outside the function.
        public static void AddValToNum(ref int Num)
        {
            Num += 10;
        }

        //When a variable is passed by Ref to a function, address or place of variable in stack is passed.
        //This means that the function works with the variable place ,
        //and any changes made to the variable inside the function will affect the original variable outside the function.
        #endregion

        #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
        public static void ModifyValueOfArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 10;
            }
            Console.WriteLine("Inside Function :  ");
            for (int i = 0;i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} "); //11 12 13 14 15
            }
        }
        //When a numbers is passed by value to a function, numbers store address of object that in heap , this address is passed.
        //This means that the function works with address => arr refer to the same object ,
        //and any changes made to the object inside the function Will affect outside the function. => because 2 Array (Numbers , arr) refer to the same object.

        public static void ModifyValueOfArr(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += 10;
            }
            Console.WriteLine("Inside Function :  ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} "); //11 12 13 14 15
            }
        }
        //When a numbers is passed by ref to a function, The reference is passed. (Arr = numbers)
        //This means that the function works with address => arr refer to the same object ,
        //and any changes made to the object inside the function Will affect outside the function. => because 2 Arr refer to the same object.
        #endregion

        #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
        //public static void SumAndSubForTwoNum(int num1 , int num2 ,out int Sum ,out int Sub)
        //{
        //    Sum = num1 + num2;
        //    Sub = num1 - num2;
        //}
        #endregion

        #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number
        //public static int SumDigits(int num)
        //{
        //    string Number = num.ToString();
        //    int sum = 0;
        //    for (int i = 0;i < Number.Length;i++)
        //    {
        //        int.TryParse(Number[i].ToString(), out int Digit);
        //        sum += Digit;
        //    }
        //    return sum;
        //}
        #endregion

        #region Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
        //public static bool IsPrime(int num)
        //{
        //    if (num <= 1)
        //        return false;
        //    else
        //    {
        //        for(int  i = 2; i <= Math.Sqrt(num); i++)
        //        {
        //            if(num % i == 0)
        //                return false;
        //        }
        //    }
        //    return true;
        //}

        #endregion

        #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
        //public static void MaxMinArray (int[] arr , out int Max , out int Min)
        //{
        //    Max = arr.Max();
        //    Min = arr.Min();
        //}
        #endregion

        #region Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
        //public static int Factorial(int Num)
        //{
        //    int fact = 1;
        //    for(int i = 1; i <= Num; i++)
        //    {
        //        fact *= i;
        //    }
        //    return fact;
        //}

        #endregion

        #region Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
        //public static void ChangeChar(ref string str , int index , char ReplacedChar)
        //{
        //    for(int i = 0; i < str.Length; i++)
        //    {
        //        if (i == index)
        //        {
        //            char ch = str[i];
        //            str = str.Replace(ch , ReplacedChar);
        //        }
        //    }
        //}
        //// Use passing by Ref => String Create new Object because modification 
        //// New Address assign 2 string (Name , Str ) 
        //// Mohammed is Unreachable .
        #endregion


        static void Main(string[] args)
        {
            ///int x = 10;
            ///AddValToNum (x);
            ///Console.WriteLine(x);
            ///AddValToNum(ref x);
            ///Console.WriteLine(x);

            ///int[] arr01 = { 1, 2, 3, 4, 5 };
            ///ModifyValueOfArr(arr01);
            ///Console.WriteLine("Outside Function :  ");
            ///for (int i = 0; i < arr01.Length; i++)
            ///{
            ///    Console.Write($"{arr01[i]} ");  //11 12 13 14 15
            ///}
            ///ModifyValueOfArr(ref arr01);
            ///Console.WriteLine("Outside Function :  ");
            ///for (int i = 0; i < arr01.Length; i++)
            ///{
            ///    Console.Write($"{arr01[i]} ");  //11 12 13 14 15
            ///}

            ///int x = 10;
            ///int y = 4;
            ///int sum ,sub;
            ///SumAndSubForTwoNum(x, y, out sum, out sub);
            ///Console.WriteLine(sum);
            ///Console.WriteLine(sub);

            //Console.WriteLine(SumDigits(25)); // 7

            //Console.WriteLine(IsPrime(9));  // false
            ///int[] arr = { 5, 10, 2, 4 };
            ///int Max;
            ///int Min;
            ///MaxMinArray(arr, out Max, out Min);
            ///Console.WriteLine(Max);
            ///Console.WriteLine(Min);

            //Console.WriteLine(Factorial(5)); //120

            ///string Name = "mohammed"; // Unreachable
            ///Console.WriteLine(Name);
            ///ChangeChar(ref Name, 2, 'N');
            ///Console.WriteLine(Name);
        }
    }
}
