using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buton : MonoBehaviour
{
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void OyunSahnesi()
    {
        SceneManager.LoadScene("BölümSeçme");
    }

    public void AnaMenü()
    {
        SceneManager.LoadScene("Giriþ");
    }
}
