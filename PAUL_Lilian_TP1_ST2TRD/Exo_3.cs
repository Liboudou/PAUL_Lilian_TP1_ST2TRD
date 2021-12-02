using System;

namespace PAUL_Lilian_TP1_ST2TRD
{
    public class Exo_3
    {
        public static void Try_Catch(int born1, int number)
        {
            
            int PowerFunction(int x)
            {
                return (int)(Math.Pow(x, 2) -4);
            }
            for (int i = born1 ; i <= number; i++)
                try
                {
                    int oui = 10/ PowerFunction(i);
                    Console.WriteLine(oui);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("error pour x = " + i);
                    
                }
            
        }
            
        
    }
}