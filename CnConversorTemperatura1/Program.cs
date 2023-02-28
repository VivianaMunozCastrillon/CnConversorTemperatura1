using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CnConversorTemperatura1
{
    internal class Program
    {
        /// <summary>
        /// Nombre:Viviana Muñoz
        /// Fecha:26/02/2023
        /// Descripcion:Este programa solicita la temperatura y la convierte ya sea a grados Celcius o Farenheit.
        /// </summary>
        static void Main(string[] args)
        {
            //Solicita datos de ingreso
            Console.WriteLine("ingrese la temperatura a convertir");
            double Temperatura = double.Parse(Console.ReadLine());
            Console.WriteLine("digite la unidad de temperatura ingresada");
            Console.WriteLine("(1 Celcius");
            Console.WriteLine("(2 Farenheit");
            double Unidad = double.Parse(Console.ReadLine());

            //condicional
            if (Unidad == 1)
            {
                Console.WriteLine("la temperatura en grados farenheit es:" + ConvertirCelciuls(Temperatura));

            }
            else if (Unidad == 2)
            {
                Console.WriteLine("la temperatura en grados celsius es:" + ConvertirFarenheit(Temperatura));
            }
            else
            {
                Console.WriteLine("Unidad de temperatura no reconocida.");
            }

            Console.ReadKey();


        }

        //Metodos
        //convierte celcius a farenheit
        static double ConvertirCelciuls(double temperatura)
        {
            double Farenheit = (temperatura * 1.8) + 32;
            return Farenheit;
        }
        //convierte de farenheit a celsius
        static double ConvertirFarenheit(double temperatura)
        {
            double Celsius = (temperatura - 32) / 1.8;
            return Celsius;
        }
    }
    }

