using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_FLM_SkillAttack0Manager : MonoBehaviour
{
    #region//予告大鎌
    //E_FLM_SkillAttack0_0Prefab（予告大鎌）を入れる
    public GameObject E_FLM_SkillAttack0_0Prefab;
    #endregion

    #region//移動大鎌
    //E_FLM_SkillAttack0_1_EPrefab（移動大鎌）を入れる
    public GameObject E_FLM_SkillAttack0_1_EPrefab;

    //E_FLM_SkillAttack0_1_NPrefab（移動大鎌）を入れる
    public GameObject E_FLM_SkillAttack0_1_NPrefab;

    //E_FLM_SkillAttack0_1_SPrefab（移動大鎌）を入れる
    public GameObject E_FLM_SkillAttack0_1_SPrefab;

    //E_FLM_SkillAttack0_1_WPrefab（移動大鎌）を入れる
    public GameObject E_FLM_SkillAttack0_1_WPrefab;
    #endregion

    #region//回転大鎌
    //E_FLM_SkillAttack0_2_EPrefab（回転大鎌）を入れる
    public GameObject E_FLM_SkillAttack0_2_EPrefab;

    //E_FLM_SkillAttack0_2_NPrefab（回転大鎌）を入れる
    public GameObject E_FLM_SkillAttack0_2_NPrefab;

    //E_FLM_SkillAttack0_2_SPrefab（回転大鎌）を入れる
    public GameObject E_FLM_SkillAttack0_2_SPrefab;

    //E_FLM_SkillAttack0_2_WPrefab（回転大鎌）を入れる
    public GameObject E_FLM_SkillAttack0_2_WPrefab;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //コルーチン開始
        StartCoroutine(SkillAttack0_0());
    }


    #region//1:単発移動攻撃（N,E,S,E）
    IEnumerator SkillAttack0_0()
    {
        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -180));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_NPrefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -180));
        yield return new WaitForSeconds(1.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -270));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_EPrefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -270));
        yield return new WaitForSeconds(1.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, -3.5f, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_SPrefab, new Vector3(0, -3.5f, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(1.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -270));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_EPrefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -270));
        yield return new WaitForSeconds(3.0f);

        StartCoroutine(SkillAttack0_1());
    }
    #endregion


    #region//2:連続移動攻撃（S,W,N,E/N,S,E,W）
    IEnumerator SkillAttack0_1()
    {
        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, -3.5f, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(-3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -180));
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -270));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_SPrefab, new Vector3(0, -3.5f, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_WPrefab, new Vector3(-3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_NPrefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -180));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_EPrefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -270));
        yield return new WaitForSeconds(2.0f);


        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -180));
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, -3.5f, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -270));
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(-3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_NPrefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -180));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_SPrefab, new Vector3(0, -3.5f, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_EPrefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -270));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_1_WPrefab, new Vector3(-3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(3.0f);

        StartCoroutine(SkillAttack0_3());
    }
    #endregion


    #region//3:単発回転攻撃（N,W）
    IEnumerator SkillAttack0_3()
    {
        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_2_NPrefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(1.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(-3.5f, 0, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_2_WPrefab, new Vector3(-3.5f, 0, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(3.0f);

        StartCoroutine(SkillAttack0_4());
    }
    #endregion


    #region//4:連続回転攻撃（W,S,N/N,E,N/S,W,N,E）
    IEnumerator SkillAttack0_4()
    {
        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(-3.5f, 0, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, -3.5f, -0.05f), Quaternion.Euler(0, 0, 90));
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_2_WPrefab, new Vector3(-3.5f, 0, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(1.5f);

        Instantiate(E_FLM_SkillAttack0_2_SPrefab, new Vector3(0, -3.5f, -0.05f), Quaternion.Euler(0, 0, 90));
        yield return new WaitForSeconds(1.5f);

        Instantiate(E_FLM_SkillAttack0_2_NPrefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(2.0f);


        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -180));
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_2_NPrefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(1.5f);

        Instantiate(E_FLM_SkillAttack0_2_EPrefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -180));
        yield return new WaitForSeconds(1.5f);

        Instantiate(E_FLM_SkillAttack0_2_NPrefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(2.0f);


        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, -3.5f, -0.05f), Quaternion.Euler(0, 0, 90));
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(-3.5f, 0, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(0.5f);

        Instantiate(E_FLM_SkillAttack0_0Prefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -180));
        yield return new WaitForSeconds(1.0f);

        Instantiate(E_FLM_SkillAttack0_2_SPrefab, new Vector3(0, -3.5f, -0.05f), Quaternion.Euler(0, 0, 90));
        yield return new WaitForSeconds(1.5f);

        Instantiate(E_FLM_SkillAttack0_2_WPrefab, new Vector3(-3.5f, 0, -0.05f), Quaternion.identity);
        yield return new WaitForSeconds(1.5f);

        Instantiate(E_FLM_SkillAttack0_2_NPrefab, new Vector3(0, 3.5f, -0.05f), Quaternion.Euler(0, 0, -90));
        yield return new WaitForSeconds(1.5f);

        Instantiate(E_FLM_SkillAttack0_2_EPrefab, new Vector3(3.5f, 0, -0.05f), Quaternion.Euler(0, 0, -180));

        Debug.Log("鎌技「虚偽」を終了");
    }
    #endregion
}
