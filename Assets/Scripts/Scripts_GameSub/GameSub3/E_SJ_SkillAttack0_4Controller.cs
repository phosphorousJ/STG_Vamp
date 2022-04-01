using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_SJ_SkillAttack0_4Controller : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        Invoke("ObjectRotate", 1.5f);

        Invoke("ObjectDestroy", 8.0f);
    }


    void ObjectRotate()
    {
        //電流を回転させる
        transform.Rotate(new Vector3(0, 0, 3));
    }

    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}
