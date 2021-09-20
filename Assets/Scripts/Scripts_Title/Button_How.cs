using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_How : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            Debug.Log("How to Play!!");
            firstPush = true;
        }
    }
}
