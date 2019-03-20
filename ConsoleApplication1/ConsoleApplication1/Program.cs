using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Class1 obj1 = new obj1();
            Class1 obj2 = new obj2();
            Class1 obj3 = new obj3();
            Class1 obj4 = new obj4();

            Console.WriteLine("***MENU DE OPCIONES***");
            Console.WriteLine("Para multiplicar ingrese 1");
            Console.WriteLine("Para dividir ingrese 2");
            Console.WriteLine("Para ingresar nombres digite 3");
            Console.WriteLine("Para ingresar edades digite 4");
            opcion = int.Parse(Console.ReadLine());

            switch:
            {
                case 1:
                    obj1.Multiplicar();

                    break;

                case 2:
                    obj2.Dividir();

                    break;

                case 3:
                    obj3.Nombres()

                    break;

                case 4:
                    obj3.Edades();

                    break;
            }
            Console.ReadKey();
        }
    }
}
