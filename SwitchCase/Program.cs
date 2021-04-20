using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {

            //opciones 
            Console.WriteLine("Elige una opcion\n " +
                "\n1. - suma" +
                "\n2. - resta" +
                "\n3. - multiplicacon" +
                "\n4. - division" +
                "\n5. - salir"
                );
            string s1 = null;
            s1 = Console.ReadLine();


              switch (s1)
                {
                case "1":
                    Console.WriteLine("Seleccionaste la suma");
                        break;
                case "2":
                    Console.WriteLine("Seleccionaste la resta");
                    break;

                case "3":
                    Console.WriteLine("Seleccionaste la multiplicacion");
                    break;

                case "4":
                    Console.WriteLine("Seleccionaste la division");
                    break;

                case "5":
                    Console.WriteLine("Seleccionaste salir");
                    break;
                default:
                    Console.WriteLine("La opcion es incorrecta");
                    break;
            }

            Console.ReadKey();

        }
    }
}
