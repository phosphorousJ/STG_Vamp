using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSubManager : MonoBehaviour
{
    #region//インスペクター設定
    public static GSubManager instance = null;

    //playerの被弾回数
    public int eAttackSub0Count { get; set; }
    public int eAttackSub1Count { get; set; }
    public int eAttackSub2Count { get; set; }
    #endregion


    #region//インスペクター設定（座標）
    //Playerの座標
    public float Player_PosX { get; set; }
    public float Player_PosY { get; set; }

    //ANEのSkillAttackの座標
    public float ANE_SkillAttackPosX { get; set; }
    public float ANE_SkillAttackPosY { get; set; }

    //FLMのSkillAttackの座標
    public float FLM_SkillAttack0_1PosX { get; set; }
    public float FLM_SkillAttack0_1PosY { get; set; }

    public float FLM_SkillAttack0_2PosX { get; set; }
    public float FLM_SkillAttack0_2PosY { get; set; }

    public float FLM_SkillAttack1_1PosX { get; set; }
    public float FLM_SkillAttack1_1PosY { get; set; }

    //TTのSkillAttackの座標
    public float TT_SkillAttack0_1PosX { get; set; }
    public float TT_SkillAttack0_1PosY { get; set; }

    public float TT_SkillAttack0_2PosX { get; set; }
    public float TT_SkillAttack0_2PosY { get; set; }

    public float TT_SkillAttack0_3PosX { get; set; }
    public float TT_SkillAttack0_3PosY { get; set; }

    //BKのSkillAttackの座標
    public float BK_SkillAttack0_1PosX { get; set; }
    public float BK_SkillAttack0_1PosY { get; set; }

    public float BK_SkillAttack0_2PosX { get; set; }
    public float BK_SkillAttack0_2PosY { get; set; }

    public float BK_SkillAttack1_1PosX { get; set; }
    public float BK_SkillAttack1_1PosY { get; set; }

    public float BK_SkillAttack1_2PosX { get; set; }
    public float BK_SkillAttack1_2PosY { get; set; }

    public float BK_SkillAttack1_3PosX { get; set; }
    public float BK_SkillAttack1_3PosY { get; set; }

    //SJのSkillAttackの座標
    public float SJ_SkillAttack0_1PosX { get; set; }
    public float SJ_SkillAttack0_1PosY { get; set; }

    public float SJ_SkillAttack0_2PosX { get; set; }
    public float SJ_SkillAttack0_2PosY { get; set; }

    public float SJ_SkillAttack0_3PosX { get; set; }
    public float SJ_SkillAttack0_3PosY { get; set; }

    public float SJ_SkillAttack0_4PosX { get; set; }
    public float SJ_SkillAttack0_4PosY { get; set; }

    public float SJ_SkillAttack1_1PosX { get; set; }
    public float SJ_SkillAttack1_1PosY { get; set; }

    public float SJ_SkillAttack1_2PosX { get; set; }
    public float SJ_SkillAttack1_2PosY { get; set; }

    public float SJ_SkillAttack1_3PosX { get; set; }
    public float SJ_SkillAttack1_3PosY { get; set; }

    public float SJ_SkillAttack2_1_SPosX { get; set; }
    public float SJ_SkillAttack2_1_SPosY { get; set; }
    public float SJ_SkillAttack2_1_NPosX { get; set; }
    public float SJ_SkillAttack2_1_NPosY { get; set; }
    public float SJ_SkillAttack2_1_WPosX { get; set; }
    public float SJ_SkillAttack2_1_WPosY { get; set; }
    public float SJ_SkillAttack2_1_EPosX { get; set; }
    public float SJ_SkillAttack2_1_EPosY { get; set; }

    public float SJ_SkillAttack2_2PosX { get; set; }
    public float SJ_SkillAttack2_2PosY { get; set; }

    public float SJ_SkillAttack2_3PosX { get; set; }
    public float SJ_SkillAttack2_3PosY { get; set; }

    public float SJ_SkillAttack2_5PosX { get; set; }
    public float SJ_SkillAttack2_5PosY { get; set; }

    public float SJ_SkillAttack2_6PosX { get; set; }
    public float SJ_SkillAttack2_6PosY { get; set; }

    public float SJ_SkillAttack2_7PosX { get; set; }
    public float SJ_SkillAttack2_7PosY { get; set; }

    public float SJ_SkillAttack2_8PosX { get; set; }
    public float SJ_SkillAttack2_8PosY { get; set; }
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
