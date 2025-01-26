Console.WriteLine("Serie de Fibonacci del 1 al 50:");

int a = 0, b = 1, fibo;

Console.WriteLine(b); // Imprimimos el primer número (1)

while (true)
{
    fibo = a + b; // Calculamos el siguiente número en la serie
    if (fibo > 50) break; // Si supera 50, terminamos
    Console.WriteLine(fibo); // Imprimimos el número
    a = b; // Actualizamos el valor de 'a'
    b = fibo; // Actualizamos el valor de 'b'
}
    