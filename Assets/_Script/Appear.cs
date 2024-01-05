using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{

    CanvasGroup canvasGroup;
    public bool OnEnableFadeIn = false, OnEnableFadeOut = false;

    public float delayTimer;
    float currenttimer;
    

    private void OnEnable()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        currenttimer = delayTimer;

        if (OnEnableFadeIn) FadeIn();
        if(OnEnableFadeOut) FadeOut();
    }


    bool fadeIn = false, fadeOut=false;

    private void Update()
    {
        if(fadeIn)
        {
            if(currenttimer > 0)
            {
                currenttimer -= Time.deltaTime;
            }
            else
            {
                if (canvasGroup.alpha < 1)
                {
                    canvasGroup.alpha += Time.deltaTime;
                    if (canvasGroup.alpha >= 1)
                    {
                        fadeIn = false;
                    }
                }
            }
            
        }

        if (currenttimer > 0)
        {
            currenttimer -= Time.deltaTime;
        }
        else
        {
            if (fadeOut)
            {
                if (canvasGroup.alpha > 0)
                {
                    canvasGroup.alpha -= Time.deltaTime * Time.deltaTime;
                    if (canvasGroup.alpha <= 0)
                    {
                        fadeOut = false;
                    }
                }
            }
        }
    }

    public void FadeIn()
    {
        canvasGroup.alpha = 0;
        fadeIn = true;
        currenttimer = delayTimer;
    }
    public void FadeOut()
    {
        canvasGroup.alpha = 1;
        fadeOut = true;
        currenttimer = delayTimer;

    }
}
