using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject fp;
    private Rigidbody rb;
    private float speed = 150;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fp = GameObject.Find("FocalPoint");
    }

    void Update()
    {
        float fi = Input.GetAxis("Vertical");
        rb.AddForce(fp.transform.forward*fi*speed*Time.deltaTime);
    }
}