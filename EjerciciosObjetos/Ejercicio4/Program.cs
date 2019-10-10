using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Peso peso1 = new Peso(20, "li");

            Peso peso2 = new Peso(12, "q");
            Peso peso3 = new Peso(120, "g");

            Console.WriteLine($"{peso1.GetKilogramos()} kg son: {peso1.GetLibras()} libras" );
            Console.WriteLine($"{peso2.GetKilogramos()} kg son: {peso2.GetLingotes()} lingotes" );
            Console.WriteLine($"{peso3.GetKilogramos()} kg son: {peso3.GetPeso("oz")} onzas" );
            Console.WriteLine(peso1.GetLingotes());
        }
    }
}
