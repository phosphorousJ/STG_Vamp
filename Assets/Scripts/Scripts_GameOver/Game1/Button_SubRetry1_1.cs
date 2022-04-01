using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_SubRetry1_1 : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            Debug.Log("Retry!!");

            SceneManager.LoadScene("GameSubScene1_1");

            firstPush = true;
        }
    }
}
