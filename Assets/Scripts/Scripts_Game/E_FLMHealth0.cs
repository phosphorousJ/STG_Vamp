using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class E_FLMHealth0 : EnemyHealthBase
{
    //大技が発動したのかを判定
    private bool enemySkill_0 = false;
    private bool enemySkill_1 = false;


    protected override void Start()
    {
        base.Start();

        //現在のHPを最大値に設定
        currentHP = enemyHP;
    }


    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        if (20000 < currentHP && currentHP <= 40000)
        {
            if (!enemySkill_0)
            {
                enemySkill_0 = true;

                SceneManager.LoadScene("TalkScene0_2");
                Debug.Log("FLMが大技0を発動!!");
            }
        }
    }
}
