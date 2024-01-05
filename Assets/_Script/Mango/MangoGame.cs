using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MangoGame : MonoBehaviour, IPointerDownHandler
{
    public mangoManager manager;
    public GameObject mango;
    public float timer;
    float currentTime;
    bool b = true;
    bool stop =false;
    Rigidbody2D rb;

    void Start()
    {
        currentTime = timer;
        rb  = GetComponent<Rigidbody2D>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(!b)
        {
            stop = true;
            rb.gravityScale = 10;
            manager.AddScore();
        }
    }


    private void Update()
    {
        if(!stop)
        {
            currentTime -= Time.deltaTime;
            if (currentTime <= 0)
            {
                mango.SetActive(!b);
                b = !b;
                timer = Random.Range(.5f, 1.5f);
                currentTime = timer;
            }
        }
        
    }

}
