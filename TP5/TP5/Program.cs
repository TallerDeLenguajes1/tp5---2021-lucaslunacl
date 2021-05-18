using System;
using System.Text.RegularExpressions;
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

            Ej2();
            Ej3();
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
        private static void Ej2()

        {

            int operacion;
            int resultado = 0;
            int opc;
            do
            {
                Console.WriteLine("1 - SUMA, 2- RESTA, 3- DIVISION, 4 - MULTIPLICACION");
                operacion = int.Parse(Console.ReadLine());
                Console.WriteLine("Dos numeros para realizar operacion: ");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

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
                Console.WriteLine("Desea realizar otra operacion? 1- SI 2-NO");
                opc = int.Parse(Console.ReadLine());

            } while (opc == 1);
        }
    private static void Ej3()
        {
            Console.WriteLine("\n -- CALCULADORA MEJORADA -- \n");
            Console.WriteLine("Escriba un numero: \n");
            float num = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor absoluto: " + Math.Abs(num) + "\n");
            Console.WriteLine("Cuadrado: " + Math.Pow(num,2) + "\n");
            Console.WriteLine("Seno: " + Math.Sin(num) + "\n");
            Console.WriteLine("Coseno: " + Math.Cos(num) + "\n");
            Console.WriteLine("Parte entera: " + Math.Truncate(num) + "\n");

            int a, b;
            Console.WriteLine("-- Máximo y mínimo entre 2 números -- ");
            Console.WriteLine("Primer número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Máximo: " + Math.MaxMagnitude(a,b));
            Console.WriteLine("Mínimo: " + Math.MinMagnitude(a, b));

            Console.WriteLine("----------------------------------\n");
        }
        private static void Ej4()
        {
            Console.WriteLine(" -- EJERCICIO 4 -- \n");
            string cadena = Console.ReadLine();

            Console.WriteLine("Longitud de la Cadena\n");
            Console.WriteLine("La longitud de la cadena es de " + cadena.Length + "caracteres \n");

            Console.WriteLine("\nConcatenar Cadenas\n");
            Console.WriteLine("Escriba otra cadena de texto\n");
            string cadena2 = Console.ReadLine();
            string cadena3 = cadena + cadena2;
            Console.WriteLine("Cadenas concatenadas: " + cadena3 + "\n");

            Console.WriteLine("SubCadena\n");
            string subcadena = cadena3.Substring(1, 5);

            Console.WriteLine("Subcadena: " + subcadena + "\n");


            Console.WriteLine("ForEach\n");

            foreach (var item in cadena)
            {
                Console.WriteLine(item);
            }





        }
    }
}
