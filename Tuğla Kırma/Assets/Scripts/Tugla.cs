using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tugla : MonoBehaviour
{
    public AudioClip ses1;
    public AudioClip ses2;
    public static int tuglasayisi;
    public Sprite[] tuglaSprite;
    private int maxcarma;
    private int carpma;
    void Start()
    {
        maxcarma = tuglaSprite.Length + 1;
        tuglasayisi++;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("top"))
        {
            carpma++;
            if (carpma >= maxcarma)
            {
                tuglasayisi--;
                Destroy(this.gameObject);
                if (tuglasayisi<=0)
                {
                    GameObject.FindObjectOfType<SonrakiSahne>().GetComponent<SonrakiSahne>().BirSonrakiSahne();
                }
                AudioSource.PlayClipAtPoint(ses1, transform.position);
            }
            else
            {
                AudioSource.PlayClipAtPoint(ses2, transform.position);
                GetComponent<SpriteRenderer>().sprite = tuglaSprite[carpma - 1];
            }
        }
    }
}
