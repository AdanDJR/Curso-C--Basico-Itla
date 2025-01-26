Console.WriteLine("Ingresa un número para verificar si es primo:");
int numero = int.Parse(Console.ReadLine());
bool esPrimo = true;

if (numero <= 1)
{
    esPrimo = false;
}
else
{
    for (int i = 2; i < numero; i++)
    {
        if (numero % i == 0)
        {
            esPrimo = false;
            break; // Terminamos el ciclo si encontramos un divisor
        }
    }
}

if (esPrimo)
{
    Console.WriteLine($"{numero} es un número primo.");
}
else
{
    Console.WriteLine($"{numero} no es un número primo.");
}