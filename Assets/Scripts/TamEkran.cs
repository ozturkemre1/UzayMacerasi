using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamEkran : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        Vector2 tempScale = transform.localScale;

        float spriteGenislik = spriteRenderer.size.x;
        float ekranYukseklik = Camera.main.orthographicSize * 2.0f;
        float ekranGenislik = ekranYukseklik / Screen.height * Screen.width;
        tempScale.x = ekranGenislik / spriteGenislik;
        transform.localScale = tempScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
