using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBOSPAWNER : MonoBehaviour
{
    public GameObject PrefabCUBOSPAWNER;
    public List<GameObject> listadeCUBOSPAWNER;
    public float factorDeEscalamiento;
    public int numCUBOSPAWNER = 0;

    public bool estado = false;

    // Start is called before the first frame update
    void Start()
    {
        listadeCUBOSPAWNER = new List<GameObject>();
        GetComponent<Renderer>().material = new Material(GetComponent<Renderer>().material);
    }
    void FixedUpdate()
    {
        // Alternar el valor booleano
        estado = !estado;

        // Cambiar color según el valor de estado
        if (estado)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
    }

    // Update is called once per frame
    void Update()
    {
        numCUBOSPAWNER++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCUBOSPAWNER);
        tempGameObject.name = "CUBOSPAWNERNumero" + numCUBOSPAWNER;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listadeCUBOSPAWNER.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listadeCUBOSPAWNER)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if(factorDeEscalamiento <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
        
        }

        foreach(GameObject go in objetosParaEliminar)
        {
            listadeCUBOSPAWNER.Remove(go);
            Destroy(go);
        }
    }
}
