using System;

namespace PAUL_Lilian_TP1_ST2TRD
{
    internal static class Tp1
    {
        public static void Main(string[] args)
        {
            int AskUserForParameter()
            {
                Console.WriteLine("Please write a number and press enter :");
                int.TryParse(Console.ReadLine(), out var result);
                return result;
            }

            void MultiplicationTable()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Table des :"  + i);
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine(i + " * " + j + " = " + i*j);
                    }
                    
                }
                
            }

            void TableImpair()
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Table des :"  + i);
                    for (int j = 1; j <= 10; j++)
                    {
                        if ((i * j) % 2 != 0)
                        {
                            Console.WriteLine(i + " * " + j + " = " + i*j);   
                        }
                        
                    }
                    
                }
                
            }

            void Table(int number)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(number + " * " + i + " = " + number*i);
                }
            }
            void Selecteur()
            {
                var result = 0;
                while (result != 10)
                {
                    result = 0;
                    
                    while ((result > 10) | (result < 1))
                    {
                        Console.WriteLine("Veuillez choisir un exercice");
                        Console.WriteLine("1 : Table de multiplication");
                        Console.WriteLine("2 : Table N");
                        Console.WriteLine("3 : Table avec résultats impaires");
                        Console.WriteLine("4 : Prime");
                        Console.WriteLine("5 : Fibo");
                        Console.WriteLine("6 : Facto");
                        Console.WriteLine("7 : Try_catch");
                        Console.WriteLine("8 : Square");
                        Console.WriteLine("9 : ChristmasTree");
                        Console.WriteLine("10 : Exit");
                        int.TryParse(Console.ReadLine(), out result);
                    }
                    
                    switch (result)
                    {
                        case 1:
                            MultiplicationTable();
                            break;
                        case 2:
                            Table(AskUserForParameter());
                            break;
                        case 3:
                            TableImpair();
                            break;
                        case 4:
                            Exo_2.Prime();
                            break;
                        case 5:
                            Exo_2.Fibo(0, 1, 1, AskUserForParameter());
                            break;
                        case 6:
                            Exo_2.Facto(1, 1, AskUserForParameter());
                            break;
                        case 7:
                            Exo_3.Try_Catch(-3, 3);
                            break;
                        case 8:
                            Exo_4.Square();
                            break;
                        case 9:
                            Exo_5.ChristmasTree();
                            break;
                    }
                    
                }
            }
            Selecteur();
            

        }
    }
}