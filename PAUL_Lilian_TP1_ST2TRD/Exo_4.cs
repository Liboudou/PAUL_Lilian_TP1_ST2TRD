using System;

namespace PAUL_Lilian_TP1_ST2TRD
{
    public class Exo_4
    {
        private static int AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            return result;
        }
        
        public static void Square()
        {
            var n = 0;
            var m = 0;
            while (((1 <= n && n <= 1000) && (1 <= m && m <= 1000)) == false)
            {
                
                
                    n = AskUserForParameter();
                    m = AskUserForParameter();
                

            }
            Console.WriteLine("Bien joué x)");

            void Dessiner(int a, int large, int currentLine)
            {
                string result = null;
                if (a == 0) // dessiner la first et last ligne
                {
                    string v = null;
                    for (var i = 0; i <= m-3; i++) //pas ouf mais après y a plus qu'une variable x)
                    {
                        v += "-";
                    }

                    if (m == 1)
                    {
                        string w = "0";
                    }
                    else
                    {
                        result = "0" + v + "0";
                        Console.WriteLine(result);
                    }
                }
                else // dessiner les étoiles
                {
                    

                    if (m == 1)
                    {
                        result = "|";
                    }

                    var posEtoile = currentLine % 3;
                    for (var i = 0; i <= m - 3; i++)
                    {
                        if (posEtoile == (i%3)) // si c'est la première ligne ou la troisème
                        {
                            result += "*";
                        }
                        else
                        {
                            result += " ";
                        }  
                    }

                    if (m >= 2)
                    {
                        Console.WriteLine("|"+result + "|");
                    }
                        
                    
                }
            }
            void Draw()
            {
                for (int i = 0; i <= n-1; i++)
                {
                    if (i == n-1)
                    {
                        Dessiner(0, m,i);
                    }
                    else if( i == 0)
                    {
                        Dessiner(0, m,i);
                    }
                    else
                    {
                        Dessiner(1, m,i);
                    }
                }
                if ((n == 1) && (m == 1))
                {
                    Console.WriteLine("0");
                }
            }
            Draw();
        }
    }
}