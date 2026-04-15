namespace Program03
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("*----* Bloque números con decimales *---*");

            double distancia = 700.4;
            double kilometrosCinta = 2.5;
            double promedioCarrera = 8.75;
            double habilidadJugador = 3.50;
            double pesoMancuerna = 12.5;

            Console.WriteLine("1. TIPO DECIMAL COMÚN (double)");
            Console.WriteLine("   Se usa para números con decimales, como distancias.");
            Console.WriteLine("   Valor guardado: " + distancia + " km");



            Console.WriteLine("\n2. KILÓMETROS EN CINTA");
            Console.WriteLine("   También usamos double para los kilómetros que corrés.");
            Console.WriteLine("   Valor guardado: " + kilometrosCinta + " km");



            Console.WriteLine("\n3. PROMEDIO DE UNA MATERIA");
            Console.WriteLine("   Un promedio puede tener decimales.");
            Console.WriteLine("   Valor guardado: " + promedioCarrera);



            Console.WriteLine("\n4. HABILIDAD DE UN JUGADOR");
            Console.WriteLine("   La habilidad que usabas en tu registro también puede ser double.");
            Console.WriteLine("   Valor guardado: " + habilidadJugador);



            Console.WriteLine("\n5. PESO DE UNA MANCUERNA");
            Console.WriteLine("   Algunas pesas tienen kilos con decimales.");
            Console.WriteLine("   Valor guardado: " + pesoMancuerna + " kg");


            decimal precioProducto = 19.99m;
            decimal sueldoMensual = 45000.50m;
            decimal precioProteina = 32999.99m;
            decimal costoCurso = 15999.90m;
            decimal dineroAhorrado = 125000.75m;

            Console.WriteLine("\n*----* Bloque decimales financieros *---*");

            Console.WriteLine("\n1. PRECIO DE UN PRODUCTO");
            Console.WriteLine("   ¡Obligatorio para dinero! Usa decimal y la letra m.");
            Console.WriteLine("   Valor guardado: $" + precioProducto);



            Console.WriteLine("\n2. SUELDO MENSUAL");
            Console.WriteLine("   Los salarios también se guardan con decimal.");
            Console.WriteLine("   Valor guardado: $" + sueldoMensual);



            Console.WriteLine("\n3. PRECIO DE UNA PROTEÍNA");
            Console.WriteLine("   Para evitar errores con dinero usamos decimal.");
            Console.WriteLine("   Valor guardado: $" + precioProteina);



            Console.WriteLine("\n4. COSTO DE UN CURSO");
            Console.WriteLine("   El precio de un curso online también puede guardarse así.");
            Console.WriteLine("   Valor guardado: $" + costoCurso);



            Console.WriteLine("\n5. DINERO AHORRADO");
            Console.WriteLine("   Si querés guardar plata ahorrada, conviene usar decimal.");
            Console.WriteLine("   Valor guardado: $" + dineroAhorrado);

        }
    }
}