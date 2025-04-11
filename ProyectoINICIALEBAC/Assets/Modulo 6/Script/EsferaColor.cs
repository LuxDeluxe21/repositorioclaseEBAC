using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaColor : MonoBehaviour
{

    public GameObject PrefabESFERA;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PrefabESFERA = this.gameObject;
        Color cb= new Color(Random.value, Random.value, Random.value);
        PrefabESFERA.GetComponent<MeshRenderer>().material.color = cb;
    }
}