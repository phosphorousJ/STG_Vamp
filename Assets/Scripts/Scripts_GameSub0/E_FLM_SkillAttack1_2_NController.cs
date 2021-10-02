using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack1_2_NController : E_FLM_SkillAttack1_2Base
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        this.moveSpeed = 2.0f + Random.Range(1, 4);
    }

   
    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        //羽を移動させる
        transform.Translate(0, -moveSpeed * Time.deltaTime, 0, Space.World);

        if (transform.position.y <= -4.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
