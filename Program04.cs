namespace Program04 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*----* Bloque texto y caracteres *---*");

            string nombre = "Juan";
            string nombre1 = "Pepe";
            string nombre2 = "Lolo";
            string carrera = "Programación";
            string universidad = "UTN";
            string videojuego = "GTA V";
            string equipo = "River Plate";

            Console.WriteLine("1. TIPO TEXTO (string):");
            Console.WriteLine("   Para palabras o frases completas.");
            Console.WriteLine("   Valor guardado: " + nombre + ", " + nombre1 + ", " + nombre2 + " son amigos");



            Console.WriteLine("\n2. CARRERA:");
            Console.WriteLine("   También usamos string para guardar el nombre de una carrera.");
            Console.WriteLine("   Valor guardado: " + carrera);



            Console.WriteLine("\n3. UNIVERSIDAD:");
            Console.WriteLine("   Una universidad también se guarda como texto.");
            Console.WriteLine("   Valor guardado: " + universidad);



            Console.WriteLine("\n4. VIDEOJUEGO:");
            Console.WriteLine("   El nombre de un juego se guarda con string.");
            Console.WriteLine("   Valor guardado: " + videojuego);



            Console.WriteLine("\n5. EQUIPO DE FÚTBOL:");
            Console.WriteLine("   Los nombres de equipos también son texto.");
            Console.WriteLine("   Valor guardado: " + equipo);


            char A = 'A';
            char B = 'B';
            char C = 'C';
            char D = 'D';
            char inicialUsuario = 'G';
            char letraMenu = 'M';
            char notaExamen = 'A';
            char opcion = 'S';

            Console.WriteLine("\n1. TIPO CARÁCTER (char):");
            Console.WriteLine("   Para un solo carácter. Usa comillas simples.");
            Console.WriteLine("   Valor guardado: " + A + ", " + B + ", " + C + ", " + D + " son letras del alfabeto");



            Console.WriteLine("\n2. INICIAL DEL USUARIO:");
            Console.WriteLine("   También podemos guardar la inicial de una persona.");
            Console.WriteLine("   Valor guardado: " + inicialUsuario);



            Console.WriteLine("\n3. LETRA DE MENÚ:");
            Console.WriteLine("   Una opción de menú puede ser una sola letra.");
            Console.WriteLine("   Valor guardado: " + letraMenu);



            Console.WriteLine("\n4. NOTA DE EXAMEN:");
            Console.WriteLine("   Una calificación con letras se guarda con char.");
            Console.WriteLine("   Valor guardado: " + notaExamen);



            Console.WriteLine("\n5. OPCIÓN:");
            Console.WriteLine("   Otra letra individual también se guarda como char.");
            Console.WriteLine("   Valor guardado: " + opcion);



            Console.WriteLine("\nPresiona ENTER para cerrar.");
            Console.ReadLine();
        }
    }
}