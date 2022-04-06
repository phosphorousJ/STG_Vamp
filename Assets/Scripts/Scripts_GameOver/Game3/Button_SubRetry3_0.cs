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
            firstPush = true;

            //大技の発動判定によって推移するGameSubSceneを分岐させる
            if (GManager.instance.SJ_Skill1 == false && GManager.instance.SJ_Skill2 == false)
            {
                SceneManager.LoadScene("GameSubScene3_0");
            }
            else if (GManager.instance.SJ_Skill2 == false)
            {
                SceneManager.LoadScene("GameSubScene3_1");
            }
            else
            {
                SceneManager.LoadScene("GameSubScene3_2");
            }
        }
    }
}
