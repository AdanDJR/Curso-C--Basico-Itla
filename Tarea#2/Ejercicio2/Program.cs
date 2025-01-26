Console.WriteLine("Ingresa dos numeros para multiplicar: \n");

while (true)
{
    Console.WriteLine("ingresa el numero que quieres multiplicar");
    string numero = Console.ReadLine();
    Console.WriteLine("Ingresa el numero por el cual se va a multiplicar");
    string numero2 = Console.ReadLine();

    double resultado;
    double resultado2;
    if (double.TryParse(numero, out resultado))
    {
        if (double.TryParse(numero2, out resultado2))
        {
             double resultadoFinal = resultado * resultado2;
             Console.WriteLine($"La multiplicacion entre los numeros es: {resultadoFinal}");
              return;
        }
        else
        {
            Console.WriteLine("El segundo valor ingresado tiene una letra");
        }
    }
    else
    {
        Console.WriteLine("El primer valor ingregasado tiene una letra");

    }

}