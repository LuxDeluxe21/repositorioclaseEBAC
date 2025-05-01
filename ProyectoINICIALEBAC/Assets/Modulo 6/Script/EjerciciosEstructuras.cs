using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    void Start()
    {
        // 1. Lista de números aleatorios
        var listaAleatoria = GenerarNumerosAleatorios(10, 1, 100);
        Debug.Log("Lista Aleatoria: " + string.Join(", ", listaAleatoria));

        // 2. Ordenar descendente
        var ordenadaDesc = OrdenarDescendente(listaAleatoria.ToArray());
        Debug.Log("Ordenada Descendente: " + string.Join(", ", ordenadaDesc));

        // 3. Eliminar repetidos usando HashSet
        var listaConRepetidos = new List<string> { "manzana", "pera", "manzana", "uva", "pera", "kiwi" };
        var sinRepetidos = EliminarRepetidos(listaConRepetidos);
        Debug.Log("Sin Repetidos: " + string.Join(", ", sinRepetidos));

        // 4. Pila y cola
        Stack<string> pila = new Stack<string>();
        pila.Push("Primero");
        pila.Push("Segundo");
        pila.Push("Tercero");
        ImprimirPilaYCola(pila);
    }

    // 1
    public List<int> GenerarNumerosAleatorios(int tamaño, int rangoInferior, int rangoSuperior)
    {
        List<int> numeros = new List<int>();
        for (int i = 0; i < tamaño; i++)
        {
            int aleatorio = Random.Range(rangoInferior, rangoSuperior + 1); // incluye rangoSuperior
            numeros.Add(aleatorio);
        }
        return numeros;
    }

    // 2
    public int[] OrdenarDescendente(int[] arreglo)
    {
        List<int> lista = new List<int>(arreglo);
        lista.Sort((a, b) => b.CompareTo(a)); // Orden descendente
        return lista.ToArray();
    }

    // 3
    public HashSet<string> EliminarRepetidos(List<string> listaOriginal)
    {
        return new HashSet<string>(listaOriginal); // HashSet elimina automáticamente duplicados
    }

    // 4
    public void ImprimirPilaYCola(Stack<string> pila)
    {
        Debug.Log("Contenido de la pila:");
        foreach (string s in pila)
        {
            Debug.Log(s);
        }

        Queue<string> cola = new Queue<string>();

        Debug.Log("Copiando elementos de la pila a la cola...");
        foreach (string s in pila)
        {
            cola.Enqueue(s);
        }

        Debug.Log("Contenido de la cola:");
        while (cola.Count > 0)
        {
            string elemento = cola.Dequeue();
            Debug.Log(elemento);
        }
    }
}
