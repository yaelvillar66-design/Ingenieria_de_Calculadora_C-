using System;

namespace ArbolesAnalisis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hojas del árbol
            Nodo tres = new Nodo("3");
            Nodo cinco = new Nodo("5");
            Nodo dos = new Nodo("2");

            // Subárbol de la suma
            Nodo suma = new Nodo("+");
            suma.izquierda = tres;
            suma.derecha = cinco;

            // Raíz de la multiplicación
            Nodo raiz = new Nodo("*");
            raiz.izquierda = suma;
            raiz.derecha = dos;

            // Evaluación
            double resultado = Evaluar(raiz);
            Console.WriteLine("La expresion evaluada (3+5)*2 es igual a: " + resultado);
            Console.ReadLine(); // Pausa para ver el resultado en consola
        }

        static double Evaluar(Nodo nodo)
        {
            if (nodo.izquierda == null && nodo.derecha == null)
            {
                return double.Parse(nodo.valor);
            }

            double izquierda = Evaluar(nodo.izquierda);
            double derecha = Evaluar(nodo.derecha);

            switch (nodo.valor)
            {
                case "+": return izquierda + derecha;
                case "-": return izquierda - derecha;
                case "*": return izquierda * derecha;
                case "/":
                    if (derecha == 0) throw new DivideByZeroException("No se puede dividir entre cero");
                    return izquierda / derecha;
                default:
                    throw new ArgumentException("Operador desconocido: " + nodo.valor);
            }
        }
    }
}