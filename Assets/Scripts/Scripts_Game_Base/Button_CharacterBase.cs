using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_CharacterBase : MonoBehaviour
{
    private bool returnPush = false;
    private bool titlePush = false;


    public void PushReturn()
    {
        if (!returnPush)
        {
            returnPush = true;

            SceneManager.LoadScene("CharacterSelectScene");
        }
    }


    public void PushTitle()
    {
        if (!titlePush)
        {
            titlePush = true;

            FadeManager.Instance.LoadScene("TitleScene", 2.0f);
        }
    }
}
