using System;

class Program {
  public static void Main (string[] args) {
    
               double x, y;
               //int A = 1°,B = 2°,C = 3°,D = 4°;
               //string Q = Quadrante;
            Console.Clear();
            Console.WriteLine();   

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("--- Quadrante Cartesiano ---\n");
            Console.ResetColor();

            Console.WriteLine("--- Fornecer as coordenadas X e Y do ponto desejado ----");
            Console.Write("Entrar com a Cordenada X...:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrar com a Cordenada y...:");
            y = Convert.ToDouble(Console.ReadLine());
            
            Console.ForegroundColor = ConsoleColor.Red;
            if (x == 0 && y == 0)

            {
                Console.WriteLine($"O ponto ({x} {y}) fica na origem\n");
            }

            else if (x > 0 && y > 0)
            {

                Console.WriteLine($"O ponto ({x} , {y})  fica no 1º quadrante.\n");               
            }

            else if (x < 0 && y > 0)

            {
                Console.WriteLine($"O ponto ({x} , {y})  fica no 2º quadrante.\n");

            }

            else if (x < 0 && y < 0)

            {
            
                Console.WriteLine($"O ponto ({x} , {y})  fica no 3° quadrante.\n");
            }
    
            else if (x > 0 && y < 0)

            {
                Console.WriteLine($"O ponto ({x} , {y})  fica no 4° quadrante.\n");
            }
            
            else
  
            {
                Console.WriteLine($"O ponto ({x} , {y})  fica no eixo das coordenadas.\n");
            }

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("             +Y              ");
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.Write(Q,Trim(),ToUpper(),PadLeft(4, 0),Substring(0, 4));
            //Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("              |              ");
            Console.WriteLine("      4º      |      1º      ");
            Console.WriteLine("   Quadrante  |   Quadrante  ");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("-X------------0------------+X");
            Console.WriteLine("              |              ");
            Console.WriteLine("              |              ");
            Console.WriteLine("      3°      |       2º     ");
            Console.WriteLine("   Quadrante  |   Quadrante  ");
            Console.WriteLine("              |              ");
            Console.WriteLine("             -Y              ");
            
            Console.ResetColor();
            
            //Console.WriteLine(Q);
        }
     }


