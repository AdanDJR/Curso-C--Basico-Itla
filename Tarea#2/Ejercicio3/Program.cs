using System;
class Program
{
    static void Main()
    {

        // Solicitar valores de a, b y c al usuario

        Console.WriteLine("Introduce el valor de 'a':");

        double a = Convert.ToDouble(Console.ReadLine());



        Console.WriteLine("Introduce el valor de 'b':");

        double b = Convert.ToDouble(Console.ReadLine());



        Console.WriteLine("Introduce el valor de 'c':");

        double c = Convert.ToDouble(Console.ReadLine());



        // Verificar que a no sea 0 (ya que no se puede dividir entre 0)

        if (a == 0)

        {

            Console.WriteLine("El valor de 'a' no puede ser 0.");

            return;

        }



        // Calcular el discriminante

        double discriminante = (b * b) - (4 * a * c);



        // Determinar si hay soluciones reales

        if (discriminante < 0)

        {

            Console.WriteLine("No hay soluciones reales.");

        }

        else

        {

            // Calcular las dos soluciones

            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);

            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);



            Console.WriteLine($"Las soluciones son: x1 = {x1} y x2 = {x2}");

        }

    }

}
