using System;
using System.Diagnostics.PerformanceData;

namespace PAUL_Lilian_TP1_ST2TRD
{
    public class Exo_2
    {
        public static void Prime()
        {
            for (int i = 1; i <= 1000; i++)
            {
                bool isPrime = true;
                for (int j = 2; j  <= Math.Sqrt(i); j++)
                {
                    
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }

                if (isPrime == true)
                {
                    Console.WriteLine(i + " est un nombre premier");
                }
                
            }
        }
        public static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        public static void Fibo(int a, int b, int i, int number)
        {

                Console.WriteLine(a);
                if (i < number)
                {
                    Fibo(b, a+b, i+1, number);
                }

        }

        public static void Facto(int result ,int a, int number)
        {
            result *= a;
            if (a == number)
            {
               Console.WriteLine(result); 
            }
            else
            {
                Facto(result,a+1,number);
            }
        }
        
        
    }
}