using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBOOR : MonoBehaviour
{
    public GameObject PrefabCUBOOR;
    public List<GameObject> listadeCUBOOR;
    public float factorDeEscalamiento;
    public int numCUBOOR = 0;

    // Variable booleana propia
    public bool estado = false;

    // Referencias a los otros GameObjects
    public CUBOAWAKE cuboAwakeScript;
    public CUBOSPAWNER cuboSpawnerScript;

    void Start()
    {
        listadeCUBOOR = new List<GameObject>();

        // Clonar el material para que se pueda modificar el color sin afectar a otros
        GetComponent<Renderer>().material = new Material(GetComponent<Renderer>().material);
    }

    void FixedUpdate()
    {
        if (cuboAwakeScript != null && cuboSpawnerScript != null)
        {
            // Usamos OR: verdadero si al menos uno lo es
            if (cuboAwakeScript.estado || cuboSpawnerScript.estado)
            {
                estado = true;
            }
            else
            {
                estado = false;
            }

            // Cambiar el color según el estado
            if (estado)
            {
                GetComponent<Renderer>().material.color = Color.green;
            }
            else
            {
                GetComponent<Renderer>().material.color = Color.gray;
            }
        }
    }

    private void OnEnable()
    {
        numCUBOOR++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCUBOOR);
        tempGameObject.name = "CUBOORNumero" + numCUBOOR;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listadeCUBOOR.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listadeCUBOOR)
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
            listadeCUBOOR.Remove(go);
            Destroy(go);
        }
    }

    private void OnDisable()
    {
        numCUBOOR++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCUBOOR);
        tempGameObject.name = "CUBOORNumero" + numCUBOOR;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listadeCUBOOR.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listadeCUBOOR)
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
            listadeCUBOOR.Remove(go);
            Destroy(go);
        }
    }
}
