namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicios Arrays 2");
            Console.WriteLine("Seleccione alguna opcion del 1 al 5 por favor");
            int ejercicios;

            
            if (!int.TryParse(Console.ReadLine(), out ejercicios))
            {
                Console.WriteLine("Entrada inválida. Debe ingresar un número.");
                return;
            }
            switch (ejercicios)
            {
                case 1: 
                    Console.WriteLine("--Array--");
                    string[] invitados =
                    {
                        "Marino",
                        "Mario",
                        "Tobi",
                        "Insano"
                    };
                    foreach(string nombres in invitados)
                    {
                        Console.WriteLine("Muestrame los invitados: "+ invitados);
                    }
                break; 
                case 2: 
                    Console.WriteLine("--Array--");
                    int[] numeros = { 10, 20, 30, 40, 50 };
                    foreach (int numero in numeros)
                    {
                        Console.WriteLine("Muestrame los numeros: " + numeros);
                    }
                break; 
                
                case 3: 
                    Console.WriteLine("--Array--");
                    double[] precios = {35.5, 45,5, 43,2, 67,8};
                    foreach(double precio in precios)
                    {
                        Console.WriteLine("El precio son estos: " + precios);
                    }
                break;
                case 4: 
                    Console.WriteLine("--Array--");
                    char[] caracteres = { 'C', 'A', 'B', 'J'};
                    foreach( char letras in caracteres)
                    {
                        Console.WriteLine("Que equipo es el mas grande de LatinoAmerica?: " + caracteres );

                    }
                break;
                case 5:
                    Console.WriteLine("--Array--"); 
                    bool[] boleano = { true, true, true, true, true }; 
                    foreach(bool insano in boleano)
                    {
                        Console.WriteLine("Es boca el mayor club de la historia, mas grande de latinoamerica?  " + true );

                    }
                    
                break;
                default: 
                    Console.WriteLine("Escriba una opcion valida por favor mario ");
                break;
            }
        }
    }
}