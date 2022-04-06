using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    #region//B攻撃（設定）
    //P_B_SkillAttackPrefab（B攻撃）を入れる
    public GameObject P_B_SkillAttackPrefab;

    //P_B_SkillStockPane（青弾の親オブジェクト）を入れる
    public GameObject P_B_SkillStockPanel;

    //青弾のストック配列
    public GameObject[] bMPImages;

    //E_B_MPBulletPrefab（青弾）に衝突した回数
    private int bMPCount = 0;

    //B攻撃の生成位置
    private float bStartPosY = -5.0f;
    private float bStartPosZ = -2.5f;

    //B攻撃ができるか判定
    private bool bAttack = false;

    //青弾の最大ストック数を判定
    private bool bMPMaxStockNull = false;

    //現在の青弾の弾数
    private int current_bMPBulletNull = 0;

    //消費した青弾の弾数
    private int decrease_bMPBulletNull = 0;
    #endregion


    #region//G攻撃（設定）
    //P_G_SkiilAttackPrefab（G攻撃）を入れる
    public GameObject P_G_SkiilAttackPrefab;

    //P_G_SkillStockPane（緑弾の親オブジェクト）を入れる
    public GameObject P_G_SkillStockPanel;

    //緑弾のストック配列
    public GameObject[] gMPImages;

    //E_G_MPBulletPrefab（緑弾）に衝突した回数
    private int gMPCount = 0;

    //G攻撃の生成位置
    private float gStartPosY = -5.0f;
    private float gStartPosZ = -2.5f;

    //G攻撃ができるか判定
    private bool gAttack = false;

    //緑弾の最大ストック数を判定
    private bool gMPMaxStockNull = false;

    //現在の緑弾の弾数
    private int current_gMPBulletNull = 0;

    //消費した緑弾の弾数
    private int decrease_gMPBulletNull = 0;
    #endregion


    #region//R攻撃（設定）
    //P_R_SkillAttackPrefab（R攻撃）を入れる
    public GameObject P_R_SkillAttackPrefab;

    //P_R_SkillStockPane（赤弾の親オブジェクト）を入れる
    public GameObject P_R_SkillStockPanel;

    //赤弾のストック配列
    public GameObject[] rMPImages;

    //E_R_MPBulletPrefab（赤弾）に衝突した回数
    private int rMPCount = 0;

    //R攻撃の生成位置
    private float rStartPosY = -7.0f;
    private float rStartPosZ = -6.0f;

    //R攻撃ができるか判定
    private bool rAttack = false;

    //赤弾の最大ストック数を判定
    private bool rMPMaxStockNull = false;

    //現在の赤弾の弾数
    private int current_rMPBulletNull = 0;

    //消費した赤弾の弾数
    private int decrease_rMPBulletNull = 0;
    #endregion


    #region//通常攻撃（設定）
    //P_NomalAttackPrefab（コウモリ）を入れる
    public GameObject P_NomalAttackPrefab;

    //コウモリの生成位置
    private float nStartPosY = -5.0f;
    private float nStartPosZ = -3.25f;
    #endregion


    #region//プレイヤー（設定）
    //左右の移動できる範囲
    private float movableRange = 6.4f;
    #endregion


    #region//パーティクル設定
    //P_B_ParticleSystemPrefabを入れる
    public GameObject P_B_ParticleSystemPrefab;

    //P_G_ParticleSystemPrefabを入れる
    public GameObject P_G_ParticleSystemPrefab;

    //P_R_ParticleSystemPrefabを入れる
    public GameObject P_R_ParticleSystemPrefab;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //コウモリを一定時間毎に生成する
        InvokeRepeating("GenP_NomalAttack", 5, 1);

        //青弾の初期ストック数を0にする
        foreach (Transform bMPStock in P_B_SkillStockPanel.transform)
        {
            bMPStock.gameObject.SetActive(false);
        }

        //緑弾の初期ストック数を0にする
        foreach (Transform gMPStock in P_G_SkillStockPanel.transform)
        {
            gMPStock.gameObject.SetActive(false);
        }

        //赤弾の初期ストック数を0にする
        foreach (Transform rMPStock in P_R_SkillStockPanel.transform)
        {
            rMPStock.gameObject.SetActive(false);
        }
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
            if (1 <= current_bMPBulletNull && current_bMPBulletNull <= 3)
            {
                GameObject bSkillAttack = Instantiate(P_B_SkillAttackPrefab);
                bSkillAttack.transform.position = new Vector3(this.transform.position.x, bStartPosY, bStartPosZ);

                //消費弾数を更新
                decrease_bMPBulletNull++;

                decreaseB_MPImages();

                //消費弾数をリセット
                decrease_bMPBulletNull = 0;
            }
            else if (current_bMPBulletNull == 0)
            {
                bAttack = true;
            }
        }

        //Gキーを押したときG攻撃をする
        if (Input.GetKeyDown(KeyCode.G))
        {
            if (1 <= current_gMPBulletNull && current_gMPBulletNull <= 3)
            {
                GameObject gSkillAttack = Instantiate(P_G_SkiilAttackPrefab);
                gSkillAttack.transform.position = new Vector3(this.transform.position.x, gStartPosY, gStartPosZ);

                //消費弾数を更新
                decrease_gMPBulletNull++;

                decreaseG_MPImages();

                //消費弾数をリセット
                decrease_gMPBulletNull = 0;
            }
            else if (current_gMPBulletNull == 0)
            {
                gAttack = true;
            }
        }

        //Rキーを押したときR攻撃をする
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (1 <= current_rMPBulletNull && current_rMPBulletNull <= 3)
            {
                GameObject rSkillAttack = Instantiate(P_R_SkillAttackPrefab);
                rSkillAttack.transform.position = new Vector3(this.transform.position.x, rStartPosY, rStartPosZ);

                //消費弾数を更新
                decrease_rMPBulletNull++;

                decreaseR_MPImages();

                //消費弾数をリセット
                decrease_rMPBulletNull = 0;
            }
            else if (current_rMPBulletNull == 0)
            {
                rAttack = true;
            }
        }
    }


    //コウモリを生成する関数
    void GenP_NomalAttack()
    {
        GameObject pNomalAttack = Instantiate(P_NomalAttackPrefab);
        pNomalAttack.transform.position = new Vector3(this.transform.position.x, nStartPosY, nStartPosZ);
    }


    #region//MP弾の衝突処理
    //MP弾の衝突処理
    void OnTriggerEnter(Collider other)
    {
        //青弾の場合
        if (other.gameObject.tag == "E_B_MPBulletTag")
        {
            //衝突位置を取得
            Vector3 hitPosB = other.ClosestPointOnBounds(this.transform.position);

            //パーティクルの表示処理
            var particleB = Instantiate(P_B_ParticleSystemPrefab, hitPosB, Quaternion.identity);
            var particleSystemB = particleB.GetComponent<ParticleSystem>();
            particleSystemB.Play();

            if (current_bMPBulletNull < 3)
            {
                //衝突回数を更新
                bMPCount++;

                //現在の青弾の弾数を更新
                current_bMPBulletNull += bMPCount;

                addB_MPImages();

                //衝突回数をリセット
                bMPCount = 0;
            }
            else if (current_bMPBulletNull == 3)
            {
                bMPMaxStockNull = true;
            }
        }
        
        //緑弾の場合
        if (other.gameObject.tag == "E_G_MPBulletTag")
        {
            //衝突位置を取得
            Vector3 hitPosG = other.ClosestPointOnBounds(this.transform.position);

            //パーティクルの表示処理
            var particleG = Instantiate(P_G_ParticleSystemPrefab, hitPosG, Quaternion.identity);
            var particleSystemG = particleG.GetComponent<ParticleSystem>();
            particleSystemG.Play();

            if (current_gMPBulletNull < 3)
            {
                //衝突回数を更新
                gMPCount++;

                //現在の緑弾の弾数を更新
                current_gMPBulletNull += gMPCount;

                addG_MPImages();

                //衝突回数をリセット
                gMPCount = 0;
            }
            else if (current_gMPBulletNull == 3)
            {
                gMPMaxStockNull = true;
            }
        }

        //赤弾の場合
        if (other.gameObject.tag == "E_R_MPBulletTag")
        {
            //衝突位置を取得
            Vector3 hitPosR = other.ClosestPointOnBounds(this.transform.position);

            //パーティクルの表示処理
            var particleR = Instantiate(P_R_ParticleSystemPrefab, hitPosR, Quaternion.identity);
            var particleSystemR = particleR.GetComponent<ParticleSystem>();
            particleSystemR.Play();

            if (current_rMPBulletNull < 3)
            {
                //衝突回数を更新
                rMPCount++;

                //現在の赤弾の弾数を更新
                current_rMPBulletNull += rMPCount;

                addR_MPImages();

                //衝突回数をリセット
                rMPCount = 0;
            }
            else if (current_rMPBulletNull == 3)
            {
                rMPMaxStockNull = true;
            }
        }
    }
    #endregion


    #region//B攻撃（関数）
    //青弾のストックを更新（増加）する関数
    void addB_MPImages()
    {
        for (int b = 0; b < 3; b++)
        {
            if (b < current_bMPBulletNull)
            {
                bMPImages[b].SetActive(true);
            }
            else
            {
                bMPImages[b].SetActive(false);
            }
            
        }
    }


    //青弾のストックを更新（減少）する関数
    void decreaseB_MPImages()
    {
        current_bMPBulletNull -= decrease_bMPBulletNull;

        bMPImages[current_bMPBulletNull].SetActive(false);
    }
    #endregion


    #region//G攻撃（関数）
    //緑弾のストックを更新（増加）する関数
    void addG_MPImages()
    {
        for (int g = 0; g < 3; g++)
        {
            if (g < current_gMPBulletNull)
            {
                gMPImages[g].SetActive(true);
            }
            else
            {
                gMPImages[g].SetActive(false);
            }

        }
    }


    //緑弾のストックを更新（減少）する関数
    void decreaseG_MPImages()
    {
        current_gMPBulletNull -= decrease_gMPBulletNull;

        gMPImages[current_gMPBulletNull].SetActive(false);
    }
    #endregion


    #region//R攻撃（関数）
    //赤弾のストックを更新（増加）する関数
    void addR_MPImages()
    {
        for (int r = 0; r < 3; r++)
        {
            if (r < current_rMPBulletNull)
            {
                rMPImages[r].SetActive(true);
            }
            else
            {
                rMPImages[r].SetActive(false);
            }

        }
    }


    //赤弾のストックを更新（減少）する関数
    void decreaseR_MPImages()
    {
        current_rMPBulletNull -= decrease_rMPBulletNull;

        rMPImages[current_rMPBulletNull].SetActive(false);
    }
    #endregion
}
