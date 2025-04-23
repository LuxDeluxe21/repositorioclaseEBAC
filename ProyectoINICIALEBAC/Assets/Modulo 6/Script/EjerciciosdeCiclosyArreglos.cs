using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosdeCiclosyArreglos : MonoBehaviour
{
    void Start()
    {
        // 1) Suma de dos arreglos unidimensionales
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        int[] arr3 = new int[10];

        for (int i = 0; i < 10; i++)
        {
            arr1[i] = Random.Range(1, 10);
            arr2[i] = Random.Range(1, 10);
            arr3[i] = arr1[i] + arr2[i];
        }

        Debug.Log("Ejercicio 1 - Suma de dos arreglos:");
        for (int i = 0; i < 10; i++)
        {
            Debug.Log($"arr1[{i}] = {arr1[i]}, arr2[{i}] = {arr2[i]}, arr3[{i}] = {arr3[i]}");
        }

        // 2) Concatenación de strings con foreach
        string[] palabras = { "Hola", "mi", "nombre", "es", "Luciano" };
        string oracion = "";

        foreach (string palabra in palabras)
        {
            oracion += palabra + " ";
        }

        Debug.Log("Ejercicio 2 - Oración completa:");
        Debug.Log(oracion.Trim());

        // 3) Multiplicación de matriz por vector
        int[,] matriz = new int[2, 3] { { 2, 4, 1 }, { 3, 5, 2 } };
        int[] vector = new int[3] { 1, 2, 3 };
        int[] resultado = new int[2];

        for (int i = 0; i < 2; i++) // filas
        {
            resultado[i] = 0;
            for (int j = 0; j < 3; j++) // columnas
            {
                resultado[i] += matriz[i, j] * vector[j];
            }
        }

        Debug.Log("Ejercicio 3 - Resultado de la multiplicación matriz * vector:");
        for (int i = 0; i < resultado.Length; i++)
        {
            Debug.Log($"Resultado[{i}] = {resultado[i]}");
        }
    }

    void Update()
    {

    }
}

