using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenNum
{
    class Nodo
    {
        private int valor;
        private Nodo siguiente = null;

        public int Valor { get => valor; set => valor = value; }
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }

        public override string ToString()
        {
            return string.Format("[{0}]", Valor);
        }
    }
}
