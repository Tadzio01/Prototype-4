using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject fp;
    private Rigidbody rb;
    private float speed = 150;
    private bool hp;
    private float pstrength = 10;
    private GameObject pin;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fp = GameObject.Find("FocalPoint");
        pin = GameObject.Find("PowerupIndicator");
        pin.SetActive(false);
    }

    void Update()
    {
        float fi = Input.GetAxis("Vertical");
        rb.AddForce(fp.transform.forward*fi*speed*Time.deltaTime);
        pin.transform.position = transform.position-new Vector3(0,0.5f,0);
    }

    private void OnTriggerEnter(Collider other){
        if(other.CompareTag("Powerup")){
            hp = true;
            Destroy(other.gameObject);
            pin.gameObject.SetActive(true);
            StartCoroutine(pcr());
        }
    }
    IEnumerator pcr(){
        yield return new WaitForSeconds(7);
        hp = false;
        pin.gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Enemy") && hp){
            Rigidbody erb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 afp = collision.gameObject.transform.position-transform.position;
            erb.AddForce(afp*pstrength, ForceMode.Impulse);

        }
    }
}