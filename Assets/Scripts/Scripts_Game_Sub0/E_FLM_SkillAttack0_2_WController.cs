using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack0_2_WController : E_FLM_SkillAttack0_2Base
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        //大鎌を移動させる
        transform.Translate(moveSpeed * Time.deltaTime, 0, 0, Space.World);

        if (3.5f <= transform.position.x)
        {
            Destroy(this.gameObject);
        }
    }
}
