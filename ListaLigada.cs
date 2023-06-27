using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenNum
{
    class ListaLigada
    {
        private Nodo nodoInicial;
        private Nodo trabajo;
        private Nodo trabajo2;

        public ListaLigada()
        {
            nodoInicial = new Nodo();
            nodoInicial.Siguiente = null;
        }

        public void Transversa()
        {
            trabajo = nodoInicial;
            while(trabajo.Siguiente!=null)
            {
                trabajo = trabajo.Siguiente;
                int d = trabajo.Valor;
                Console.Write("{0}, ", d);
            }
            Console.WriteLine();
        }
        
        public void Agregar(int valor)
        {
            Nodo nodoActual = nodoInicial;

            while (nodoActual.Siguiente != null)
            {
                nodoActual = nodoActual.Siguiente;

            }
            Nodo temp = new Nodo();
            temp.Valor = valor;

            nodoActual.Siguiente = temp;
        }

        public int Cantidad()
        {
            trabajo = nodoInicial;
            int n = 0;
            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                n++;
            }
            return n;
        }
        
        public Nodo ObtenerPorIndice(int pIndice)
        {
            Nodo trabajo2 = null;
            int indice = -1;
            trabajo = nodoInicial;
            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                indice++;
                if (indice == pIndice)
                {
                    trabajo2 = trabajo;
                }
            }
            return trabajo2;
        }
        public int this[int pIndice]
        {
            get
            {
                trabajo = ObtenerPorIndice(pIndice);
                return trabajo.Valor;
            }
            set
            {
                trabajo = ObtenerPorIndice(pIndice);
                if (trabajo != null)
                {
                    trabajo.Valor = value;
                }
            }

        }
    }
}
