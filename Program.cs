using POO_TP;
using System;
using System.Collections.Generic;

namespace EstacionMeteorologicaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de la Estación Meteorológica
            EstacionMeteorologica estacion = new EstacionMeteorologica();
            estacion.VerTemperaturas(2, 1); //VER TEMPERATURAS DE UN DÍA EN ESPECIFICO

            double promedio = estacion.verPromedioTotal();
            Console.WriteLine($"Promedio total de temperaturas: {promedio}°C"); // VER EL PROMEDIO MENSUAL DE TEMPERATURAS


            double promedioSemanal = estacion.verPromedioSemanal(2);
            Console.WriteLine($"El promedio de la semana que indicaste es de {promedioSemanal}°C");
        }
    }
}