namespace Program01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*-------* Sistema de registro de jugadores *-------*");
            Console.WriteLine("*-*-*-*-* INGRESE LOS DATOS DEL JUGADOR *-*-*-*-*");

            Console.WriteLine("Ingrese el nombre del jugador por favor: ");
            string nombreJugador = Console.ReadLine();

            Console.WriteLine("Como contamos con juegos con mucha violencia, necesitamos saber la edad del jugador, ingrese su edad por favor: ");
            int edadJugador = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Habilidad estimada por juegos: Minimo 1.50, Medio 2.50, Maximo 3.50, ingrese la habilidad del jugador por favor: ");
            double habilidadJugador = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*-------* REGISTRO COMPLETADO *-------*");
            Console.WriteLine("El jugador " + nombreJugador + " tiene " + edadJugador + " años y una habilidad de " + habilidadJugador);    
        }
    }
}