// Tarea Semana 6

// Ejercicio 2

using System;

public class Nodo
{
    public int Valor;
    public Nodo Siguiente;

    public Nodo(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    public Nodo Cabeza;

    // Método para agregar un elemento a la lista
    public void Agregar(int valor)
    {
        Nodo nuevoNodo = new Nodo(valor);
        if (Cabeza == null)
        {
            Cabeza = nuevoNodo;
        }
        else
        {
            Nodo actual = Cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevoNodo;
        }
    }

    // Método para imprimir la lista
    public void Imprimir()
    {
        Nodo actual = Cabeza;
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    // Método para invertir la lista
    public void Invertir()
    {
        Nodo anterior = null;
        Nodo actual = Cabeza;
        Nodo siguiente = null;

        while (actual != null)
        {
            siguiente = actual.Siguiente;  // Guardamos el siguiente nodo
            actual.Siguiente = anterior;   // Invertimos el puntero
            anterior = actual;             // Movemos el puntero anterior a este nodo
            actual = siguiente;            // Avanzamos al siguiente nodo
        }

        Cabeza = anterior; // La cabeza ahora es el nodo anterior al último
    }

    // Método para buscar un valor en la lista y contar cuántas veces aparece
    public void BuscarYContar(int valor)
    {
        Nodo actual = Cabeza;
        int contador = 0;

        while (actual != null)
        {
            if (actual.Valor == valor)
            {
                contador++;
            }
            actual = actual.Siguiente;
        }

        if (contador > 0)
        {
            Console.WriteLine($"El valor {valor} aparece {contador} veces en la lista.");
        }
        else
        {
            Console.WriteLine($"El valor {valor} no fue encontrado en la lista.");
        }
    }
}

class Program
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();
        lista.Agregar(1);
        lista.Agregar(2);
        lista.Agregar(3);
        lista.Agregar(2);
        lista.Agregar(4);
        lista.Agregar(2);

        Console.WriteLine("Lista:");
        lista.Imprimir();

        // Buscar y contar las veces que aparece un valor
        lista.BuscarYContar(2); // Buscar el número 2
        lista.BuscarYContar(5); // Buscar el número 5
    }
}


// Universidad Estatal Amazónica
// Andrés Ponce M.
