using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Menu : MonoBehaviour
{
    private bool stage0Push = false;
    private bool stage1Push = false;
    private bool stage2Push = false;
    private bool stage3Push = false;
    private bool stage4Push = false;
    private bool titlePush = false;


    public void PushStage0()
    {
        if (!stage0Push)
        {
            stage0Push = true;

            SceneManager.LoadScene("Story0Scene");
        }
    }


    public void PushStage1()
    {
        if (!stage1Push)
        {
            stage1Push = true;

            SceneManager.LoadScene("Story1Scene");
        }
    }


    public void PushStage2()
    {
        if (!stage2Push)
        {
            stage2Push = true;

            SceneManager.LoadScene("Story2Scene");
        }
    }


    public void PushStage3()
    {
        if (!stage3Push)
        {
            stage3Push = true;

            SceneManager.LoadScene("Story3Scene");
        }
    }


    public void PushStage4()
    {
        if (!stage4Push)
        {
            stage4Push = true;

            SceneManager.LoadScene("Story4_0Scene");
        }
    }


    public void PushTitle()
    {
        if (!titlePush)
        {
            titlePush = true;

            //難易度をリセット
            GManager.instance.easy = false;
            GManager.instance.nomal = false;
            GManager.instance.hard = false;
            GManager.instance.veryHard = false;

            FadeManager.Instance.LoadScene("TitleScene", 2.0f);
        }
    }
}
