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
        SceneManager.LoadScene("B�l�mSe�me");
    }

    public void AnaMen�()
    {
        SceneManager.LoadScene("Giri�");
    }
}
