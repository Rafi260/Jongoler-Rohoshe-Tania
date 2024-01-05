using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ProjononTantra : MonoBehaviour, IPointerClickHandler
{
    public GameObject check, info;
    public void OnPointerClick(PointerEventData eventData)
    {
        check.SetActive(true);
        info.SetActive(true);
    }
}
