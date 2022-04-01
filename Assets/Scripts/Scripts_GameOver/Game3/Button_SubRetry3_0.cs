using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_SubRetry3_0 : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            //大技の発動判定によって推移するGameSubSceneを分岐させる
            if (GManager.instance.SJ_Skill1 == false && GManager.instance.SJ_Skill2 == false)
            {
                SceneManager.LoadScene("GameSubScene3_0");

                firstPush = true;
            }
            else if (GManager.instance.SJ_Skill2 == false)
            {
                SceneManager.LoadScene("GameSubScene3_1");

                firstPush = true;
            }
            else
            {
                SceneManager.LoadScene("GameSubScene3_2");

                firstPush = true;
            }
        }
    }
}
