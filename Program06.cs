namespace Program06
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("--- BLOQUE 5: CONSTANTES ---");


            const string NOMBRE_APP = "GameMaster Pro";
            Console.WriteLine("1. NOMBRE DE LA APP:");
            Console.WriteLine("   Una constante sirve para guardar un valor que nunca cambia.");
            Console.WriteLine("   Valor guardado: " + NOMBRE_APP);



            const string VERSION = "v1.0.2";
            Console.WriteLine("\n2. VERSIÓN DEL SISTEMA:");
            Console.WriteLine("   La versión también suele quedar fija.");
            Console.WriteLine("   Valor guardado: " + VERSION);



            const int EDAD_MINIMA = 18;
            Console.WriteLine("\n3. EDAD MÍNIMA:");
            Console.WriteLine("   Las reglas del sistema se pueden guardar como constantes.");
            Console.WriteLine("   Valor guardado: " + EDAD_MINIMA);



            const int DIAS_SEMANA = 7;
            Console.WriteLine("\n4. DÍAS DE LA SEMANA:");
            Console.WriteLine("   Nunca cambian, por eso conviene usar const.");
            Console.WriteLine("   Valor guardado: " + DIAS_SEMANA);



            const double META_KILOMETROS = 4.0;
            Console.WriteLine("\n5. META DE KILÓMETROS:");
            Console.WriteLine("   Si tu objetivo fijo es llegar a 4 km, también puede ser una constante.");
            Console.WriteLine("   Valor guardado: " + META_KILOMETROS);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}