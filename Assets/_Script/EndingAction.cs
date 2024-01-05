using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingAction : MonoBehaviour
{
    public int level;

    //level 1
    Movement charMov1, charMov2;
    GameObject gameObject;

    public void Action()
    {
        if(level == 1)
        {
            charMov1 = GetComponent<Movement>();
            charMov2 = GetComponent<Movement>();
            charMov1.Move();
            charMov2.Move();
        }
    }
}
