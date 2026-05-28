using SimuladorAutomovil;

Console.Write("Ingrese marca: ");
string marca = Console.ReadLine();

Console.Write("Es automático? (s/n): ");
string opcionCaja = Console.ReadLine();

bool automatica = opcionCaja.ToLower() == "s";

Automovil auto = new Automovil(marca, automatica);

int opcion = 0;

while (opcion != 7)
{
    Console.Clear();

    auto.MostrarEstado();

    Console.WriteLine();
    Console.WriteLine("1. Encender/Apagar");
    Console.WriteLine("2. Acelerar +10");
    Console.WriteLine("3. Acelerar con parametro");
    Console.WriteLine("4. Frenar de emergencia");
    Console.WriteLine("5. Frenar con parametro");
    Console.WriteLine("6. Activar/Desactivar crucero");
    Console.WriteLine("7. Salir");
    Console.WriteLine();

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            auto.EncenderApagar();
            break;

        case 2:
            auto.Acelerar();
            break;

        case 3:
            Console.Write("Cuantos km/h acelerar?: ");
            int acelerar = Convert.ToInt32(Console.ReadLine());

            auto.Acelerar(acelerar);
            break;

        case 4:
            auto.Frenar();
            break;

        case 5:
            Console.Write("Cuantos km/h frenar?: ");
            int frenar = Convert.ToInt32(Console.ReadLine());

            auto.Frenar(frenar);
            break;

        case 6:
            auto.ModoCrucero();
            break;
    }

    Console.WriteLine();
    Console.WriteLine("Presione una tecla para continuar...");
    Console.ReadKey();
}