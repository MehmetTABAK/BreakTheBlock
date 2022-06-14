using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SonrakiSahne : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void BirSonrakiSahne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }


}
