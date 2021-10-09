using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack0_1_WController : E_FLM_SkillAttack0_1Base
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        if (1.5f <= transform.position.x)
        {
            Destroy(this.gameObject);
        }
    }
}
