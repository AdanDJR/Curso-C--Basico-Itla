class Program
{
    static void Main()
    {
        DateTime hoy = DateTime.Now;
        int anio = hoy.Year, mes = hoy.Month;
        Console.WriteLine($"\n    {hoy.ToString("MMMM")} {anio}\n");
        Console.WriteLine("Mo Tu We Th Fr Sa Su");
        int diaSemana = (int)new DateTime(anio, mes, 1).DayOfWeek;
        Console.Write(new string(' ', diaSemana * 3));
        for (int dia = 1; dia <= DateTime.DaysInMonth(anio, mes); dia++)
        {
            Console.Write($"{dia,2} ");
            if ((diaSemana + dia) % 7 == 0) Console.WriteLine();
        }
    }
}
