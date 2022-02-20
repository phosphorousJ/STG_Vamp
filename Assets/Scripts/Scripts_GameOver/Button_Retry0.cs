using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Retry0 : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            Debug.Log("Retry!!");

            if (0 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 20000)
            {
                SceneManager.LoadScene("GameScene0_0");
                Debug.Log("通常0");
            }
            else if (20000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 40000)
            {
                SceneManager.LoadScene("GameScene0_0");
                Debug.Log("通常1");
            }
            else if (40000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 60000)
            {
                SceneManager.LoadScene("GameScene0_0");
                Debug.Log("通常2");
            }

            firstPush = true;
        }
    }
}
