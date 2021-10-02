using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack1_1_NController : E_FLM_SkillAttack1_1Base
{
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        if (transform.position.y <= -4.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
