using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mangoManager : MonoBehaviour
{
    public GameObject result;

    int score = 5;
    int a;
    public void AddScore()
    {
        a++;
        if(a >= score)
        {
            result.SetActive(true);
        }
    }
}
