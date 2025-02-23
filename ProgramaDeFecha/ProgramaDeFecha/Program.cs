class Program
{
    static void Main()
    {
        Console.Write("Ingresa tu fecha de nacimiento (YYYY-MM-DD): ");
        string fecha = Console.ReadLine();

        if (DateTime.TryParse(fecha, out DateTime fechaNacimiento))
        {
            Console.WriteLine($"Naciste un {fechaNacimiento.ToString("dddd")}");
        }
        else
        {
            Console.WriteLine("Pon el formato correcto");
        }
    }
}





