using System;

namespace Logica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] nombres = new string[20];
            int[] edades = new int[20];

            Console.WriteLine("Bienvenido. Ingresaremos datos de 20 personas.");

            
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"\nPersona {i + 1}:");
                
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Edad: ");
                while (!int.TryParse(Console.ReadLine(), out edades[i]))
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número:");
                }
            }

            
            Console.WriteLine("--- Personas habilitadas (Mayores de 30) ---");
            for (int i = 0; i < 20; i++)
            {
                if (edades[i] > 30)
                {
                    Console.WriteLine($"Puede ingresar al boliche: {nombres[i]} y su edad es: {edades[i]} años. ");
                }
                else
                {
                    Console.WriteLine($"A la casa jajaja:  {nombres[i]} y su edad es: {edades[i]} años. ");
                }
            }
            
        
        }
    }
}