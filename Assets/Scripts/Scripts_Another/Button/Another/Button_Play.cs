using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Play : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            Debug.Log("Play Start!!");
            firstPush = true;

            FadeManager.Instance.LoadScene("MenuScene", 3.5f);
        }
    }
}
