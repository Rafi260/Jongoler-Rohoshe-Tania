using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskAtIndex : MonoBehaviour
{
    public NextButton button;
    int index;
    bool appear;

    public void Task()
    {
        if(appear)
        {
            gameObject.SetActive(true);
        }
    }
}
