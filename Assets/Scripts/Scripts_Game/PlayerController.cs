using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //左右の移動できる範囲
    private float movableRange = 6.4f;

    //P_NomalAttackPrefab（コウモリ）を入れる
    public GameObject P_NomalAttackPrefab;

    //P_B_SkillAttackPrefab（B攻撃）を入れる
    public GameObject P_B_SkillAttackPrefab;

    //P_G_SkiilAttackPrefab（G攻撃）を入れる
    public GameObject P_G_SkiilAttackPrefab;

    //P_R_SkillAttackPrefab（R攻撃）を入れる
    public GameObject P_R_SkillAttackPrefab;

    //コウモリの生成位置
    private float nStartPosY = -5.0f;
    private float nStartPosZ = -3.25f;

    //B攻撃の生成位置
    private float bStartPosY = -5.0f;
    private float bStartPosZ = -2.5f;

    //G攻撃の生成位置
    private float gStartPosY = -5.0f;
    private float gStartPosZ = -2.5f;

    //R攻撃の生成位置
    private float rStartPosY = -7.0f;
    private float rStartPosZ = -6.0f;


    // Start is called before the first frame update
    void Start()
    {
        //コウモリを一定時間毎に生成する
        InvokeRepeating("GenP_NomalAttack", 5, 1);
    }


    // Update is called once per frame
    void Update()
    {
        //Playerを矢印キーに応じて左右に移動させる
        if (Input.GetKeyDown(KeyCode.LeftArrow) && -this.movableRange < this.transform.position.x)
        {
            transform.Translate(-3.2f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && this.transform.position.x < this.movableRange)
        {
            transform.Translate(3.2f, 0, 0);
        }

        //Bキーを押したときB攻撃をする
        if (Input.GetKeyDown(KeyCode.B))
        {
            GameObject bSkillAttack = Instantiate(P_B_SkillAttackPrefab);
            bSkillAttack.transform.position = new Vector3(this.transform.position.x, bStartPosY, bStartPosZ);
        }

        //Gキーを押したときG攻撃をする
        if (Input.GetKeyDown(KeyCode.G))
        {
            GameObject gSkillAttack = Instantiate(P_G_SkiilAttackPrefab);
            gSkillAttack.transform.position = new Vector3(this.transform.position.x, gStartPosY, gStartPosZ);
        }

        //Rキーを押したときR攻撃をする
        if (Input.GetKeyDown(KeyCode.R))
        {
            GameObject rSkillAttack = Instantiate(P_R_SkillAttackPrefab);
            rSkillAttack.transform.position = new Vector3(this.transform.position.x, rStartPosY, rStartPosZ);
        }
    }


    //コウモリを生成する関数
    void GenP_NomalAttack()
    {
        GameObject pNomalAttack = Instantiate(P_NomalAttackPrefab);
        pNomalAttack.transform.position = new Vector3(this.transform.position.x, nStartPosY, nStartPosZ);
    }
}
