using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    //P_B_SkillStockPane（青弾の親オブジェクト）を入れる
    public GameObject P_B_SkillStockPanel;

    //青弾のストック配列
    public GameObject[] bMPImages;

    //P_G_SkillStockPane（緑弾の親オブジェクト）を入れる
    public GameObject P_G_SkillStockPanel;

    //緑弾のストック配列
    public GameObject[] gMPImages;

    //P_R_SkillStockPane（赤弾の親オブジェクト）を入れる
    public GameObject P_R_SkillStockPanel;

    //赤弾のストック配列
    public GameObject[] rMPImages;



    #region//プレイヤー（設定）
    //左右の移動できる範囲
    private float movableRange = 6.4f;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
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
    }
}
