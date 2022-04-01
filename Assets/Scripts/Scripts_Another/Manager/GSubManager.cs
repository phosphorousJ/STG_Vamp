using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GSubManager : MonoBehaviour
{
    #region//インスペクター設定
    public static GSubManager instance = null;

    //Playerの座標
    public float Player_PosX;
    public float Player_PosY;

    //FLMのSkillAttackの座標
    public float FLM_SkillAttack0_1PosX;
    public float FLM_SkillAttack0_1PosY;

    public float FLM_SkillAttack0_2PosX;
    public float FLM_SkillAttack0_2PosY;

    public float FLM_SkillAttack1_1PosX;
    public float FLM_SkillAttack1_1PosY;
    //TTのSkillAttackの座標
    public float TT_SkillAttack0_1PosX;
    public float TT_SkillAttack0_1PosY;

    public float TT_SkillAttack0_2PosX;
    public float TT_SkillAttack0_2PosY;

    public float TT_SkillAttack0_3PosX;
    public float TT_SkillAttack0_3PosY;

    //BKのSkillAttackの座標
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

    //SJのSkillAttackの座標
    public float SJ_SkillAttack0_1PosX;
    public float SJ_SkillAttack0_1PosY;

    public float SJ_SkillAttack0_2PosX;
    public float SJ_SkillAttack0_2PosY;

    public float SJ_SkillAttack0_3PosX;
    public float SJ_SkillAttack0_3PosY;

    public float SJ_SkillAttack0_4PosX;
    public float SJ_SkillAttack0_4PosY;

    public float SJ_SkillAttack1_1PosX;
    public float SJ_SkillAttack1_1PosY;

    public float SJ_SkillAttack1_2PosX;
    public float SJ_SkillAttack1_2PosY;

    public float SJ_SkillAttack1_3PosX;
    public float SJ_SkillAttack1_3PosY;

    public float SJ_SkillAttack2_1_SPosX;
    public float SJ_SkillAttack2_1_SPosY;
    public float SJ_SkillAttack2_1_NPosX;
    public float SJ_SkillAttack2_1_NPosY;
    public float SJ_SkillAttack2_1_WPosX;
    public float SJ_SkillAttack2_1_WPosY;
    public float SJ_SkillAttack2_1_EPosX;
    public float SJ_SkillAttack2_1_EPosY;

    public float SJ_SkillAttack2_2PosX;
    public float SJ_SkillAttack2_2PosY;

    public float SJ_SkillAttack2_3PosX;
    public float SJ_SkillAttack2_3PosY;

    public float SJ_SkillAttack2_5PosX;
    public float SJ_SkillAttack2_5PosY;

    public float SJ_SkillAttack2_6PosX;
    public float SJ_SkillAttack2_6PosY;

    public float SJ_SkillAttack2_7PosX;
    public float SJ_SkillAttack2_7PosY;

    public float SJ_SkillAttack2_8PosX;
    public float SJ_SkillAttack2_8PosY;
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
