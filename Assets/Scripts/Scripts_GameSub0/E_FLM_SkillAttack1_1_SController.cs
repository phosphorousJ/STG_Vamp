using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack1_1_SController : E_FLM_SkillAttack1_1Base
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        if (4.5f <= transform.position.y)
        {
            Destroy(this.gameObject);
        }
    }
}
