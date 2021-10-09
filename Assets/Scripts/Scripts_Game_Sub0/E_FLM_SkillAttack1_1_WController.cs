using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack1_1_WController : E_FLM_SkillAttack1_1Base
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        if (4.5f <= transform.position.x)
        {
            Destroy(this.gameObject);
        }
    }
}
