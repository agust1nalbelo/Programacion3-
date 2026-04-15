namespace Program02
{
    class Program
    {
        static void Main(string[] args)
        {
             {
                 Console.WriteLine("--- BLOQUE 1: NÚMEROS ENTEROS ---");

                 int edad = 24;
                 int cantidadAmigos = 5;
                 int golesRiver = 3;
                 int materiasUTN = 6;
                 int diasEntrenando = 4;



                Console.WriteLine("1. TIPO ENTERO (int):");
                Console.WriteLine("   Para números sin decimales, como edad o cantidad.");
                Console.WriteLine("   Valor guardado en edad: " + edad);



                Console.WriteLine("\n2. CANTIDAD DE AMIGOS:");
                Console.WriteLine("   También usamos int cuando contamos personas.");
                Console.WriteLine("   Valor guardado: " + cantidadAmigos);



                Console.WriteLine("\n3. GOLES DE RIVER:");
                Console.WriteLine("   Los goles siempre son números enteros.");
                Console.WriteLine("   Valor guardado: " + golesRiver);



                Console.WriteLine("\n4. MATERIAS DE LA UTN:");
                Console.WriteLine("   Las materias que cursás también se guardan con int.");
                Console.WriteLine("   Valor guardado: " + materiasUTN);



                Console.WriteLine("\n5. DÍAS ENTRENANDO:");
                Console.WriteLine("   Los días que entrenás por semana no tienen decimales.");
                Console.WriteLine("   Valor guardado: " + diasEntrenando);



                Console.WriteLine("\nPresiona ENTER para cerrar.");
                Console.ReadLine();
}
        }
    }
}