using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2
{
    class Numero
    {
        private int numero;

        public Numero()
        {         
        }

        public Numero(int numero)
        {
            this.numero = numero;
        }

        public int GetNumero()
        {
            return numero;
        }
        public void SetNumero(int numero)
        {
            this.numero = numero;
        }

        public void Aniade()
        {
            numero++;
        }
        public void Resta()
        {
            numero--;
        }
        public int GetDoble()
        {
            return numero * 2;
        }
        public int GetTriple()
        {
            return numero * 3;
        }
    }
}
