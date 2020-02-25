using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    private float range = 9;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab,gen(),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 gen(){
        float x = Random.Range(-range,range);
        float z = Random.Range(-range,range);
        return new Vector3(x,0,z);
    }

}
