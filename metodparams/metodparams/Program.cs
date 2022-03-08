using System;

namespace metodparams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1


            int math= division (15,5);
            Console.WriteLine(math );
            
            #endregion
        }
        static int division (int num1, int num2)
        {
            return num1/num2;
        }
    }
}
