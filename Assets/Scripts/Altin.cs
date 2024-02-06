using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altin : MonoBehaviour
{
    [SerializeField]
    GameObject altin = default;
    
    public void AltinAc()
    {
        altin.SetActive(true);
    }

    public void AltiniKapat()
    {
        altin.SetActive(false);
    }
}
