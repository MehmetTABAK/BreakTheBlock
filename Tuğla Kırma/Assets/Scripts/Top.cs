using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Top : MonoBehaviour
{
    private GameObject pedal;
    private bool oyunbasladi = false;
    void Start()
    {
        pedal = GameObject.FindObjectOfType<Pedal>().gameObject;
    }

  
    void Update()
    {
        if (!oyunbasladi)
        {
            transform.position = new Vector3(pedal.transform.position.x, transform.position.y, transform.position.z);
        }
        if (Input.GetMouseButtonDown(0) && !oyunbasladi)
        {
            oyunbasladi = true;
            GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-2f,2f), 5f);
        }
    }
}
