using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PuanKontrol : MonoBehaviour
{
    public Text kolayPuan, kolayAltin, ortaPuan, ortaAltin, zorPuan, zorAltin;

    // Start is called before the first frame update
    void Start()
    {
        kolayPuan.text = "Puan: " + Secenekler.KolayPuanDegerOku();
        kolayAltin.text = " X " + Secenekler.KolayAltinDegerOku();

        ortaPuan.text = "Puan: " + Secenekler.OrtaPuanDegerOku();
        ortaAltin.text = " X " + Secenekler.OrtaAltinDegerOku();

        zorPuan.text = "Puan: " + Secenekler.ZorPuanDegerOku();
        zorAltin.text = " X " + Secenekler.ZorAltinDegerOku();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnaMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
