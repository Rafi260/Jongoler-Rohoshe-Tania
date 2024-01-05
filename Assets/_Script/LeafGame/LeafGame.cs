using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeafGame : MonoBehaviour
{
    public TMP_Text chanceText,resultScoreText;
    int chance = 3;
    public int[] answers = new int[3];
    public GameObject result,resultLose, _right,_wrong;
    public Timer timer;

    int rightAnswers = 0;
    private void Update()
    {
        chanceText.text = chance.ToString();
    }

    public void Answer(int a)
    {
        chance--;
        int wrong = 1;
        for(int i = 0; i < answers.Length; i++)
        {
            if (answers[i] == a)
            {
                wrong--; break;
            }
        }
        if(wrong == 0)
        {
            _right.SetActive(true);
            _wrong.SetActive(false);
            rightAnswers++;
        }
        else
        {
            _right.SetActive(false);
            _wrong.SetActive(true);
        }
        if(chance == 0)
        {
            int _result = rightAnswers * 5;
            if(rightAnswers > 0)
            {
                if (Score.Instance) Score.Instance.AddScore(_result);
                resultScoreText.text = _result.ToString();
                result.SetActive(true);
                timer.StopTime();
            }
            else
            {
                resultLose.SetActive(true);
                timer.StopTime();
            }
           
        }
    }

    public void Reset()
    {
        chance = 3;
        rightAnswers = 0;
        //answers = new int[3];
        _right.SetActive(false);
        _wrong.SetActive(false);
    }

}
