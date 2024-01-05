using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleGameManager : MonoBehaviour
{
    public int score;
    int currentScore;
    public GameObject result;
    public Timer timer;

    public void AddScore(int a)
    {
        currentScore += a;
        if(currentScore >= score)
        {
            if(Score.Instance)Score.Instance.AddScore(15);
            result.SetActive(true);
            timer.StopTime();
        }
    }
}
