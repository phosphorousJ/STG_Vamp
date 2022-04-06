using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button_CharacterSelect : MonoBehaviour
{
    #region//インスペクター設定
    //CharacterIconImageを入れる
    public GameObject characterIconImage0;
    public GameObject characterIconImage1;
    public GameObject characterIconImage2;
    public GameObject characterIconImage3;
    public GameObject characterIconImage4;
    #endregion


    #region//プライベート設定
    //Buttonが押されたか判定
    private bool iconPPush = false;
    private bool returnPush = false;
    private bool titlePush = false;
    private bool secondPush = false;

    //Buttonが押された回数
    private int Icon0PushCount = 0;
    private int Icon1PushCount = 0;
    private int Icon2PushCount = 0;
    private int Icon3PushCount = 0;
    private int Icon4PushCount = 0;
    #endregion


    public void PushReturn()
    {
        if (!returnPush)
        {
            returnPush = true;

            SceneManager.LoadScene("HowToPlayScene");
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


    public void PushCharacterIconP()
    {
        if (!iconPPush)
        {
            iconPPush = true;

            SceneManager.LoadScene("CharacterPScene");
        }
    }


    public void PushCharacterIcon0()
    {
        //CharacterIcon0が押された回数をカウント
        Icon0PushCount += 1;

        if (!secondPush)
        {
            switch (Icon0PushCount)
            {
                case 1:
                    //CharacterIconImage0を透明にする
                    characterIconImage0.GetComponent<Image>().color = new Color(0, 0, 0, 0);
                    break;

                case 2:
                    secondPush = true;

                    SceneManager.LoadScene("Character0Scene");
                    break;
            }
        }
    }


    public void PushCharacterIcon1()
    {
        //CharacterIcon1が押された回数をカウント
        Icon1PushCount += 1;

        if (!secondPush)
        {
            switch (Icon1PushCount)
            {
                case 1:
                    //CharacterIconImage1を透明にする
                    characterIconImage1.GetComponent<Image>().color = new Color(0, 0, 0, 0);
                    break;

                case 2:
                    secondPush = true;

                    SceneManager.LoadScene("Character1Scene");
                    break;
            }
        }
    }


    public void PushCharacterIcon2()
    {
        //CharacterIcon2が押された回数をカウント
        Icon2PushCount += 1;

        if (!secondPush)
        {
            switch (Icon2PushCount)
            {
                case 1:
                    //CharacterIconImage2を透明にする
                    characterIconImage2.GetComponent<Image>().color = new Color(0, 0, 0, 0);
                    break;

                case 2:
                    secondPush = true;

                    SceneManager.LoadScene("Character2Scene");
                    break;
            }
        }
    }


    public void PushCharacterIcon3()
    {
        //CharacterIcon3が押された回数をカウント
        Icon3PushCount += 1;

        if (!secondPush)
        {
            switch (Icon3PushCount)
            {
                case 1:
                    //CharacterIconImage3を透明にする
                    characterIconImage3.GetComponent<Image>().color = new Color(0, 0, 0, 0);
                    break;

                case 2:
                    secondPush = true;

                    SceneManager.LoadScene("Character3Scene");
                    break;
            }
        }
    }


    public void PushCharacterIcon4()
    {
        //CharacterIcon4が押された回数をカウント
        Icon4PushCount += 1;

        if (!secondPush)
        {
            switch (Icon4PushCount)
            {
                case 1:
                    //CharacterIconImage4を透明にする
                    characterIconImage4.GetComponent<Image>().color = new Color(0, 0, 0, 0);
                    break;

                case 2:
                    secondPush = true;

                    SceneManager.LoadScene("Character4Scene");
                    break;
            }
        }
    }
}
