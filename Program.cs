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
            int dificultad;
            do
            {

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("- - - B U S C A M I N A S - - -");
                Console.WriteLine("Dificultad: ");
                ConsoleGame<Celda> game;
                try
                {
                    dificultad = int.Parse(Console.ReadLine());
                }
                catch
                {
                    dificultad = -1;
                } //lo correspondiente a un try except de python, corrige excepcion cuando no se puede parsear el string de entrada, cayendo en el default del switch
                switch (dificultad)
                {
                    case 1:
                        Console.WriteLine("Fácil"); //Esta linea ponerla mejor antes para crear el menu con todas las dificultades, pues el usuario no sabe en este momento que 1 = Facil
                        game = new ConsoleGame<Celda>(8, 8, 10); //Configuración del facil
                        break;
                    case 2:
                        Console.WriteLine("Medio");
                        //Cagar ConsoleGame con configuración de Medio
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

                /*Una vez cargado el objeto game, preguntar al usuario que celda quiere clickear con este algoritmo:
                 1. Leer coordenadas en X del usuario
                 2. Leer coordenadas en Y del usuario
                 3. Determiar si quiere revelar la celda o marcar una bandera
                 4. Verificar que se puedan parsear los datos y que esten dentro de la matriz, en caso contrario volver a preguntar al usuario
                 5. Mostrar la celda:
                    a) Si es mina fin del juego e ir al paso 8
                    b) Si es 0 poner en SHOW a la celda y a sus vecinos
                    c) Si es >0 poner en SHOW  a la celda
                 6. Actualizar la consola llamando otra vez a ShowGrid()
                 7. Si no se han visto todas las celdas que no son minas o no se han marcado con banedera todas las minas ir al paso 1.
                 8. Fin
                */
            } while (dificultad != 5); //Un loop para que se pueda volver al menu

            Console.ReadKey();

        }
    }
}
