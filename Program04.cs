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
            Console.WriteLine("Tipo texto (string):");
            Console.WriteLine("   Para palabras o frases completas.");
            Console.WriteLine("   Valor guardado: " + nombre + ", " + nombre1 + ", " + nombre2 + "son amigos"); ;


            char A = 'A';
            char B = 'B';
            char C = 'C';
            char D = 'D';
            Console.WriteLine("\nTipo carácter (char):");
            Console.WriteLine("   Para un solo carácter. Usa comillas simples.");
            Console.WriteLine("   Valor guardado: " + A + ", " + B + ", " + C + ", " + D + " son letras del alfabeto"   );

             Console.WriteLine("\nPresiona ENTER para cerrar.");
        }
    }
}