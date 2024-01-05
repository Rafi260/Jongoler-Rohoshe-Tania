using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjononManager : MonoBehaviour
{
    public GameObject[] checks;
    public GameObject[] infos;

    public void Check(int a)
    {
        checks[a].SetActive(true);
        for(int i = 0; i < checks.Length; i++)
        {
            infos[i].SetActive(false);
        }
        infos[a].SetActive(true);
      
    }
}
