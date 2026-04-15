namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Arrays---");
            Console.WriteLine("Seleccione alguna opcion del 1 al 5 por favor"); 
            int ejercicios;
            if (!int.TryParse(Console.ReadLine(), out ejercicios))
            {
                Console.WriteLine("Entrada inválida. Debe ingresar un número.");
                return;
            }
            switch (ejercicios)
            {
                case 1:
                    Console.WriteLine("--Array--");
                   Console.WriteLine("Ejercicio array con length y for");
                   int[] edades = { 25, 30, 35, 40, 45 };
                   int cantidadEdades = edades.Length;
                   Console.WriteLine("Cantidad de edades: " + cantidadEdades);
                   for (int i = 0; i < cantidadEdades; i++)
                   {
                       Console.WriteLine("Edad en la posición " + i + ": " + edades[i]);
                   }
                break; 
                case 2: 
                    Console.WriteLine("--Array--");
                    string[] frutas = { "Manzana", "Banana", "Naranja", "Uva" };
                    int cantidadFrutas = frutas.Length;
                    Console.WriteLine("Cantidad de frutas: " + cantidadFrutas);
                    for (int i = 0; i < cantidadFrutas; i++)
                    {
                        Console.WriteLine("Fruta en la posición " + i + ": " + frutas[i]);
                    }
                break; 
                
                case 3: 
                   Console.WriteLine("--Array--");
                   double[] precios = { 10.5, 20.75, 30.0, 40.25 };
                     int cantidadPrecios = precios.Length;
                    Console.WriteLine("Cantidad de precios: " + cantidadPrecios);
                    for (int i = 0; i < cantidadPrecios; i++)
                    {
                        Console.WriteLine("Precio en la posición " + i + ": " + precios[i]);
                    }
                break;
                case 4: 
                    Console.WriteLine("--Array--");
                    char[] letras = { 'A', 'B', 'C', 'D', 'E' };
                    int cantidadLetras = letras.Length;
                    Console.WriteLine("Cantidad de letras: " + cantidadLetras);
                    for (int i = 0; i < cantidadLetras; i++)
                    {
                        Console.WriteLine("Letra en la posición " + i + ": " + letras[i]);
                    }
                break;
                case 5:
                    Console.WriteLine("--Array--");
                    bool[] bools = { true, false, true, false, true };
                    int cantidadBools = bools.Length;
                    Console.WriteLine("Cantidad de valores booleanos: " + cantidadBools);
                    for (int i = 0; i < cantidadBools; i++)
                    {
                        Console.WriteLine("Valor booleano en la posición " + i + ": " + bools[i]);
                    }
                break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione un número del 1 al 5.");
                break;
            }
        }
    }
}