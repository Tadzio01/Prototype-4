using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject prefab;
    public GameObject powerup;
    private int count;
    private int wn = 1;
    private float range = 9;
    // Start is called before the first frame update
    void Start()
    {
        spawn(wn);
        Instantiate(powerup,gen(),Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        count = FindObjectsOfType<EnemyFollow>().Length;
        if(count == 0){
            wn++;
            spawn(wn);
            Instantiate(powerup,gen(),Quaternion.identity);
        }
    }
    void spawn(int num){
        for(int i = 0; i < num; i++){
            Instantiate(prefab,gen(),Quaternion.identity);
        }
    }
    private Vector3 gen(){
        float x = Random.Range(-range,range);
        float z = Random.Range(-range,range);
        return new Vector3(x,0,z);
    }

}
