using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_FinishSubT : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            firstPush = true;

            SceneManager.LoadScene("AvoidanceTurnScene");
        }
    }
}
