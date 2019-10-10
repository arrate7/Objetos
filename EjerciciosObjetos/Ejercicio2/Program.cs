using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero = new Numero();
            Numero numero1 = new Numero(5);

            numero.Aniade();
            Console.WriteLine(numero.GetNumero());
            numero1.SetNumero(numero1.GetTriple());
            numero1.SetNumero(numero1.GetDoble());
            Console.WriteLine(numero1.GetNumero());

        }
    }
}
