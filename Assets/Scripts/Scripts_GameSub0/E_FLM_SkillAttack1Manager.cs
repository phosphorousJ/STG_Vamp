using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack1Manager : MonoBehaviour
{
    #region//移動羽
    //E_FLM_SkillAttack1_1_EPrefab（移動羽）を入れる
    public GameObject E_FLM_SkillAttack1_1_EPrefab;

    //E_FLM_SkillAttack1_1_NPrefab（移動羽）を入れる
    public GameObject E_FLM_SkillAttack1_1_NPrefab;

    //E_FLM_SkillAttack1_1_SPrefab（移動羽）を入れる
    public GameObject E_FLM_SkillAttack1_1_SPrefab;

    //E_FLM_SkillAttack1_1_WPrefab（移動羽）を入れる
    public GameObject E_FLM_SkillAttack1_1_WPrefab;
    #endregion

    #region//回転羽
    //E_FLM_SkillAttack1_2_NPrefab（回転羽）を入れる
    public GameObject E_FLM_SkillAttack1_2_NPrefab;
    #endregion

    #region//プライベート設定
    //攻撃位置の配列
    private float[] attackPos = { 1.32f, 0.66f, 0.0f, -0.66f, -1.32f };

    //攻撃位置（x座標）
    private float posX;

    //攻撃位置（y座標）
    private float posY;

    //同時攻撃の共通座標
    private float pos;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //コルーチン開始
        StartCoroutine(SkillAttack1_0());
    }


    #region//1:単発移動攻撃（E&W,S）
    IEnumerator SkillAttack1_0()
    {
        for (int i = 0; i < 31; i++)
        {
            //y座標をランダムに決定
            posY = attackPos[Random.Range(0, attackPos.Length)];
            Instantiate(E_FLM_SkillAttack1_1_EPrefab, new Vector3(4.5f,posY,-0.05f), Quaternion.Euler(0, 0, 90));
            yield return new WaitForSeconds(0.5f);

            posY = attackPos[Random.Range(0, attackPos.Length)];
            Instantiate(E_FLM_SkillAttack1_1_WPrefab, new Vector3(-4.5f, posY, -0.05f), Quaternion.Euler(0, 0, -90));
            yield return new WaitForSeconds(0.5f);

            if (16 <= i)
            {
                //x座標をランダムに決定
                posX = attackPos[Random.Range(0, attackPos.Length)];
                Instantiate(E_FLM_SkillAttack1_1_SPrefab, new Vector3(posX, -4.5f, -0.05f), Quaternion.identity);
                yield return new WaitForSeconds(0.5f);
            }
        }

        StartCoroutine(SkillAttack1_1());
    }
    #endregion


    #region//2:回転攻撃（N）
    IEnumerator SkillAttack1_1()
    {
        for (int j = 0; j < 41; j++)
        {
            posX = attackPos[Random.Range(0, attackPos.Length)];
            Instantiate(E_FLM_SkillAttack1_2_NPrefab, new Vector3(posX, 4.5f, -0.05f), Quaternion.Euler(0, 0, 180));
            yield return new WaitForSeconds(0.5f);
        }

        StartCoroutine(SkillAttack1_2());
    }
    #endregion


    #region//3:同時移動攻撃（N&W,S&W,E&S,W&N）
    IEnumerator SkillAttack1_2()
    {
        for (int k = 0; k < 11; k++)
        {
            pos = attackPos[Random.Range(0, attackPos.Length)];

            Instantiate(E_FLM_SkillAttack1_1_NPrefab, new Vector3(pos, 4.5f, -0.05f), Quaternion.Euler(0, 0, 180));
            yield return new WaitForSeconds(0.3f);

            Instantiate(E_FLM_SkillAttack1_1_EPrefab, new Vector3(4.5f, pos, -0.05f), Quaternion.Euler(0, 0, 90));
            yield return new WaitForSeconds(0.3f);
        }

        for (int k = 0; k < 11; k++)
        {
            pos = attackPos[Random.Range(0, attackPos.Length)];

            Instantiate(E_FLM_SkillAttack1_1_SPrefab, new Vector3(pos, -4.5f, -0.05f), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);

            Instantiate(E_FLM_SkillAttack1_1_WPrefab, new Vector3(-4.5f, pos, -0.05f), Quaternion.Euler(0, 0, -90));
            yield return new WaitForSeconds(0.3f);
        }

        for (int k = 0; k < 11; k++)
        {
            pos = attackPos[Random.Range(0, attackPos.Length)];

            Instantiate(E_FLM_SkillAttack1_1_EPrefab, new Vector3(4.5f, pos, -0.05f), Quaternion.Euler(0, 0, 90));
            yield return new WaitForSeconds(0.3f);

            Instantiate(E_FLM_SkillAttack1_1_SPrefab, new Vector3(pos, -4.5f, -0.05f), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }

        for (int k = 0; k < 11; k++)
        {
            pos = attackPos[Random.Range(0, attackPos.Length)];

            Instantiate(E_FLM_SkillAttack1_1_WPrefab, new Vector3(-4.5f, pos, -0.05f), Quaternion.Euler(0, 0, -90));
            yield return new WaitForSeconds(0.3f);

            Instantiate(E_FLM_SkillAttack1_1_NPrefab, new Vector3(pos, 4.5f, -0.05f), Quaternion.Euler(0, 0, 180));
            yield return new WaitForSeconds(0.3f);
        }

        StartCoroutine(SkillAttack1_3());
    }
    #endregion


    #region//4:回転攻撃（N）
    IEnumerator SkillAttack1_3()
    {
        for (int l = 0; l < 41; l++)
        {
            posX = attackPos[Random.Range(0, attackPos.Length)];
            Instantiate(E_FLM_SkillAttack1_2_NPrefab, new Vector3(posX, 4.5f, -0.05f), Quaternion.Euler(0, 0, 180));
            yield return new WaitForSeconds(0.5f);
        }

        StartCoroutine(SkillAttack1_4());
    }
    #endregion


    #region//5:単発回転移動攻撃（時計回り）
    IEnumerator SkillAttack1_4()
    {
        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_EPrefab, new Vector3(4.5f, attackPos[m], -0.05f), Quaternion.Euler(0, 0, 90));
            yield return new WaitForSeconds(0.3f);
        }
        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_SPrefab, new Vector3(attackPos[m], -4.5f, -0.05f), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_WPrefab, new Vector3(-4.5f, -attackPos[m], -0.05f), Quaternion.Euler(0, 0, -90));
            yield return new WaitForSeconds(0.3f);
        }
        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_NPrefab, new Vector3(-attackPos[m], 4.5f, -0.05f), Quaternion.Euler(0, 0, 180));
            yield return new WaitForSeconds(0.3f);
        }


        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_EPrefab, new Vector3(3.3f, attackPos[m], -0.05f), Quaternion.Euler(0, 0, 90));
            yield return new WaitForSeconds(0.3f);
        }
        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_SPrefab, new Vector3(attackPos[m], -3.3f, -0.05f), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_WPrefab, new Vector3(-3.3f, -attackPos[m], -0.05f), Quaternion.Euler(0, 0, -90));
            yield return new WaitForSeconds(0.3f);
        }
        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_NPrefab, new Vector3(-attackPos[m], 3.3f, -0.05f), Quaternion.Euler(0, 0, 180));
            yield return new WaitForSeconds(0.3f);
        }


        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_EPrefab, new Vector3(2.1f, attackPos[m], -0.05f), Quaternion.Euler(0, 0, 90));
            yield return new WaitForSeconds(0.3f);
        }
        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_SPrefab, new Vector3(attackPos[m], -2.1f, -0.05f), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_WPrefab, new Vector3(-2.1f, -attackPos[m], -0.05f), Quaternion.Euler(0, 0, -90));
            yield return new WaitForSeconds(0.3f);
        }
        for (int m = 0; m < attackPos.Length; m++)
        {
            Instantiate(E_FLM_SkillAttack1_1_NPrefab, new Vector3(-attackPos[m], 2.1f, -0.05f), Quaternion.Euler(0, 0, 180));
            yield return new WaitForSeconds(0.3f);
        }

        Debug.Log("己心「積羽沈舟」を終了");
    }
    #endregion
}
