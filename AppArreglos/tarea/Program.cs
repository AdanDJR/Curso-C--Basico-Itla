 Console.WriteLine("Vamos a digitar 10 numeros y luego ordenarlos de menor a mayor");
 double[] arreglos = new double[10];

for (int i = 0; i < arreglos.Length; i++)
{
    Console.Write($"Digite el número {i + 1}: ");
    arreglos[i] = double.Parse(Console.ReadLine());
}
 Array.Sort(arreglos);

Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
foreach (double num in arreglos)
{
   Console.WriteLine(num);
}


