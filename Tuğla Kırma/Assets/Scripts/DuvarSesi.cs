using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuvarSesi : MonoBehaviour
{
    public AudioClip ses;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(ses, transform.position);
    }
}
