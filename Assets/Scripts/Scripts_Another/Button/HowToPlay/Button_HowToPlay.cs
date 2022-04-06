using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_HowToPlay : MonoBehaviour
{
    private bool attackTurnPush = false;
    private bool avoidanceTurnPush = false;
    private bool characterPush = false;
    private bool titlePush = false;


    public void PushAttackTurn()
    {
        if (!attackTurnPush)
        {
            attackTurnPush = true;

            SceneManager.LoadScene("AttackTurnScene");
        }
    }


    public void PushAvoidanceTurn()
    {
        if (!avoidanceTurnPush)
        {
            avoidanceTurnPush = true;

            SceneManager.LoadScene("AvoidanceTurnScene");
        }
    }


    public void PushCharacter()
    {
        if (!characterPush)
        {
            characterPush = true;

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
