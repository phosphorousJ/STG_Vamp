using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack0_1_SController : E_FLM_SkillAttack0_1Base
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        if (1.5f <= transform.position.y)
        {
            Destroy(this.gameObject);
        }
    }
}
