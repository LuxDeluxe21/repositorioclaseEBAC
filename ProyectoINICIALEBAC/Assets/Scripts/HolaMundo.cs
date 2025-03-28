using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    private int x;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        print("algo paso");

        Debug.LogWarning("Algo Salio Medianamente Mal");
        Debug.LogError("Algo Salio Muy mal");
    }

    // Update is called once per frame
    void Update()
    {
        //X = X + 1;
        //Debug.Log(X);

        Debug.Log("Hola desde Update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El Objeto ha sido Habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("El objeto ha sido inhabilitado");
    }
}
