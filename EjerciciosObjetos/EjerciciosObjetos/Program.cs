using System;

namespace EjerciciosObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche = new Coche("Renault","Laguna","Negro",120,5);
            Coche coche2 = new Coche();
           
            coche2.SetMarca("Ferrari");
            Console.WriteLine(coche2.GetMarca());
            coche2.Arrancar();        
            
        }
    }
}
