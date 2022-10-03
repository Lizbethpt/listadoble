using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listasdoblementeenlaadas2
{
    class MiLista
    {
        string dato;
        private Nodo head;
        //private Nodo ultimo;

        public Nodo Head
        {
            get { return head; }
            set { head = value; }
        }
        //public Nodo Ultimo
        //{
        //    get { return ultimo; }
        //    set { ultimo = value; }
        //}

        public MiLista()
        {
            head = null;
            
            //ultimo = null;
        }
        public void Agregar(Nodo n)
        {
            Nodo h = head;
            if (head == null)
            {
                head = n;
                return;
            }
            if (string.Compare(n.Dato, h.Siguiente.Dato) < 0 )
            {
                h.Siguiente = n;
                //n.Anterior = ultimo;
                //ultimo = n;
                return;
            }
            if (string.Compare(n.Dato, h.Anterior.Dato) < 0)
            {
                n.Anterior = head;
                head = n;

                return;
            }
            while (h.Siguiente != null)
            {
                if (string.Compare(n.Dato, h.Siguiente.Dato) < 0)
                {
                    break;
                }
                h = h.Siguiente;
            }
            n.Siguiente = h.Siguiente;
            h.Siguiente = n;

            while (h.Anterior != null)
            {
                if (string.Compare(n.Dato, h.Anterior.Dato) < 0)
                {
                    break;
                }
                h = h.Anterior;
            }
            n.Anterior = h.Anterior;
            h.Anterior = n;
        }


        public override string ToString()
        {
            Nodo h = head;
            string listadedatos = "";
            if (h != null)
            {
                while (h.Siguiente != null)
                {
                    listadedatos += h.ToString();
                    h = h.Siguiente;
                   
                }
              
            }
            return dato;
        }
        public bool Buscar (string nodo)
        {
            Nodo h = head;
            if (h != null)
            {
                return true;
            }
            if (dato == h.Siguiente.Dato)
            {
                return true; 
            }
           
            if (dato == h.Anterior.Dato)
            {
                return true;
            }
            return false;
            //if (dato == h.Anterior.Dato)
            //{
            //    return true;
            //}
          
        }
        public void Borrar(string nodo, string siguiente, string anterior)
        {
            Nodo h = head;
            while (h.Siguiente != null)
                if (string.Compare(dato, h.Siguiente.Dato) < 0)
                {
                    if (dato == head.Dato)
                    {
                        head = head.Siguiente;
                        return;
                    }
                    if (dato == h.Siguiente.Dato)
                    {
                        h.Siguiente = h.Siguiente.Siguiente;
                    }
                }
            while (h.Anterior != null)
                if (string.Compare(dato, h.Anterior.Dato) < 0)
                {
                    if (dato == head.Dato)
                    {
                        head = head.Anterior;
                        return;
                    }
                    if (dato == h.Anterior.Dato)
                    {
                        h.Anterior = h.Anterior.Anterior;
                    }
                }
            //head = head.Siguiente;
            //head.Siguiente = h.Siguiente;
            //h.Siguiente = null;
        }
    }
}
