namespace Program01
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
{
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1 - Registro de jugadores");
    Console.WriteLine("2 - Registro de pacientes");
    Console.WriteLine("3 - Registro de empleados");
    Console.WriteLine("4 - Registro de estudiantes");
    Console.WriteLine("5 - Registro de productos");

    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            RegistroJugadores();
            break;

        case 2:
            SistemaRegistroPaciente();
            break;

        case 3:
            SistemaRegistroEmpleado();
            break;

        case 4:
            SistemaRegistroEstudiante();
            break;

        case 5:
            SistemaRegistroProducto();
            break;

        default:
            Console.WriteLine("Opción inválida");
            break;
    }
}

        }
        static void RegistroJugadores()
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
        static void SistemaRegistroPaciente()
        {
            Console.WriteLine("*-------* Sistema de registro de pacientes *-------*");
            Console.WriteLine("*-*-*-*-* INGRESE LOS DATOS DEL PACIENTE *-*-*-*-*");

            Console.WriteLine("Ingrese el nombre del paciente por favor: ");
            string nombrePaciente = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del paciente por favor: ");
            int edadPaciente = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el peso del paciente por favor: ");
            double pesoPaciente = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*-------* REGISTRO COMPLETADO *-------*");
            Console.WriteLine("El paciente " + nombrePaciente + " tiene " + edadPaciente + " años y pesa " + pesoPaciente + " kg");    
        }
        static void SistemaRegistroEmpleado()
        {
            Console.WriteLine("*-------* Sistema de registro de empleados *-------*");
            Console.WriteLine("*-*-*-*-* INGRESE LOS DATOS DEL EMPLEADO *-*-*-*-*");

            Console.WriteLine("Ingrese el nombre del empleado por favor: ");
            string nombreEmpleado = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del empleado por favor: ");
            int edadEmpleado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el salario del empleado por favor: ");
            double salarioEmpleado = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*-------* REGISTRO COMPLETADO *-------*");
            Console.WriteLine("El empleado " + nombreEmpleado + " tiene " + edadEmpleado + " años y un salario de " + salarioEmpleado);
    }
        static void SistemaRegistroEstudiante()
        {
            Console.WriteLine("*-------* Sistema de registro de estudiantes *-------*");
            Console.WriteLine("*-*-*-*-* INGRESE LOS DATOS DEL ESTUDIANTE *-*-*-*-*");

            Console.WriteLine("Ingrese el nombre del estudiante por favor: ");
            string nombreEstudiante = Console.ReadLine();

            Console.WriteLine("Ingrese la edad del estudiante por favor: ");
            int edadEstudiante = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el promedio del estudiante por favor: ");
            double promedioEstudiante = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*-------* REGISTRO COMPLETADO *-------*");
            Console.WriteLine("El estudiante " + nombreEstudiante + " tiene " + edadEstudiante + " años y un promedio de " + promedioEstudiante);
        }
        static void SistemaRegistroProducto()
        {
            Console.WriteLine("*-------* Sistema de registro de productos *-------*");
            Console.WriteLine("*-*-*-*-* INGRESE LOS DATOS DEL PRODUCTO *-*-*-*-*");

            Console.WriteLine("Ingrese el nombre del producto por favor: ");
            string nombreProducto = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto por favor: ");
            double precioProducto = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad del producto por favor: ");
            int cantidadProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*-------* REGISTRO COMPLETADO *-------*");
            Console.WriteLine("El producto " + nombreProducto + " tiene un precio de " + precioProducto + " y una cantidad de " + cantidadProducto);
        }
}
}

