using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubocolor : MonoBehaviour
{

    public GameObject PrefabCUBO;
    private void Awake()
    {
        PrefabCUBO = this.gameObject;
        Color c = new Color(Random.value, Random.value, Random.value);
        PrefabCUBO.GetComponent<MeshRenderer>().material.color = c;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
