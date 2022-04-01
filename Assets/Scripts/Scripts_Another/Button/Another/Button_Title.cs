using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Title : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            Debug.Log("Titleへ戻ります");
            firstPush = true;

            FadeManager.Instance.LoadScene("TitleScene", 2.0f);
        }
    }
}
