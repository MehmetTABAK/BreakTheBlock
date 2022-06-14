using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BolumSecme : MonoBehaviour
{
    public void Start()
    {
        Tugla.tuglasayisi = 0;
    }
    public void Bolum1()
    {
        SceneManager.LoadScene("Bölüm1");
    }

    public void Bolum2()
    {
        SceneManager.LoadScene("Bölüm2");
    }

    public void Bolum3()
    {
        SceneManager.LoadScene("Bölüm3");
    }

    public void Bolum4()
    {
        SceneManager.LoadScene("Bölüm4");
    }

    public void Bolum5()
    {
        SceneManager.LoadScene("Bölüm5");
    }
}
