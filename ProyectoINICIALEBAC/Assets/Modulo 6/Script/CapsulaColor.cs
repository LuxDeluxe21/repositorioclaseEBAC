using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaColor : MonoBehaviour
{
    public GameObject PrefabCAPSULA;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        PrefabCAPSULA = this.gameObject;
        Color ca= new Color(Random.value, Random.value, Random.value);
        PrefabCAPSULA.GetComponent<MeshRenderer>().material.color = ca;
    }
}
