using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private float speed = 3.0f;
    private Rigidbody rb;
    private GameObject p;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        p = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ld = (p.transform.position-transform.position).normalized;
        rb.AddForce(ld*speed);
    }
}
