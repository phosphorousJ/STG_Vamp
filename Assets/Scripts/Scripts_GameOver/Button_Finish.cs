using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Finish : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            Debug.Log("Finish");
            firstPush = true;
        }
    }
}
