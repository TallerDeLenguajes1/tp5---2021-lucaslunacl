using System;

namespace TP5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            /*Console.WriteLine("Numero a invertir: "); // WriteLine para escribir (printf)
            int num = int.Parse(Console.ReadLine());
            Ej1(num);*/

            Console.WriteLine("Dos numeros para realizar operacion: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Ej2(a, b);

        }







        private static int Ej1(int numero)
        {
            int numInv = 0;
            if (numero <= 0)
            {
                Console.WriteLine("No se pudo convertir");
            }
            else
            {
                numInv = numInv * 10 + numero % 10;
                numero /= 10;
                Console.WriteLine("El numero invertido es " + numInv);
            }
            return numInv;

        }
        private static void Ej2(int a, int b)
        {
            int operacion;
            int resultado = 0;
            int opc;
            Console.WriteLine("1 - SUMA, 2- RESTA, 3- DIVISION, 4 - MULTIPLICACION");
            operacion = int.Parse(Console.ReadLine());

      

            Console.WriteLine("Desea realizar otra operacion? 1- SI 2-NO");
            opc = int.Parse(Console.ReadLine());

            do
            {
                if (operacion == 1)
                {
                    resultado = a + b;
                    Console.WriteLine("El resultado de la suma es: " + resultado);

                }
                else if (operacion == 2)
                {
                    resultado = a - b;
                    Console.WriteLine("El resultado de la resta es : " + resultado);
                }
                else if (operacion == 3)
                {
                    resultado = a / b;
                    Console.WriteLine("El resultado de la division es : " + resultado);
                }
                else if (operacion == 4)
                {
                    resultado = a * b;
                    Console.WriteLine("El resultado de la multiplicacion es : " + resultado);
                }

            } while (opc == 1);


        }
    }
}
