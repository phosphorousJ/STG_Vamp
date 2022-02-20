using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_TT_SkillAttack0Manager : MonoBehaviour
{
    #region//インスペクター設定
    //Playerオブジェクトを入れる
    public GameObject Player;

    //E_TT_SkillAttack0_1Prefabを入れる
    public GameObject E_TT_SkillAttack0_1Prefab;

    //E_TT_SkillAttack0_2Prefabを入れる
    public GameObject E_TT_SkillAttack0_2Prefab;

    //E_TT_SkillAttack0_3Prefabを入れる
    public GameObject E_TT_SkillAttack0_3Prefab;
    #endregion


    #region//プライベート設定
    //Playerの座標
    private Vector3 player;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        //コルーチン開始
        StartCoroutine(SkillAttack0_0());
    }


    #region//0:横一文字N、刺突N、刺突斬りW、刺突斬りE
    IEnumerator SkillAttack0_0()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return new WaitForSeconds(3.0f);

        //横一文字N
        for (int i = 0; i < 5; i++)
        {
            Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(-0.66f, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
            GSubManager.instance.TT_SkillAttack0_1PosY = 4.3f;
            yield return waitHalfS;

            Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(0.66f, 4.3f - 0.05f), Quaternion.Euler(0, 0, 180));
            GSubManager.instance.TT_SkillAttack0_1PosY = 4.3f;
            yield return waitHalfS;
        }

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_1PosY = 0.0f;

        //刺突N
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(player.x, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_2PosY = 4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //刺突斬りW
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_3Prefab, new Vector3(-3.5f, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.TT_SkillAttack0_3PosX = -3.5f;

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_3PosX = 0.0f;

        //刺突斬りE
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_3Prefab, new Vector3(3.5f, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.TT_SkillAttack0_3PosX = 3.5f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_3PosX = 0.0f;

        StartCoroutine(SkillAttack0_1());
    }
    #endregion


    #region//1:横一文字E、刺突E、横一文字W、刺突W
    IEnumerator SkillAttack0_1()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return new WaitForSeconds(2.0f);
        
        //横一文字E
        for (int i = 0; i < 5; i++)
        {
            Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(4.3f, -0.66f, -0.05f), Quaternion.Euler(0, 0, 90));
            GSubManager.instance.TT_SkillAttack0_1PosX = 4.3f;
            yield return waitHalfS;

            Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(4.3f, 0.66f - 0.05f), Quaternion.Euler(0, 0, 90));
            GSubManager.instance.TT_SkillAttack0_1PosX = 4.3f;
            yield return waitHalfS;
        }

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_1PosX = 0.0f;

        //刺突E
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.TT_SkillAttack0_2PosX = 4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        //横一文字W
        for (int i = 0; i < 5; i++)
        {
            Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(-4.3f, -0.66f, -0.05f), Quaternion.Euler(0, 0, -90));
            GSubManager.instance.TT_SkillAttack0_1PosX = -4.3f;
            yield return waitHalfS;

            Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(-4.3f, 0.66f - 0.05f), Quaternion.Euler(0, 0, -90));
            GSubManager.instance.TT_SkillAttack0_1PosX = -4.3f;
            yield return waitHalfS;
        }

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_1PosX = 0.0f;

        //刺突W
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(-4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.TT_SkillAttack0_2PosX = -4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        StartCoroutine(SkillAttack0_2());
    }
    #endregion


    #region//2:刺突W、刺突斬りS、刺突斬りN、刺突E
    IEnumerator SkillAttack0_2()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return new WaitForSeconds(2.0f);

        //刺突W
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(-4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.TT_SkillAttack0_2PosX = -4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        //刺突斬りS
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_3Prefab, new Vector3(player.x, -3.5f, -0.05f), Quaternion.identity);
        GSubManager.instance.TT_SkillAttack0_3PosY = -3.5f;

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_3PosY = 0.0f;

        //刺突斬りN
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_3Prefab, new Vector3(player.x, 3.5f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_3PosY = 3.5f;

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_3PosY = 0.0f;

        //刺突E
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.TT_SkillAttack0_2PosX = 4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        StartCoroutine(SkillAttack0_3());
    }
    #endregion


    #region//3:横一文字E、刺突E、横一文字S、参命剣S、参命剣W、参命剣N
    IEnumerator SkillAttack0_3()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return new WaitForSeconds(2.0f);

        //横一文字E
        for (int i = 0; i < 5; i++)
        {
            Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(4.3f, -0.66f, -0.05f), Quaternion.Euler(0, 0, 90));
            GSubManager.instance.TT_SkillAttack0_1PosX = 4.3f;
            yield return waitHalfS;

            Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(4.3f, 0.66f - 0.05f), Quaternion.Euler(0, 0, 90));
            GSubManager.instance.TT_SkillAttack0_1PosX = 4.3f;
            yield return waitHalfS;
        }

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_1PosX = 0.0f;

        //刺突E
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.TT_SkillAttack0_2PosX = 4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        //横一文字S
        for (int i = 0; i < 5; i++)
        {
            Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(-0.66f, -4.3f, -0.05f), Quaternion.identity);
            GSubManager.instance.TT_SkillAttack0_1PosY = -4.3f;
            yield return waitHalfS;

            Instantiate(E_TT_SkillAttack0_1Prefab, new Vector3(0.66f, -4.3f - 0.05f), Quaternion.identity);
            GSubManager.instance.TT_SkillAttack0_1PosY = -4.3f;
            yield return waitHalfS;
        }

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_1PosY = 0.0f;

        //参命剣S
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(player.x - 0.66f, -4.3f, -0.05f), Quaternion.identity);
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(player.x, -4.3f, -0.05f), Quaternion.identity);
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(player.x + 0.66f, -4.3f, -0.05f), Quaternion.identity);
        GSubManager.instance.TT_SkillAttack0_2PosY = -4.3f;

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //参命剣W
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(-4.3f, player.y - 0.66f, -0.05f), Quaternion.Euler(0, 0, -90));
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(-4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(-4.3f, player.y + 0.66f, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.TT_SkillAttack0_2PosX = -4.3f;

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        //参命剣N
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(player.x - 0.66f, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(player.x, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_TT_SkillAttack0_2Prefab, new Vector3(player.x + 0.66f, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_2PosY = 4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        yield return new WaitForSeconds(2.0f);
        Debug.Log("真道裏念流 縮地 破ノ型「参命剣」を終了");
    }
    #endregion

    #region//4:刹殺N、刹殺、刹殺、刹殺
    IEnumerator SkillAttack0_4()
    {
        yield return new WaitForSeconds(2.0f);

        //刹殺N

    }
    #endregion
}