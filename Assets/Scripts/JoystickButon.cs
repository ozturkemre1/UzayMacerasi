using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickButon : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [HideInInspector]
    public bool tusaBadildi;

    public void OnPointerDown(PointerEventData eventData)
    {
        tusaBadildi = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        tusaBadildi = false;
    }
}
