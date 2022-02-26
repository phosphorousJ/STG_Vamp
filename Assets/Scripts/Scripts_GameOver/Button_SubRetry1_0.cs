using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_SubRetry1_0 : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            Debug.Log("Retry!!");

            SceneManager.LoadScene("GameSubScene1_0");

            firstPush = true;
        }
    }
}
