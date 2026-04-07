namespace Program03
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("*----* Bloque numeros con decimales *---*");
           double distancia = 700.4; 
           Console.WriteLine("Tipo decimal comun ");
           Console.WriteLine("Valor guardado: " + distancia + "km");

           decimal PrecioProducto = 19.99m;
           Console.WriteLine("Tipo decimal financiero");
           Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
            Console.WriteLine("   Valor guardado: $" + PrecioProducto);

        }
    }
}