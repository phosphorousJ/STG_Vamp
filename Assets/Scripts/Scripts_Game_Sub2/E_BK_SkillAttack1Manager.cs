using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_BK_SkillAttack1Manager : MonoBehaviour
{
    #region//インスペクター設定
    //Playerオブジェクトを入れる
    public GameObject Player;

    //E_BK_SkillAttack1_0_2Prefabを入れる
    public GameObject E_BK_SkillAttack1_0_2Prefab;

    //E_BK_SkillAttack1_0_3Prefabを入れる
    public GameObject E_BK_SkillAttack1_0_3Prefab;

    //E_BK_SkillAttack1_1Prefabを配列に入れる
    public GameObject[] E_BK_SkillAttacks1 = new GameObject[4];

    //E_BK_SkillAttack1_2Prefabを入れる
    public GameObject E_BK_SkillAttack1_2Prefab;

    //E_BK_SkillAttack1_3Prefabを入れる
    public GameObject E_BK_SkillAttack1_3Prefab;
    #endregion


    #region//プライベート設定
    //Playerの座標
    private Vector3 player;

    //攻撃位置の配列
    private float[] attackPos = { 1.32f, 0.66f, 0.0f, -0.66f, -1.32f };
    #endregion


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("BKが大技1を発動!");

        //コルーチン開始
        StartCoroutine(SkillAttack1_2());
    }


    # region//0:スタンプ連打S、水晶S×4、水晶E×4、スタンプ連打W、水晶W×4、水晶N×4
    IEnumerator SkillAttack1_0()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return new WaitForSeconds(2.0f);

        //スタンプ連打S
        for (int i = 0; i < 10; i++)
        {
            player = Player.transform.position;
            Instantiate(E_BK_SkillAttack1_0_2Prefab, new Vector3(player.x, player.y, -0.05f), Quaternion.identity);
            GSubManager.instance.BK_SkillAttack1_2PosX = player.x;
            GSubManager.instance.BK_SkillAttack1_2PosY = player.y;

            yield return waitHalfS;
            Instantiate(E_BK_SkillAttack1_2Prefab, new Vector3(GSubManager.instance.BK_SkillAttack1_2PosX, GSubManager.instance.BK_SkillAttack1_2PosY, -0.05f), Quaternion.identity);

            yield return waitHalfS;
            GSubManager.instance.BK_SkillAttack1_2PosX = 0.0f;
            GSubManager.instance.BK_SkillAttack1_2PosY = 0.0f;
        }

        //水晶S×4
        GameObject E_BK_SkillAttack1_1_SPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];

        Instantiate(E_BK_SkillAttack1_1_SPrefab, new Vector3(-1.32f, -4.2f, -0.05f), Quaternion.identity);
        Instantiate(E_BK_SkillAttack1_1_SPrefab, new Vector3(-0.66f, -4.2f, -0.05f), Quaternion.identity);
        Instantiate(E_BK_SkillAttack1_1_SPrefab, new Vector3(0.0f, -4.2f, -0.05f), Quaternion.identity);
        Instantiate(E_BK_SkillAttack1_1_SPrefab, new Vector3(0.66f, -4.2f, -0.05f), Quaternion.identity);
        GSubManager.instance.BK_SkillAttack1_1PosY = -4.2f;

        yield return waitOneS;
        GSubManager.instance.BK_SkillAttack1_1PosY = 0.0f;

        //水晶E×4
        GameObject E_BK_SkillAttack1_1_EPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];

        Instantiate(E_BK_SkillAttack1_1_EPrefab, new Vector3(4.2f, -1.32f, -0.05f), Quaternion.Euler(0, 0, 90));
        Instantiate(E_BK_SkillAttack1_1_EPrefab, new Vector3(4.2f, -0.66f, -0.05f), Quaternion.Euler(0, 0, 90));
        Instantiate(E_BK_SkillAttack1_1_EPrefab, new Vector3(4.2f, 0.0f, -0.05f), Quaternion.Euler(0, 0, 90));
        Instantiate(E_BK_SkillAttack1_1_EPrefab, new Vector3(4.2f, 0.66f, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.BK_SkillAttack1_1PosX = 4.2f;

        yield return waitOneS;
        GSubManager.instance.BK_SkillAttack1_1PosX = 0.0f;

        //スタンプ連打W
        for (int i = 0; i < 10; i++)
        {
            player = Player.transform.position;
            Instantiate(E_BK_SkillAttack1_0_2Prefab, new Vector3(player.x, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
            GSubManager.instance.BK_SkillAttack1_2PosX = player.x;
            GSubManager.instance.BK_SkillAttack1_2PosY = player.y;

            yield return waitHalfS;
            Instantiate(E_BK_SkillAttack1_2Prefab, new Vector3(GSubManager.instance.BK_SkillAttack1_2PosX, GSubManager.instance.BK_SkillAttack1_2PosY, -0.05f), Quaternion.Euler(0, 0, -90));

            yield return waitHalfS;
            GSubManager.instance.BK_SkillAttack1_2PosX = 0.0f;
            GSubManager.instance.BK_SkillAttack1_2PosY = 0.0f;
        }

        //水晶W×4
        GameObject E_BK_SkillAttack1_1_WPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];

        Instantiate(E_BK_SkillAttack1_1_WPrefab, new Vector3(-4.2f, -1.32f, -0.05f), Quaternion.Euler(0, 0, -90));
        Instantiate(E_BK_SkillAttack1_1_WPrefab, new Vector3(-4.2f, -0.66f, -0.05f), Quaternion.Euler(0, 0, -90));
        Instantiate(E_BK_SkillAttack1_1_WPrefab, new Vector3(-4.2f, 0.66f, -0.05f), Quaternion.Euler(0, 0, -90));
        Instantiate(E_BK_SkillAttack1_1_WPrefab, new Vector3(-4.2f, 1.32f, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.BK_SkillAttack1_1PosX = -4.2f;

        yield return waitOneS;
        GSubManager.instance.BK_SkillAttack1_1PosX = 0.0f;

        //水晶N×4
        GameObject E_BK_SkillAttack1_1_NPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];

        Instantiate(E_BK_SkillAttack1_1_NPrefab, new Vector3(-1.32f, 4.2f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_BK_SkillAttack1_1_NPrefab, new Vector3(0.0f, 4.2f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_BK_SkillAttack1_1_NPrefab, new Vector3(0.66f, 4.2f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_BK_SkillAttack1_1_NPrefab, new Vector3(1.32f, 4.2f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.BK_SkillAttack1_1PosY = 4.2f;

        yield return waitOneS;
        GSubManager.instance.BK_SkillAttack1_1PosY = 0.0f;

        yield return waitOneHalfS;
        StartCoroutine(SkillAttack1_1());
    }
    #endregion

    #region//1:水晶(時計回り)
    IEnumerator SkillAttack1_1()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return waitHalfS;

        //水晶(時計回り・大)
        for (int i = 0; i < attackPos.Length; i++)//E
        {
            GameObject E_BK_SkillAttack1_1_EPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_EPrefab, new Vector3(4.2f, attackPos[i], -0.05f), Quaternion.Euler(0, 0, 90));
            GSubManager.instance.BK_SkillAttack1_1PosX = 4.2f;

            yield return new WaitForSeconds(0.3f);
        }
        for (int i = 0; i < attackPos.Length; i++)//S
        {
            GameObject E_BK_SkillAttack1_1_SPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_SPrefab, new Vector3(attackPos[i], -4.2f, -0.05f), Quaternion.identity);
            GSubManager.instance.BK_SkillAttack1_1PosY = -4.2f;

            yield return new WaitForSeconds(0.3f);
        }
        for (int i = 0; i < attackPos.Length; i++)//W
        {
            GameObject E_BK_SkillAttack1_1_WPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_WPrefab, new Vector3(-4.2f, -attackPos[i], -0.05f), Quaternion.Euler(0, 0, -90));
            GSubManager.instance.BK_SkillAttack1_1PosX = -4.2f;

            yield return new WaitForSeconds(0.3f);
        }
        for (int i = 0; i < attackPos.Length; i++)//N
        {
            GameObject E_BK_SkillAttack1_1_NPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_NPrefab, new Vector3(-attackPos[i], 4.2f, -0.05f), Quaternion.Euler(0, 0, 180));

            GSubManager.instance.BK_SkillAttack1_1PosY = 4.2f;

            yield return new WaitForSeconds(0.3f);
        }

        //水晶(時計回り・中)
        for (int i = 0; i < attackPos.Length; i++)//E
        {
            GameObject E_BK_SkillAttack1_1_EPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_EPrefab, new Vector3(2.8f, attackPos[i], -0.05f), Quaternion.Euler(0, 0, 90));
            GSubManager.instance.BK_SkillAttack1_1PosX = 2.8f;

            yield return new WaitForSeconds(0.3f);
        }
        for (int i = 0; i < attackPos.Length; i++)//S
        {
            GameObject E_BK_SkillAttack1_1_SPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_SPrefab, new Vector3(attackPos[i], -2.8f, -0.05f), Quaternion.identity);
            GSubManager.instance.BK_SkillAttack1_1PosY = -2.8f;

            yield return new WaitForSeconds(0.3f);
        }
        for (int i = 0; i < attackPos.Length; i++)//W
        {
            GameObject E_BK_SkillAttack1_1_WPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_WPrefab, new Vector3(-2.8f, -attackPos[i], -0.05f), Quaternion.Euler(0, 0, -90));
            GSubManager.instance.BK_SkillAttack1_1PosX = -2.8f;

            yield return new WaitForSeconds(0.3f);
        }
        for (int i = 0; i < attackPos.Length; i++)//N
        {
            GameObject E_BK_SkillAttack1_1_NPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_NPrefab, new Vector3(-attackPos[i], 2.8f, -0.05f), Quaternion.Euler(0, 0, 180));

            GSubManager.instance.BK_SkillAttack1_1PosY = 2.8f;

            yield return new WaitForSeconds(0.3f);
        }

        //水晶(時計回り・小)
        for (int i = 0; i < attackPos.Length; i++)//E
        {
            GameObject E_BK_SkillAttack1_1_EPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_EPrefab, new Vector3(1.4f, attackPos[i], -0.05f), Quaternion.Euler(0, 0, 90));
            GSubManager.instance.BK_SkillAttack1_1PosX = 1.4f;

            yield return new WaitForSeconds(0.3f);
        }
        for (int i = 0; i < attackPos.Length; i++)//S
        {
            GameObject E_BK_SkillAttack1_1_SPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_SPrefab, new Vector3(attackPos[i], -1.4f, -0.05f), Quaternion.identity);
            GSubManager.instance.BK_SkillAttack1_1PosY = -1.4f;

            yield return new WaitForSeconds(0.3f);
        }
        for (int i = 0; i < attackPos.Length; i++)//W
        {
            GameObject E_BK_SkillAttack1_1_WPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_WPrefab, new Vector3(-1.4f, -attackPos[i], -0.05f), Quaternion.Euler(0, 0, -90));
            GSubManager.instance.BK_SkillAttack1_1PosX = -1.4f;

            yield return new WaitForSeconds(0.3f);
        }
        for (int i = 0; i < attackPos.Length; i++)//N
        {
            GameObject E_BK_SkillAttack1_1_NPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_NPrefab, new Vector3(-attackPos[i], 1.4f, -0.05f), Quaternion.Euler(0, 0, 180));

            GSubManager.instance.BK_SkillAttack1_1PosY = 1.4f;

            yield return new WaitForSeconds(0.3f);
        }

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack1_1PosX = 0.0f;
        GSubManager.instance.BK_SkillAttack1_1PosY = 0.0f;

        yield return waitHalfS;
        StartCoroutine(SkillAttack1_2());
    }
    #endregion

    #region//2:キックN、水晶N,キックE、スタンプE、キックW、水晶W、キックS、水晶S
    IEnumerator SkillAttack1_2()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return waitOneHalfS;

        //キックN
        Instantiate(E_BK_SkillAttack1_0_3Prefab, new Vector3(-0.66f, 0.0f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.BK_SkillAttack1_3PosX = -0.66f;

        yield return waitHalfS;
        Instantiate(E_BK_SkillAttack1_3Prefab, new Vector3(GSubManager.instance.BK_SkillAttack1_3PosX, 0.0f, -0.05f), Quaternion.Euler(0, 0, 180));

        yield return waitOneS;
        GSubManager.instance.BK_SkillAttack1_3PosX = 0.0f;

        //水晶N
        for (int i = 0; i < 26; i++)
        {
            GameObject E_BK_SkillAttack1_1_NPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_NPrefab, new Vector3(0.66f, 4.2f, -0.05f), Quaternion.Euler(0, 0, 180));
            yield return new WaitForSeconds(0.25f);

            GSubManager.instance.BK_SkillAttack1_1PosY = 4.2f;

            GameObject E_BK_SkillAttack1_2_NPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_2_NPrefab, new Vector3(1.32f, 4.2f, -0.05f), Quaternion.Euler(0, 0, 180));
            yield return new WaitForSeconds(0.25f);

            GSubManager.instance.BK_SkillAttack1_1PosY = 4.2f; 
        }
        yield return waitHalfS;
        GSubManager.instance.BK_SkillAttack1_1PosY = 0.0f;

        //キックE
        Instantiate(E_BK_SkillAttack1_0_3Prefab, new Vector3(0.0f, -0.66f, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.BK_SkillAttack1_3PosY = -0.66f;

        yield return waitHalfS;
        Instantiate(E_BK_SkillAttack1_3Prefab, new Vector3(0.0f, GSubManager.instance.BK_SkillAttack1_3PosY, -0.05f), Quaternion.Euler(0, 0, 90));

        yield return waitOneS;
        GSubManager.instance.BK_SkillAttack1_3PosY = 0.0f;

        //スタンプ連打E
        for (int i = 0; i < 13; i++)
        {
            player = Player.transform.position;
            Instantiate(E_BK_SkillAttack1_0_2Prefab, new Vector3(player.x, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
            GSubManager.instance.BK_SkillAttack1_2PosX = player.x;
            GSubManager.instance.BK_SkillAttack1_2PosY = player.y;

            yield return waitHalfS;
            Instantiate(E_BK_SkillAttack1_2Prefab, new Vector3(GSubManager.instance.BK_SkillAttack1_2PosX, GSubManager.instance.BK_SkillAttack1_2PosY, -0.05f), Quaternion.Euler(0, 0, 90));

            yield return waitHalfS;
            GSubManager.instance.BK_SkillAttack1_2PosX = 0.0f;
            GSubManager.instance.BK_SkillAttack1_2PosY = 0.0f;
        }
        yield return waitOneHalfS;

        //キックW
        Instantiate(E_BK_SkillAttack1_0_3Prefab, new Vector3(0.0f, 0.66f, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.BK_SkillAttack1_3PosY = 0.66f;

        yield return waitHalfS;
        Instantiate(E_BK_SkillAttack1_3Prefab, new Vector3(0.0f, GSubManager.instance.BK_SkillAttack1_3PosY, -0.05f), Quaternion.Euler(0, 0, -90));

        yield return waitOneS;
        GSubManager.instance.BK_SkillAttack1_3PosY = 0.0f;

        //スタンプ連打W
        for (int i = 0; i < 13; i++)
        {
            player = Player.transform.position;
            Instantiate(E_BK_SkillAttack1_0_2Prefab, new Vector3(player.x, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
            GSubManager.instance.BK_SkillAttack1_2PosX = player.x;
            GSubManager.instance.BK_SkillAttack1_2PosY = player.y;

            yield return waitHalfS;
            Instantiate(E_BK_SkillAttack1_2Prefab, new Vector3(GSubManager.instance.BK_SkillAttack1_2PosX, GSubManager.instance.BK_SkillAttack1_2PosY, -0.05f), Quaternion.Euler(0, 0, -90));

            yield return waitHalfS;
            GSubManager.instance.BK_SkillAttack1_2PosX = 0.0f;
            GSubManager.instance.BK_SkillAttack1_2PosY = 0.0f;
        }
        yield return waitOneHalfS;

        //キックS
        Instantiate(E_BK_SkillAttack1_0_3Prefab, new Vector3(0.66f, 0.0f, -0.05f), Quaternion.identity);
        GSubManager.instance.BK_SkillAttack1_3PosX = 0.66f;

        yield return waitHalfS;
        Instantiate(E_BK_SkillAttack1_3Prefab, new Vector3(GSubManager.instance.BK_SkillAttack1_3PosX, 0.0f, -0.05f), Quaternion.identity);

        yield return waitOneS;
        GSubManager.instance.BK_SkillAttack1_3PosX = 0.0f;

        //水晶N
        for (int i = 0; i < 26; i++)
        {
            GameObject E_BK_SkillAttack1_1_NPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_1_NPrefab, new Vector3(-0.66f, -4.2f, -0.05f), Quaternion.identity);
            yield return new WaitForSeconds(0.25f);

            GSubManager.instance.BK_SkillAttack1_1PosY = -4.2f;

            GameObject E_BK_SkillAttack1_2_NPrefab = E_BK_SkillAttacks1[Random.Range(0, E_BK_SkillAttacks1.Length)];
            Instantiate(E_BK_SkillAttack1_2_NPrefab, new Vector3(-1.32f, -4.2f, -0.05f), Quaternion.identity);
            yield return new WaitForSeconds(0.25f);

            GSubManager.instance.BK_SkillAttack1_1PosY = -4.2f;
        }
        yield return waitHalfS;
        GSubManager.instance.BK_SkillAttack1_1PosY = 0.0f;

        yield return new WaitForSeconds(2.0f);
        Debug.Log("BKが己心解錠「玉石混淆」を終了");
    }
    #endregion
}
