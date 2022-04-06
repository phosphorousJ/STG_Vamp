using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Character3 : Button_CharacterBase
{
    #region//インスペクター設定
    //CharacterImageを入れる
    public GameObject characterMin;
    public GameObject characterBig;

    //CharacterSpriteを入れる
    public Sprite[] characterMins;
    public Sprite[] characterBigs;
    #endregion


    #region//プライベート設定
    //Buttonが押された回数
    private int changeCount = 0;
    #endregion


    public void PushChange()
    {
        //Changeが押された回数をカウント
        changeCount += 1;

        switch (changeCount)
        {
            case 0:
                //characterMinのSpriteを変更する
                characterMin.GetComponent<Image>().sprite = characterMins[0];

                //characterBigのSpriteを変更する
                characterBig.GetComponent<Image>().sprite = characterBigs[0];
                break;

            case 1:
                //characterMinのSpriteを変更する
                characterMin.GetComponent<Image>().sprite = characterMins[1];

                //characterBigのSpriteを変更する
                characterBig.GetComponent<Image>().sprite = characterBigs[1];
                break;

            case 2:
                //characterMinのSpriteを変更する
                characterMin.GetComponent<Image>().sprite = characterMins[2];

                //characterBigのSpriteを変更する
                characterBig.GetComponent<Image>().sprite = characterBigs[2];

                //カウントをリセット
                changeCount = -1;
                break;
        }
    }
}
