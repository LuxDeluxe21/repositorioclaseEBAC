using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    //  VARIABLES GLOBALES (visibles por todos los métodos)
    int contadorEntero = 0;                     // Parte 1 - Punto 1
    float multiplicadorFloat = 1.0f;            // Parte 1 - Punto 1
    float a = 5.7f, b = 2.3f;                   // Parte 1 - Punto 2
    string palabra = "rojo";                    // Parte 1 - Punto 4
    float numeroParaConvertir = 3.1415926f;     // Parte 1 - Punto 5
    string nombreCompleto = "Luciano Moya Vasquez"; // Parte 1 - Punto 6

    void Start()
    {
        // PARTE 1 - PUNTO 2: Operación con casteo explícito
        float resultadoOperacion = a / b;
        int resultadoEntero = (int)resultadoOperacion;
        Debug.Log("Punto 2: Resultado de " + a + " / " + b + " = " + resultadoOperacion + " (Casteado a int: " + resultadoEntero + ")");

        // PARTE 1 - PUNTO 4: switch para cambiar color (impresión)
        Debug.Log("Punto 4: Palabra actual = " + palabra);
        switch (palabra)
        {
            case "rojo":
                Debug.Log("Color asignado: ROJO");
                break;
            case "verde":
                Debug.Log("Color asignado: VERDE");
                break;
            case "azul":
                Debug.Log("Color asignado: AZUL");
                break;
            default:
                Debug.Log("Color asignado: BLANCO (default)");
                break;
        }

        // PARTE 1 - PUNTO 5: Mostrar número con 4 decimales
        string numeroFormateado = numeroParaConvertir.ToString("F4");
        Debug.Log("Punto 5: Número original = " + numeroParaConvertir + " Formateado (4 decimales) = " + numeroFormateado);

        // PARTE 1 - PUNTO 6: Substring y Split
        string nombre1 = nombreCompleto.Substring(0, 7);
        string nombre2 = nombreCompleto.Substring(8, 4);
        string nombre3 = nombreCompleto.Substring(13);
        Debug.Log("Punto 6: Substring Parte 1: " + nombre1 + ", Parte 2: " + nombre2 + ", Parte 3: " + nombre3);

        string[] partes = nombreCompleto.Split(' ');
        Debug.Log("Punto 6: Split Partes del nombre completo:");
        foreach (string parte in partes)
        {
            Debug.Log(parte);
        }

        // PARTE 2 - PUNTO 1: TryParse con strings numéricos
        string valorTexto1 = "2500";
        string valorTexto2 = "1500";
        int numero1, numero2;

        bool exito1 = int.TryParse(valorTexto1, out numero1);
        bool exito2 = int.TryParse(valorTexto2, out numero2);

        if (exito1 && exito2)
        {
            int suma = numero1 + numero2;
            Debug.Log("Punto 1 Parte 2: Suma de " + numero1 + " + " + numero2 + " = " + suma);
        }
        else
        {
            Debug.Log("Punto 1 Parte 2: Error al convertir los valores a números.");
        }

        // PARTE 2 - PUNTO 2: Mostrar solo caracteres con índice par
        string oracion = "Hola Mundo";
        string caracteresPares = "";
        for (int i = 0; i < oracion.Length; i++)
        {
            if (i % 2 == 0)
            {
                caracteresPares += oracion[i];
            }
        }
        Debug.Log("Punto 2 Parte 2: Caracteres en índices pares: " + caracteresPares);

        // PARTE 2 - PUNTO 3: Eliminar primeros 5 caracteres
        string frase = "Unity es genial para aprender";
        string fraseSinPrimeros5 = frase.Substring(5);
        Debug.Log("Punto 3 Parte 2: Frase sin los primeros 5 caracteres: " + fraseSinPrimeros5);
    }

    void Update()
    {
        // PARTE 1 - PUNTO 1: contadorEntero aumenta cada frame
        contadorEntero++;
        Debug.Log("Punto 1: contadorEntero (Update): " + contadorEntero);
    }

    void FixedUpdate()
    {
        // PARTE 1 - PUNTO 1: multiplicadorFloat *= 1.01 cada FixedUpdate
        multiplicadorFloat *= 1.01f;
        Debug.Log("Punto 1: multiplicadorFloat (FixedUpdate): " + multiplicadorFloat);

        // PARTE 1 - PUNTO 3: módulo para saber si es par o impar
        if (contadorEntero % 2 == 0)
        {
            Debug.Log("Punto 3: " + contadorEntero + " es PAR");
        }
        else
        {
            Debug.Log("Punto 3: " + contadorEntero + " es IMPAR");
        }
    }
}
