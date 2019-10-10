using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3
{
    class Satelite
    {
        private double meridiano;
        private double paralelo;
        private double distancia_tierra;
        public Satelite(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }
        public Satelite()
        {
            meridiano = paralelo = distancia_tierra = 0;
        }
        public void SetPosicion(double m, double p, double d)
        {
            meridiano = m;
            paralelo = p;
            distancia_tierra = d;
        }
        public void PrintPosicion()
        {
            Console.WriteLine($"El satélite se encuentra en el paralelo  {paralelo} Meridiano {meridiano} a una distancia de la tierra de {distancia_tierra} Kilómetros");
            Console.ReadLine();
        }
        //Este método acepta un parámetro 
        // que será positivo o negativo dependiendo de si el satélite tiene que alejarse 
        //o acercarse a La Tierra.
        public void VariaAltura(double desplazamiento)
        {
            this.distancia_tierra += desplazamiento;
        }
        //Método bool EnOrbita(): Este método 
        //devolverá false si el satélite está en tierra, 
        // y true en caso contrario.
        public bool EnOrbita()
        {
            if (distancia_tierra > 0)
            {
                return true;
            }
            return false;

        }
        //Método void VariaPosicion(double variap, double variam): 
        //    Este método permite modificar los atributos de posición
        //    (meridiano y paralelo) mediante los parámetros variap y variam.
        //    Estos parámetros serán valores positivos o negativos relativos que 
        //        harán al satélite modificar su posición.
        public void VariaPosicion(double variap, double variam)
        {
            meridiano  += variam;
            paralelo += variap;
        }
    }
}
