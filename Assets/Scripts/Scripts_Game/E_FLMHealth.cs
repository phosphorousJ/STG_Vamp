using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLMHealth : EnemyHealthBase
{
    //大技が発動したのかを判定
    private bool enemySkill_0 = false;
    private bool enemySkill_1 = false;


    // Update is called once per frame
    void Update()
    {
        if (20000 < currentHP && currentHP <= 40000)
        {
            if (!enemySkill_0)
            {
                enemySkill_0 = true;

                Debug.Log("FLMが大技0を発動!!");
            }
        }
        else if (0 < currentHP && currentHP <= 20000)
        {
            if (!enemySkill_1)
            {
                enemySkill_1 = true;

                Debug.Log("FLMが大技1を発動!!");
            }
        }
        else if (currentHP <= 0)
        {
            Debug.Log("FLMの体力は0になった");
        }
    }
}
