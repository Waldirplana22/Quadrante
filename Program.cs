using System;

class Program {
  public static void Main (string[] args) {
    
               double x, y;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("--- Quadrante Cartesiano ---\n");
            Console.ResetColor();

            Console.WriteLine("--- Entre com o ponto desejado ----");
            Console.Write("Entre com a Cordenada X...:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entre com a Cordenada y...:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            if (x == 0 && y == 0)

            {
                Console.WriteLine($"O ponto ({x} {y}) fica na origem\n");
            }

            else if (x > 0 && y > 0)
            {

                Console.WriteLine($"O ponto ({x} , {y})  fica no quadrante 1.\n");               
            }

            else if (x < 0 && y > 0)

            {
                Console.WriteLine($"O ponto ({x} , {y})  fica no quadrante 2.\n");

            }

            else if (x < 0 && y < 0)

            {
            
                Console.WriteLine($"O ponto ({x} , {y})  fica no quadrante 3.\n");
            }
    
            else if (x > 0 && y < 0)

            {
                Console.WriteLine($"O ponto ({x} , {y})  fica no quadrante 4.\n");
            }
            
            else
  
            {
                Console.WriteLine($"O ponto ({x} , {y})  fica no eixo das cordenasdas.\n");
            }

            Console.WriteLine();
        }
     }
