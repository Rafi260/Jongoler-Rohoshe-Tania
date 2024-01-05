using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutProjonon : MonoBehaviour
{
    int a = 0;
    public GameObject nextBtn;

    public void Add()
    {
        a++;
        if(a >= 5)
        {
            nextBtn.SetActive(true);    
        }
    }
}
