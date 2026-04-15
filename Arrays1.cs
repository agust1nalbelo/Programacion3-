using System;

namespace Array01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Ejercicios de Array----"); 
            Console.WriteLine("Elija un ejercicio por favor del 1 al 5");

            int ejercicios;

            
            if (!int.TryParse(Console.ReadLine(), out ejercicios))
            {
                Console.WriteLine("Entrada inválida. Debe ingresar un número.");
                return;
            }

            switch (ejercicios)
            {
                case 1:
                    Console.WriteLine("Ejercicio 1: FUNDAMENTOS DE ARRAYS");
                    int[] numeros = new int[3];
                    numeros[0] = 10;
                    numeros[1] = 20;
                    numeros[2] = 30;

                    Console.WriteLine("Valor en la posición 0: " + numeros[0]);
                    Console.WriteLine("Valor en la posición 1: " + numeros[1]);
                    Console.WriteLine("Valor en la posición 2: " + numeros[2]);
                    break;

                case 2:
                    Console.WriteLine("Ejercicio 2: Fundamentos de arrays");
                    string[] nombres = new string[4];
                    nombres[0] = "Mario";
                    nombres[1] = "Marino";
                    nombres[2] = "Boca";
                    nombres[3] = "Juniors";

                    Console.WriteLine("Valor en la posición 0: " + nombres[0]);
                    Console.WriteLine("Valor en la posición 1: " + nombres[1]);
                    Console.WriteLine("Valor en la posición 2: " + nombres[2]);
                    Console.WriteLine("Valor en la posición 3: " + nombres[3]);
                    break;

                case 3:
                    Console.WriteLine("Ejercicio 3: Fundamentos de arrays");
                    double[] numerosDecimales = new double[5];
                    numerosDecimales[0] = 1.5;
                    numerosDecimales[1] = 2.5;
                    numerosDecimales[2] = 3.5;
                    numerosDecimales[3] = 4.5;
                    numerosDecimales[4] = 5.5;

                    Console.WriteLine("Valor en la posición 0: " + numerosDecimales[0]);
                    Console.WriteLine("Valor en la posición 1: " + numerosDecimales[1]);
                    Console.WriteLine("Valor en la posición 2: " + numerosDecimales[2]);
                    Console.WriteLine("Valor en la posición 3: " + numerosDecimales[3]);
                    Console.WriteLine("Valor en la posición 4: " + numerosDecimales[4]);
                    break;

                case 4:
                    Console.WriteLine("Ejercicio 4: Fundamentos de arrays");
                    char[] caracteres = new char[3];
                    caracteres[0] = 'A';
                    caracteres[1] = 'B';
                    caracteres[2] = 'C';

                    Console.WriteLine("Valor en la posición 0: " + caracteres[0]);
                    Console.WriteLine("Valor en la posición 1: " + caracteres[1]);
                    Console.WriteLine("Valor en la posición 2: " + caracteres[2]);
                    break;

                case 5:
                    Console.WriteLine("Ejercicio 5: Fundamentos de arrays");
                    bool[] valoresBooleanos = new bool[4];
                    valoresBooleanos[0] = true;
                    valoresBooleanos[1] = false;
                    valoresBooleanos[2] = true;
                    valoresBooleanos[3] = false;

                    Console.WriteLine("Valor en la posición 0: " + valoresBooleanos[0]);
                    Console.WriteLine("Valor en la posición 1: " + valoresBooleanos[1]);
                    Console.WriteLine("Valor en la posición 2: " + valoresBooleanos[2]);
                    Console.WriteLine("Valor en la posición 3: " + valoresBooleanos[3]);
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}