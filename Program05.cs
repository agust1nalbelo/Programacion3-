namespace Program05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- BLOQUE 4: VALORES LÓGICOS (SÍ / NO) ---");

            bool cursoCompletado = true;
            bool aproboParcial = false;
            bool tieneBrackets = true;
            bool entrenoHoy = true;
            bool subioTarea = false;

            Console.WriteLine("1. TIPO LÓGICO (bool):");
            Console.WriteLine("   Solo puede ser 'true' o 'false'.");
            Console.WriteLine("   ¿El curso está completado?: " + cursoCompletado);

            Console.WriteLine("\n2. APROBÓ EL PARCIAL:");
            Console.WriteLine("   También usamos bool para responder sí o no.");
            Console.WriteLine("   ¿Aprobó el parcial?: " + aproboParcial);

            Console.WriteLine("\n3. TIENE BRACKETS:");
            Console.WriteLine("   Una característica que solo puede ser sí o no.");
            Console.WriteLine("   ¿Tiene brackets?: " + tieneBrackets);

            Console.WriteLine("\n4. ENTRENÓ HOY:");
            Console.WriteLine("   Sirve para guardar si hiciste algo o no.");
            Console.WriteLine("   ¿Entrenó hoy?: " + entrenoHoy);

            Console.WriteLine("\n5. SUBIÓ LA TAREA:");
            Console.WriteLine("   También podemos guardar si una tarea fue enviada.");
            Console.WriteLine("   ¿Subió la tarea?: " + subioTarea);

            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
    }
}
}
