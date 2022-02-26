using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSubManager : MonoBehaviour
{
    #region//インスペクター設定
    public static GSubManager instance = null;

    public float TT_SkillAttack0_1PosX;
    public float TT_SkillAttack0_1PosY;

    public float TT_SkillAttack0_2PosX;
    public float TT_SkillAttack0_2PosY;

    public float TT_SkillAttack0_3PosX;
    public float TT_SkillAttack0_3PosY;

    public float BK_SkillAttack0_1PosX;
    public float BK_SkillAttack0_1PosY;

    public float BK_SkillAttack0_2PosX;
    public float BK_SkillAttack0_2PosY;

    public float BK_SkillAttack1_1PosX;
    public float BK_SkillAttack1_1PosY;

    public float BK_SkillAttack1_2PosX;
    public float BK_SkillAttack1_2PosY;

    public float BK_SkillAttack1_3PosX;
    public float BK_SkillAttack1_3PosY;
    #endregion


    //シングルトンの実装
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
