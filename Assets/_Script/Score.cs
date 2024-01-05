using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score;
    public static Score Instance;
    public GameObject star;
    public TMP_Text scoreText;


    private void Start()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this); 
        }
        else
        {
            Instance = this;
        }
    }

    public void AddScore(int a)
    {
        score += a;
        scoreText.text = score.ToString();
        StarAnim();
    }

    void StarAnim()
    {
        star.transform.DORotate(new Vector2(0,360), 2);
    }

    public void Setscore(int a)
    {
        score = a;
        scoreText.text = score.ToString();
        StarAnim();
    }

}
