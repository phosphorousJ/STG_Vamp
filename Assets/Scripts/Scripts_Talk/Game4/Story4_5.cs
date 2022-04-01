using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story4_5 : StoryBase
{
    #region//インスペクター設定
    //PersonImageを入れる
    public GameObject personImage0;
    public GameObject personImage2;

    //PersonSpriteSJを入れる
    public Sprite personSpriteSJ;

    //E_MCAttackSwordを入れる
    public GameObject e_MCAttackSword_1;
    public GameObject e_MCAttackSword_2;
    public GameObject[] e_MCAttackSwords_BC;
    public GameObject[] e_MCAttackSwords_FL;

    //E_MCAttackBarrierを入れる
    public GameObject e_MCAttackBarrier;
    public GameObject[] e_MCAttackBarriers_BC;
    public GameObject[] e_MCAttackBarriers_FL;

    //BackGroundを入れる
    public GameObject backGround1;

    //FlashGroundを入れる
    public GameObject flashGround;
    #endregion


    public override void Start()
    {
        base.Start();

        //E_MCAttackBarrierを非表示にする
        e_MCAttackBarrier.SetActive(false);
        e_MCAttackBarriersDel();

        //BackGroundを非表示にする
        backGround1.SetActive(false);

        //flashGroundの色を非表示にする
        flashGround.GetComponent<Image>().color = Color.clear;
    }


    public override void Update()
    {
        base.Update();

        switch (talkCount)
        {
            case 15:
                //e_MCAttackSword_1を非表示にする
                e_MCAttackSword_1.GetComponent<Image>().enabled = false;

                //e_MCAttackSword_2を非表示にする
                e_MCAttackSword_2.GetComponent<Image>().enabled = false;

                e_MCAttackSwordsDel();

                //BackGroundを表示
                backGround1.SetActive(true);
                break;

            case 38:
                e_MCAttackBarriersUnDel();
                break;

            case 41:
                //E_MCAttackBarrierを表示
                e_MCAttackBarrier.SetActive(true);
                break;

            case 45:
                //E_MCAttackBarrierを非表示にする
                e_MCAttackBarrier.SetActive(false);

                e_MCAttackBarriersDel();
                break;

            case 57:
                //BackGroundを非表示にする
                backGround1.SetActive(false);
                break;

            case 59:
                //personImage0を非表示にする
                personImage0.GetComponent<Image>().enabled = false;
                break;

            case 61:
                //personImage2のSpriteを変更する
                personImage2.GetComponent<Image>().sprite = personSpriteSJ;

                //personImage2の向きを変える
                personImage2.transform.localScale = new Vector3(-1, 1, 1);
                break;
        }

        //画面をフラッシュさせる
        if (talkCount == 56 && Input.GetMouseButtonDown(0))
        {
            flashGround.GetComponent<Image>().color = Color.white;
        }
        else
        {
            flashGround.GetComponent<Image>().color = Color.Lerp(flashGround.GetComponent<Image>().color, Color.clear, Time.deltaTime);
        }
    }


    //e_MCAttackSwords_BCとFLを消去する関数
    void e_MCAttackSwordsDel()
    {
        for (int i = 0; i < e_MCAttackSwords_BC.Length; i++)
        {
            //e_MCAttackSwords_BCを非表示にする
            e_MCAttackSwords_BC[i].GetComponent<Image>().enabled = false;
        }

        for (int i = 0; i < e_MCAttackSwords_FL.Length; i++)
        {
            //e_MCAttackSwords_FLを非表示にする
            e_MCAttackSwords_FL[i].GetComponent<Image>().enabled = false;
        }
    }


    //e_MCAttackBarriers_BCとFLを非表示にする関数
    void e_MCAttackBarriersDel()
    {
        for (int i = 0;i< e_MCAttackBarriers_BC.Length; i++)
        {
            //e_MCAttackBarriers_BCを非表示にする
            e_MCAttackBarriers_BC[i].GetComponent<Image>().enabled = false;
        }

        for (int i = 0; i < e_MCAttackBarriers_FL.Length; i++)
        {
            //e_MCAttackBarriers_FLを非表示にする
            e_MCAttackBarriers_FL[i].GetComponent<Image>().enabled = false;
        }
    }


    //e_MCAttackBarriers_BCとFLを表示する関数
    void e_MCAttackBarriersUnDel()
    {
        for (int i = 0; i < e_MCAttackBarriers_BC.Length; i++)
        {
            //e_MCAttackBarriers_BCを非表示にする
            e_MCAttackBarriers_BC[i].GetComponent<Image>().enabled = true;
        }

        for (int i = 0; i < e_MCAttackBarriers_FL.Length; i++)
        {
            //e_MCAttackBarriers_FLを非表示にする
            e_MCAttackBarriers_FL[i].GetComponent<Image>().enabled = true;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            FadeManager.Instance.LoadScene("Story4_0Scene", 2.0f);
        }
    }
}
