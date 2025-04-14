using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CUBOAWAKE : MonoBehaviour
{
    public GameObject PrefabCUBOAWAKE;
    public List<GameObject> listadeCUBOAWAKE;
    public float factorDeEscalamiento;
    public int numCUBOAWAKE = 0;

    public bool estado = false;

    private void Awake()
    {
        listadeCUBOAWAKE = new List<GameObject>();

        numCUBOAWAKE++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCUBOAWAKE);
        tempGameObject.name = "CUBOAWAKENumero" + numCUBOAWAKE;
        tempGameObject.transform.position = Random.insideUnitSphere;

        listadeCUBOAWAKE.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listadeCUBOAWAKE)
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
            listadeCUBOAWAKE.Remove(go);
            Destroy(go);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        estado = !estado; // Cambia de true a false y viceversa

        if (estado)
        {
            GetComponent<Renderer>().material.color = Color.white;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.black;
        }
    }
}

