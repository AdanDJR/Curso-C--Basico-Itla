using System.Globalization;
using System.Runtime.InteropServices;
using ConsoleApp1;

Console.WriteLine("Welcome to calculate");
var calculadora = new Calculadora();
bool bucle = true;
while (bucle)
{
    Console.WriteLine(@"
      Elige la opcion que quieres usar:

      1- Sumar

      2- Restar

      3- Multiplicar

      4- Dividir

      5- Elevar un numero a la potencia

      6- Salir");
    int elecion = 0;
    try 
    { 
        
         elecion = Convert.ToInt32(Console.ReadLine()); 
    
    }
    catch(Exception e) {
        Console.WriteLine("Has ingresado una opcion incorrecta, elige de nuevo " + e.Message);
       
    }
    switch (elecion)
    {
        case 1:
            double resultadoSuma = calculadora.sumar();
            Console.WriteLine($"El resultado de la suma es: {resultadoSuma}");
            break;

            case 2:
            double resultadoResta = calculadora.restar();
            Console.WriteLine($"El resultado de la resta es: {resultadoResta}");
            break;

        case 3:
            double resultadoMultiplicacion = calculadora.multiplicar();
            Console.WriteLine($"El resultado de la multiplicacion es: {resultadoMultiplicacion}");
            break;

            case 4:
            double resultadoDividir = calculadora.dividir();
            
            Console.WriteLine($"El resultado de la dividir es: {resultadoDividir}");
            break;
            case 5:
            double resultadoPotencia = calculadora.elevarAPotencia();
            Console.WriteLine($"El resultado de la suma es: {resultadoPotencia}");
            break;

            case 6:
                bucle = false;
            break;
        default:
            break;
    }




}
