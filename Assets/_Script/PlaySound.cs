using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource source;

    public bool projonTantro = false;
    public AboutProjonon aboutProjonon;

    private void OnEnable()
    {
        
        source = GetComponent<AudioSource>();
        source.Play();

        if(projonTantro)
        {
            aboutProjonon.Add();
        }
    }
}
