﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Story3_2Select : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            firstPush = true;

            SceneManager.LoadScene("GameStartScene3");
        }
    }
}
