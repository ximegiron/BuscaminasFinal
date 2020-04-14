//ximena
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscaminas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("- - - B U S C A M I N A S - - -");
            Console.WriteLine("Dificultad: ");
            int dificultad = 0;
            switch (dificultad)
            {
                case 1:
                    Console.WriteLine("Fácil");
                    break;
                case 2:
                    Console.WriteLine("Medio");
                    break;
                case 3:
                    Console.WriteLine("Difícil");
                    break;
                case 4:
                    Console.WriteLine("Personalizado");
                    break;
                case 5:
                    Console.WriteLine("Salir");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: Ingresa un número del 1 al 5");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            
            ConsoleGame<Celda> game = new ConsoleGame<Celda>(6, 7, 10);
            //string a = "10";
            //Console.WriteLine(a.PadLeft(3));
            Console.ReadKey();
            Celda.Status celda = Celda.Status.HIDDEN;

        }
    }
}
