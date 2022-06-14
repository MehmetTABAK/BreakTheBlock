using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
    private float hareket;
    public float hareketHizi=500f;
    //private GameObject top;
    Rigidbody2D rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        hareket = Input.GetAxis("Horizontal");
        //top = GameObject.Find("top");
    }


    void Update()
    {
        Vector3 farepos = Camera.main.ScreenToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
        //transform.position = new Vector3(farepos.x, transform.position.y, transform.position.z);
        //transform.position = new Vector3(top.transform.position.x, transform.position.y, transform.position.z);
        rb.velocity = new Vector2(hareket * hareketHizi * Time.deltaTime, rb.velocity.y);
    }
    public void SolButon()
    {
        hareket = -0.5f;
    }
    
    public void SaðButon()
    {
        hareket = +0.5f;
    }

    public void Stop()
    {
        hareket = 0;
    }
}
