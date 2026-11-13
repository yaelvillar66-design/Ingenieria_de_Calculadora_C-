using System;

namespace ArbolesAnalisis
{
    public class Nodo
    {
        public string valor;
        public Nodo izquierda;
        public Nodo derecha;

        public Nodo(string valor)
        {
            this.valor = valor;
            this.izquierda = null;
            this.derecha = null;
        }
    }
}