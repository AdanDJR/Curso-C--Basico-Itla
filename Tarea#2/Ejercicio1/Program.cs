using System.Timers;

Console.WriteLine("Ingresa dos numeros para dividir:");

while (true)
{
    Console.WriteLine("ingresa el primer numero");
    string numero = Console.ReadLine();
    Console.WriteLine("Ingresa el segundo numero");
    string numero2 = Console.ReadLine();

    double resultado;
    double resultado2;
    if (double.TryParse(numero, out resultado))
    {
        if (double.TryParse(numero2, out resultado2))
        {


            if (resultado2 == 0)
            {
                Console.WriteLine("No se puede dividir entre 0, vamos de nuevo");

            }
            else
            {
                double resultadoFinal = resultado / resultado2;
                Console.WriteLine($"La divicion entre los numeros es: {resultadoFinal}");
                return;
            }

        }
        else
        {
            Console.WriteLine("El segundo valor ingresado tiene una letra");
        }
    }
    else {
        Console.WriteLine("El primer valor ingregasado tiene una letra");
    
    }

}