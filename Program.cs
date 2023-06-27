using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenNum
{
    class Program
    {
        private static ListaLigada miLista = new ListaLigada();
        static void Main(string[] args)
        {
            miLista.Agregar(3);
            miLista.Agregar(15);
            miLista.Agregar(7);
            miLista.Agregar(19);
            miLista.Agregar(11);
            miLista.Agregar(1);

            Console.WriteLine("Se agregan valores");
            miLista.Transversa();
            QuickSort(0, miLista.Cantidad() - 1);
            Console.WriteLine("Se acomodan valores por metodo Quick sort");
            miLista.Transversa();
            
            Console.ReadKey();
        }
        private static void Swap(int i1, int i2)
        {
            int temp = miLista[i1];
            miLista[i1] = miLista[i2];
            miLista[i2] = temp;
        }

        public static int Particion(int pInicio, int pFin)
        {
            int pivote = 0;
            int iPivote = 0;
            int n = 0;

            //Seleccionamos el ultimo pivote
            pivote = miLista[pFin];
            //Ponemos el indice de pivote con el indice de inicio
            iPivote = pInicio;
            //Recorremos la lista en el fragmento indicado
            for (n = pInicio; n< pFin; n++)
            {
                //Si el elemento en el indice n es menor o igual al pivote
                if (miLista[n] <= pivote)
                {
                    //Intercambiamos el elemento en n con el que se encuentre en el indice de pivote
                    Swap(n, iPivote);
                    //Incrementamos el indice del pivote
                    iPivote++;
                }
            }
            //Hacemos el swap final para colocar el pivote donde corresponde
            Swap(iPivote, pFin);

            //Regresamos el indice del pivote
            return iPivote;
        }
        public static void QuickSort(int pInicio, int pFin)
        {
            int iPivote = 0;
            //Caso base, un elemento o fragmento invalido
            if (pInicio >= pFin)
                return;
            //Obtenemos el indice del pivote para el fragmento con el que trabajamos
            iPivote = Particion(pInicio, pFin);
            //Casos inductivos
            QuickSort(pInicio, iPivote - 1); //Fragmento a la izq del pivote
            QuickSort(iPivote + 1, pFin); //Fragmento a la der del pivote

        }
        
    }
}
