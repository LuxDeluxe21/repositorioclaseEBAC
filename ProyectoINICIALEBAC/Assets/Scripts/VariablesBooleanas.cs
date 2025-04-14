using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{

    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;

    // A B OR AND ((A or B) and C)
    // 1 1  1  1
    // 1 0  1  0
    // 0 1  1  0
    // 0 0  0  0
    //

    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        if ((variable1 || variable2) && variable3)
        {
            Debug.Log("la operación dio resultado verdadero");
        }
        else
        {
            Debug.Log("la operación dio resultado Falso");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
