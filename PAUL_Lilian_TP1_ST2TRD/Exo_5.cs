using System;

namespace PAUL_Lilian_TP1_ST2TRD
{
    public static class Exo_5
    {
        public static void ChristmasTree()
        {
            int AskUserForParameter()
            {
                Console.WriteLine("Please write a number between 3 and 20 and press enter :");
                int.TryParse(Console.ReadLine(), out var result);
                return result;
            }
 
            
            var n = 0;
            
            while ((3 < n && n < 20) == false)
            {
                n = AskUserForParameter();
            }
            

            void Dessiner(int a, int currentLine,int typeArbre)
            {
                string result = null;
                var center = n+1; // où est le centre
                var centerUpperbound = center + currentLine;
                var centerLowborn = center - currentLine;
                if (a == 1) // dessiner le tronc
                {
                    
                    for (int i = 0; i <= n * 2; i++)
                    {
                        if ((i == center - 1) | (i == center + 1))
                        {
                            
                            result += "|";
                        }
                        else
                        {
                            result += " ";
                        }
                    }
                    Console.WriteLine(result);
                }


                if (a != 0) return;
                {
                    for (var i = 0; i <= n * 2; i++) // largeur max de l'arbre
                    {
                        if ((i >= centerLowborn) && (i <= centerUpperbound)) // vérifier si dans l'interval où on met des *
                        {
                            
                            if ((currentLine % 3 == i % 3) && (typeArbre!= 0))
                            {
                                if (currentLine % 9 == i % 9) // environ 1/3 c'est cool en vrai
                                {
                                    result += "o";
                                }
                                else
                                {
                                    result += "i";
                                }
                            }
                            else
                            {
                                result += "*";
                            }
                        }
                        else // sinon mettre un espace
                        {
                            result += " ";
                        }
                        
                    }
                
                    
                    Console.WriteLine(result);
                }
            }
            void Draw()
            {
                for (var j = 0; j <= 1; j++)
                {
                    
                    for (var i = 0; i <= n; i++) // dessiner toutes les lignes
                    {
                        Dessiner(i == n ? 1 : 0, i,j);
                        
                    }
                    
                }
            }
            Draw();
        }
    }
}