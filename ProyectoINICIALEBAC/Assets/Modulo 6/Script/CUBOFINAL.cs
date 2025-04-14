using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBOFINAL : MonoBehaviour
{
    public GameObject PrefabCUBOFINAL;
    public List<GameObject> listadeCUBOFINAL;
    public float factorDeEscalamiento;
    public int numCUBOFINAL = 0;

    private bool estado = false;

    // Referencias al cubo AND (CUBOON) y al cubo OR (CUBOOR)
    public CUBOON cuboAND;
    public CUBOOR cuboOR;

    void Start()
    {
        listadeCUBOFINAL = new List<GameObject>();
        GetComponent<Renderer>().material = new Material(GetComponent<Renderer>().material);
    }

    void FixedUpdate()
    {
        if (cuboAND != null && cuboOR != null)
        {
            // OR entre los estados de los dos cubos anteriores
            if (cuboAND.estado || cuboOR.estado)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }

            // Cambiar color según el estado
            if (estado)
            {
                GetComponent<Renderer>().material.color = Color.magenta;
            }
            else
            {
                GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
    }

    private void OnEnable()
    {
        numCUBOFINAL++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCUBOFINAL);
        tempGameObject.name = "CUBOFINALNumero" + numCUBOFINAL;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listadeCUBOFINAL.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listadeCUBOFINAL)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (factorDeEscalamiento <= 0.1f)
            {
                objetosParaEliminar.Add(go);
            }
        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listadeCUBOFINAL.Remove(go);
            Destroy(go);
        }
    }

    private void OnDisable()
    {
        numCUBOFINAL++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCUBOFINAL);
        tempGameObject.name = "CUBOFINALNumero" + numCUBOFINAL;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listadeCUBOFINAL.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listadeCUBOFINAL)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (factorDeEscalamiento <= 0.1f)
            {
                objetosParaEliminar.Add(go);
            }
        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listadeCUBOFINAL.Remove(go);
            Destroy(go);
        }
    }
}
