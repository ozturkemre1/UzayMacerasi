using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraHareket : MonoBehaviour
{

    float hiz;
    float hizlanma;
    float maksimumHiz;

    bool hareket;

    // Start is called before the first frame update
    void Start()
    {
        hareket = true;
        if (Secenekler.KolayDegerOku() == 1)
        {
            hiz = 0.3f;
            hizlanma = 0.03f;
            maksimumHiz = 1.5f;
        }
        if (Secenekler.OrtaDegerOku() == 1)
        {
            hiz = 0.5f;
            hizlanma = 0.05f;
            maksimumHiz = 2.0f;
        }
        if (Secenekler.ZorDegerOku() == 1)
        {
            hiz = 0.8f;
            hizlanma = 0.08f;
            maksimumHiz = 2.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hareket)
        {
            KamerayiHareketEttir();
        }
        
    }

    void KamerayiHareketEttir()
    {
        transform.position += transform.up * hiz * Time.deltaTime;
        hiz += hizlanma * Time.deltaTime;
        if(hiz > maksimumHiz)
        {
            hiz = maksimumHiz;
        }
    }

    public void OyunBitti()
    {
        hareket = false;
    }
}
