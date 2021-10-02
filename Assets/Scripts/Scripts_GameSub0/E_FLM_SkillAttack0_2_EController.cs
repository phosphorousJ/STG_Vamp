using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack0_2_EController : E_FLM_SkillAttack0_2Base
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        //大鎌を移動させる
        transform.Translate(-moveSpeed * Time.deltaTime, 0, 0, Space.World);

        if (transform.position.x <= -3.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
