using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack0_0Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("ObjectDestroy", 0.8f);
    }


    void ObjectDestroy()
    {
        Destroy(this.gameObject);
    }
}
