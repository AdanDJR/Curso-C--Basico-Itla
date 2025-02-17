using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Calculadora
    {
        internal double sumar()
        {
            double numero1 = 0;
            double numero2 = 0;
            double resultado = 0;
            try
            {
                Console.WriteLine("Ingresa el numero 1");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresa el numero 2");
                numero2 = Convert.ToDouble(Console.ReadLine());
                resultado = numero1 + numero2;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Has ingresado una letra, tendras que comenzar de nuevo " + e.Message);
            }
            return resultado;

        }
        internal double restar()
        {

            double numero1 = 0;
            double numero2 = 0;
            double resultado = 0;
            try
            {
                Console.WriteLine("Ingresa el numero 1");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresa el numero 2");
                numero2 = Convert.ToDouble(Console.ReadLine());
                resultado = numero1 - numero2;

            }
            catch (Exception e)
            {
                Console.WriteLine("Has ingresado una letra, tendras que comenzar de nuevo " + e.Message);
            }
            return resultado;

        }
       internal double multiplicar()
        {
            double numero1 = 0;
            double numero2 = 0;
            double resultado = 0;
            try
            {
                Console.WriteLine("Ingresa el numero 1");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresa el numero 2");
                numero2 = Convert.ToDouble(Console.ReadLine());
                resultado = numero1 * numero2;

            }
            catch (Exception e)
            {
                Console.WriteLine("Has ingresado una letra, tendras que comenzar de nuevo " + e.Message);
            }
            return resultado;


        }
        internal double dividir()
        {

            double numero1 = 0;
            double numero2 = 0;
            double resultado = 0;
            try
            {
                Console.WriteLine("Ingresa el numero 1");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresa el numero 2");
                numero2 = Convert.ToDouble(Console.ReadLine());
                if (numero2 == 0)
                {
                    Console.WriteLine("No se puede dividir en 0");
                    return 0;
                }
                else { 
                resultado = numero1 / numero2;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Has ingresado una letra, tendras que comenzar de nuevo " + e.Message);
            }
            return resultado;

        }
        internal double elevarAPotencia()
        {
            double baseNumero = 0;
            double exponente = 0;
            double resultado = 0;
            try
            {
                Console.WriteLine("Ingresa la base:");
                baseNumero = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingresa el exponente:");
                exponente = Convert.ToDouble(Console.ReadLine());

                resultado = Math.Pow(baseNumero, exponente);
            }
            catch (Exception e)
            {
                Console.WriteLine("Has ingresado una letra, tendrás que comenzar de nuevo. " + e.Message);
            }
            return resultado;
        }
    }
}
