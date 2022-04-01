using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Retry2_0 : MonoBehaviour
{
    private bool firstPush = false;


    public void Push()
    {
        if (!firstPush)
        {
            if (0 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 25000)
            {
                SceneManager.LoadScene("GameScene2_0");
            }
            else if (25000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 50000)
            {
                SceneManager.LoadScene("GameScene2_0");
            }
            else if (50000 <= GManager.instance.sumDamage && GManager.instance.sumDamage < 80000)
            {
                SceneManager.LoadScene("GameScene2_1");
            }

            firstPush = true;
        }
    }
}
