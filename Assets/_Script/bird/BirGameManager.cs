using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirGameManager : MonoBehaviour
{
    public birdTouch[] birds;
    int prevIndex=-1;
    public GameObject win, lose, instraction, prevInstracrtion;

    private void Start()
    {
        //PlayDemo();
    }
    public void PlayDemo()
    {
        StartCoroutine(PlaySoundsWithDelay());

        prevInstracrtion.SetActive(false);
        instraction.SetActive(true); 
    }
     IEnumerator PlaySoundsWithDelay()
    {
        foreach (var bird in birds)
        {
            bird.PlaySound();

            yield return new WaitForSeconds(.5f);
        }
    }

    public void Check(int a)
    {
        if((prevIndex + 1) == a)
        {
            prevIndex = a;
            if(prevIndex == 4)
            {
                win.SetActive(true);
            }
        }
        else
        {
            lose.SetActive(true);
        }
    }

    public void Reset()
    {
        prevIndex = -1;
        for (int i = 0; i < birds.Length; i++)
        {
            birds[i].clicked = false;
        }
    }
}
