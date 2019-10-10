using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Finanzas finanzas = new Finanzas();
            Finanzas finanzas2 = new Finanzas(0.8);
            Console.WriteLine($"5 euros son: {finanzas.EurosToDolares(5)} dólares.");
            Console.WriteLine($"8 dólares son: {finanzas2.DolaresToEuros(8)} euros.");
        }
    }
}
