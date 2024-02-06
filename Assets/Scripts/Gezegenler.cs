using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gezegenler : MonoBehaviour
{
    List<GameObject> gezegenler = new List<GameObject>();
    List<GameObject> kullanilanGezegenler = new List<GameObject>();

    void Awake()
    {
        Object[] sprites = Resources.LoadAll("Gezegenler");

        for (int i = 1; i < 17; i++)
        {
            GameObject gezegen = new GameObject();
            SpriteRenderer sRenderer = gezegen.AddComponent<SpriteRenderer>();
            sRenderer.sprite = (Sprite)sprites[i];
            Color spriteColor = sRenderer.color;
            spriteColor.a = 0.5f;
            sRenderer.color = spriteColor;
            gezegen.name = sprites[i].name;
            sRenderer.sortingLayerName = "Gezegen";
            Vector2 pozisyon = gezegen.transform.position;
            pozisyon.x = -10;
            gezegen.transform.position = pozisyon;
            gezegenler.Add(gezegen);
        }
    }

    public void GezegenYerlestir(float refY)
    {
        float yukseklik = EkranHesaplayicisi.instance.Yukseklik;
        float genislik = EkranHesaplayicisi.instance.Genislik;

        //1.b�lge
        float xDeger1 = Random.Range(0.0f, genislik);
        float yDeger1 = Random.Range(refY, refY + yukseklik);
        GameObject gezegen1 = RandomGezegen();
        gezegen1.transform.position = new Vector2(xDeger1, yDeger1);

        //2.b�lge
        float xDeger2 = Random.Range(-genislik, 0.0f);
        float yDeger2 = Random.Range(refY, refY + yukseklik);
        GameObject gezegen2 = RandomGezegen();
        gezegen2.transform.position = new Vector2(xDeger2, yDeger2);

        //3.b�lge
        float xDeger3 = Random.Range(-genislik, 0.0f);
        float yDeger3 = Random.Range(refY - yukseklik, refY);
        GameObject gezegen3 = RandomGezegen();
        gezegen3.transform.position = new Vector2(xDeger3, yDeger3);

        //4.b�lge
        float xDeger4 = Random.Range(0.0f, genislik);
        float yDeger4 = Random.Range(refY - yukseklik, refY);
        GameObject gezegen4 = RandomGezegen();
        gezegen4.transform.position = new Vector2(xDeger4, yDeger4);
    }

    GameObject RandomGezegen()
    {
        if(gezegenler.Count > 0)
        {
            int random;
            if(gezegenler.Count == 1)
            {
                random = 0;
            }else
            {
                random = Random.Range(0, gezegenler.Count - 1);
            }
            GameObject gezegen = gezegenler[random];
            gezegenler.Remove(gezegen);
            kullanilanGezegenler.Add(gezegen);
            return gezegen;
        }else
        {
            for (int i = 0; i < 8; i++)
            {
                gezegenler.Add(kullanilanGezegenler[i]);
            }
            kullanilanGezegenler.RemoveRange(0, 8);
            int random = Random.Range(0, 8);
            GameObject gezegen = gezegenler[random];
            gezegenler.Remove(gezegen);
            kullanilanGezegenler.Add(gezegen);
            return gezegen;
        }
    }
}
