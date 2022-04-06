using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_LevelSelect : MonoBehaviour
{
    private bool easyPush = false;
    private bool nomalPush = false;
    private bool hardPush = false;
    private bool veryHardPush = false;


    public void easyStart()
    {
        if (!easyPush)
        {
            easyPush = true;

            GManager.instance.easy = true;

            FadeManager.Instance.LoadScene("MenuScene", 3.0f);
        }
    }


    public void nomalStart()
    {
        if (!nomalPush)
        {
            nomalPush = true;

            GManager.instance.nomal = true;

            FadeManager.Instance.LoadScene("MenuScene", 3.0f);
        }
    }


    public void hardStart()
    {
        if (!hardPush)
        {
            hardPush = true;

            GManager.instance.hard = true;

            FadeManager.Instance.LoadScene("MenuScene", 3.0f);
        }
    }


    public void veryHardStart()
    {
        if (!veryHardPush)
        {
            veryHardPush = true;

            GManager.instance.veryHard = true;

            FadeManager.Instance.LoadScene("MenuScene", 3.0f);
        }
    }
}
