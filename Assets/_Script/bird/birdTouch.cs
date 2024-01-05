using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class birdTouch : MonoBehaviour, IPointerDownHandler
{
    public int id;
    public BirGameManager gameManager;
    public AudioSource source;
    public AudioClip clip;
    public bool clicked = false;    

    private void Start()
    {


        source = gameObject.AddComponent<AudioSource>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(!clicked)
        {
            clicked = true;
            if (id == -1)
            {
                PlaySound();
                gameManager.PlayDemo();
            }
            else
            {
                PlaySound();
                gameManager.Check(id);
            }
        }
        
    }

    public void PlaySound()
    {
        gameObject.transform.DOScale(1.1f, .3f).OnComplete(() =>
        {
            gameObject.transform.DOScale(1f, .3f);
        });
        if(source != null)
        {
            source.PlayOneShot(clip);
        }
    }
}
