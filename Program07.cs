namespace Program07
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal TASA_IVA = 0.21m; // 21% fijo
            const bool MODO_PRUEBA = false; // Control de seguridad
            const char SIMBOLO_PESO = '$';

            Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
            Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

            decimal precioBase = 1500.50m;
            decimal impuestoCalculado = precioBase * TASA_IVA;
            decimal total = precioBase + impuestoCalculado;

            Console.WriteLine("\nDetalle de la compra:");
            Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
            Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
            Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

            
{
            const int EDAD_MINIMA = 18;
            const bool TIENE_DNI = true;
            const string NOMBRE_EVENTO = "Torneo Gamer";

            Console.WriteLine("--- REGISTRO DE EVENTO ---");
            Console.WriteLine("Evento: " + NOMBRE_EVENTO);

            int edadJugador = 20;
            bool puedeEntrar = edadJugador >= EDAD_MINIMA && TIENE_DNI;

            Console.WriteLine("\nEdad del jugador: " + edadJugador);
            Console.WriteLine("Edad minima: " + EDAD_MINIMA);
            Console.WriteLine("Tiene DNI: " + TIENE_DNI);
            Console.WriteLine("Puede entrar: " + puedeEntrar);
        }


        {
            const double META_KILOMETROS = 4.0;
            const bool ENTRENAMIENTO_ACTIVO = true;
            const string DIA = "Lunes";

            Console.WriteLine("\n--- ENTRENAMIENTO ---");
            Console.WriteLine("Dia: " + DIA);

            double kilometrosHechos = 2.5;
            double kilometrosFaltantes = META_KILOMETROS - kilometrosHechos;

            Console.WriteLine("\nKilometros hechos: " + kilometrosHechos);
            Console.WriteLine("Meta: " + META_KILOMETROS);
            Console.WriteLine("Faltan: " + kilometrosFaltantes);
            Console.WriteLine("Entrenamiento activo: " + ENTRENAMIENTO_ACTIVO);
        }


        {
            const decimal PRECIO_CURSO = 25000m;
            const decimal DESCUENTO = 0.10m;
            const char SIGNO_PESO = '$';

            Console.WriteLine("\n--- COMPRA DE CURSO ---");

            decimal descuentoAplicado = PRECIO_CURSO * DESCUENTO;
            decimal precioFinal = PRECIO_CURSO - descuentoAplicado;

            Console.WriteLine("\nPrecio original: " + SIGNO_PESO + PRECIO_CURSO);
            Console.WriteLine("Descuento: " + (DESCUENTO * 100) + "%");
            Console.WriteLine("Precio final: " + SIGNO_PESO + precioFinal);
        }


        {
            const int CANTIDAD_MATERIAS = 6;
            const bool FINAL_APROBADO = false;
            const string UNIVERSIDAD = "UTN";

            Console.WriteLine("\n--- DATOS DEL ESTUDIANTE ---");
            Console.WriteLine("Universidad: " + UNIVERSIDAD);

            int materiasAprobadas = 4;
            int materiasRestantes = CANTIDAD_MATERIAS - materiasAprobadas;

            Console.WriteLine("\nMaterias aprobadas: " + materiasAprobadas);
            Console.WriteLine("Cantidad de materias: " + CANTIDAD_MATERIAS);
            Console.WriteLine("Materias restantes: " + materiasRestantes);
            Console.WriteLine("Final aprobado: " + FINAL_APROBADO);
        }

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
        }
    }
}