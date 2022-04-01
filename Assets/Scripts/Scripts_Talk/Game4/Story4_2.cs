using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Story4_2 : StoryBase
{
    //E_MCAttackSwordを入れる
    public GameObject e_MCAttackSword_1;
    public GameObject e_MCAttackSword_2;


    public override void Update()
    {
        base.Update();

        if (2 <= talkCount)
        {
            //e_MCAttackSword_1を非表示にする
            e_MCAttackSword_1.GetComponent<Image>().enabled = false;

            //e_MCAttackSword_2を非表示にする
            e_MCAttackSword_2.GetComponent<Image>().enabled = false;
        }
    }


    public override void OnClick()
    {
        base.OnClick();

        if (talkCount == talks.Length)
        {
            SceneManager.LoadScene("GameScene4_1");
        }
    }
}
