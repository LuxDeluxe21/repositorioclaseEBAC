using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBOON : MonoBehaviour
{
    public GameObject PrefabCUBOON;
    public List<GameObject> listadeCUBOON;
    public float factorDeEscalamiento;
    public int numCUBOON = 0;

    // Start is called before the first frame update
    void Start()
    {
        listadeCUBOON = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {
        numCUBOON++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCUBOON);
        tempGameObject.name = "CUBOONNumero" + numCUBOON;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listadeCUBOON.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listadeCUBOON)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (factorDeEscalamiento <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }

        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listadeCUBOON.Remove(go);
            Destroy(go);
        }

    }
    private void OnDisable()
    {
        numCUBOON++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCUBOON);
        tempGameObject.name = "CUBOONNumero" + numCUBOON;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listadeCUBOON.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listadeCUBOON)
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (factorDeEscalamiento <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }

        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listadeCUBOON.Remove(go);
            Destroy(go);
        }

    }
}
