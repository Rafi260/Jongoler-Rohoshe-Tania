using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void firrstScene()
        {
            SceneManager.LoadScene("First");
        }
    public void secondtScene()
    {
        SceneManager.LoadScene("Second");
    }

}
