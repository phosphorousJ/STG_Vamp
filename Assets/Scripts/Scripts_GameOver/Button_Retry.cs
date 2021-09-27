using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Retry : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            Debug.Log("Retry!!");
            firstPush = true;
        }
    }
}
