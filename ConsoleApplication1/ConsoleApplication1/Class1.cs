using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        int num1, num2, result;


            public void Multiplicar()
            {
                    Console.WriteLine("Por favor ingrese el primer valor a multiplicar: ");
                    num1 = int.Parse(Console.ReadLine());

                    if (num1==0)
                    {
                        Console.WriteLine("El producto de 0 por cualquier numero es 0.");
                    }
                    else
                    {
                        Console.WriteLine("Por favor ingrese el segundo valor a multiplicar: ");
                        num2 = int.Parse(Console.ReadLine());

                        result = num1 * num2;

                        Console.WriteLine("El resultado de la multiplicacion es: " + result);
                    }
             }
            public void Dividir()
            {
                    Console.WriteLine("Por favor ingrese el primer valor a dividir: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Por favor ingrese el segundo valor a dividir: ");
                    num1 = int.Parse(Console.ReadLine());

                    if (num2==0)
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero");
                    }
                    else
                    {
                        result = num1/num2;

                        Console.WriteLine("El resultado de la division es: " + result);
                    }
             }

            public void Nombres()
            {
                String [5] nom = new String [5];
                int i;
                i = 1;
                for (i <= 5; i++)
                {
                    Console.WriteLine("Por favor ingrese el nombre: ");
                    nom[i] = Console.ReadLine();
                }

                for (i <= 5; i++)
                {
                    Console.WriteLine("El nombre es: " + nom[i]);
                }
            }

            public Edades()
            {
                int [5] edades = new int [5];
                int i;
                i = 1;
                while (i <= 5)
                {
                    Console.WriteLine("Por favor ingrese la edad ");
                    edades[i] = Console.ReadLine();

                    i = i+1;
                }

                while (i <= 5)
                {
                    Console.WriteLine("La edad es: " + edades[i]);

                    i = i+1;
                }
            }

     }   
}
