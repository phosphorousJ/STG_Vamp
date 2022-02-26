using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_BK_SkillAttack0Manager : MonoBehaviour
{
    #region//インスペクター設定
    //Playerオブジェクトを入れる
    public GameObject Player;

    //E_BK_SkillAttack0_0Prefabを入れる
    public GameObject E_BK_SkillAttack0_0Prefab;

    //E_TT_SkillAttack0_1Prefabを入れる
    public GameObject E_BK_SkillAttack0_1Prefab;

    //E_TT_SkillAttack0_2Prefabを入れる
    public GameObject E_BK_SkillAttack0_2Prefab;
    #endregion


    #region//プライベート設定
    //Playerの座標
    private Vector3 player;
    #endregion


    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("BKが大技0を発動!");

        //コルーチン開始
        StartCoroutine(SkillAttack0_3());
    }


    #region//0:パンチS、パンチN、パンチW、パンチW、パンチE、パンチN、パンチN
    IEnumerator SkillAttack0_0()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return new WaitForSeconds(2.0f);

        //パンチS
        player = Player.transform.position;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(player.x, -3.55f, -0.05f), Quaternion.identity);
        GSubManager.instance.BK_SkillAttack0_1PosY = -3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;

        //パンチN
        player = Player.transform.position;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(player.x, 3.55f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.BK_SkillAttack0_1PosY = 3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;

        //パンチW
        player = Player.transform.position;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(-3.55f, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.BK_SkillAttack0_1PosX = -3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        //パンチW
        player = Player.transform.position;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(-3.55f, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.BK_SkillAttack0_1PosX = -3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        //パンチE
        player = Player.transform.position;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(3.55f, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.BK_SkillAttack0_1PosX = 3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        //パンチN
        player = Player.transform.position;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(player.x, 3.55f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.BK_SkillAttack0_1PosY = 3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;

        //パンチN
        player = Player.transform.position;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(player.x, 3.55f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.BK_SkillAttack0_1PosY = 3.55f;

        yield return waitHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;

        StartCoroutine(SkillAttack0_1());
    }
    #endregion

    #region//1:パンチNN、パンチEE、パンチWW、パンチSE、パンチNW、パンチNE、パンチSW
    IEnumerator SkillAttack0_1()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return waitOneS;

        //パンチNN
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(-1.0f, 3.55f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(1.0f, 3.55f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.BK_SkillAttack0_1PosY = 3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;

        //パンチEE
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(3.55f, 1.0f, -0.05f), Quaternion.Euler(0, 0, 90));
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(3.55f, -0.35f, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.BK_SkillAttack0_1PosX = 3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        //パンチWW
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(-3.55f, 1.0f, -0.05f), Quaternion.Euler(0, 0, -90));
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(-3.55f, -1.0f, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.BK_SkillAttack0_1PosX = -3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        //パンチSE
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(0.0f, -3.55f, -0.05f), Quaternion.identity);
        GSubManager.instance.BK_SkillAttack0_1PosY = -3.55f;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(3.55f, 0.0f, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.BK_SkillAttack0_1PosX = 3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        //パンチNW
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(1.0f, 3.55f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.BK_SkillAttack0_1PosY = 3.55f;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(-3.55f, -0.35f, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.BK_SkillAttack0_1PosX = -3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        //パンチNE
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(-1.0f, 3.55f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.BK_SkillAttack0_1PosY = 3.55f;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(3.55f, 1.0f, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.BK_SkillAttack0_1PosX = 3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        //パンチSW
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(0.35f, -3.55f, -0.05f), Quaternion.identity);
        GSubManager.instance.BK_SkillAttack0_1PosY = -3.55f;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(-3.55f, -1.0f, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.BK_SkillAttack0_1PosX = -3.55f;

        yield return waitHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        StartCoroutine(SkillAttack0_2());
    }
    #endregion

    #region//2:スタンプS、スタンプN、スタンプEW、スタンプSS、スタンプNN、スタンプEEE
    IEnumerator SkillAttack0_2()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return waitOneS;

        //スタンプS
        player = Player.transform.position;
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(player.x, player.y, -0.05f), Quaternion.identity);
        GSubManager.instance.BK_SkillAttack0_2PosX = player.x;
        GSubManager.instance.BK_SkillAttack0_2PosY = player.y;

        yield return waitHalfS;
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(GSubManager.instance.BK_SkillAttack0_2PosX, GSubManager.instance.BK_SkillAttack0_2PosY, -0.05f), Quaternion.identity);

        yield return waitOneS;
        GSubManager.instance.BK_SkillAttack0_2PosX = 0.0f;
        GSubManager.instance.BK_SkillAttack0_2PosY = 0.0f;

        //スタンプN
        player = Player.transform.position;
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(player.x, player.y, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.BK_SkillAttack0_2PosX = player.x;
        GSubManager.instance.BK_SkillAttack0_2PosY = player.y;

        yield return waitHalfS;
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(GSubManager.instance.BK_SkillAttack0_2PosX, GSubManager.instance.BK_SkillAttack0_2PosY, -0.05f), Quaternion.Euler(0, 0, 180));

        yield return waitOneS;
        GSubManager.instance.BK_SkillAttack0_2PosX = 0.0f;
        GSubManager.instance.BK_SkillAttack0_2PosY = 0.0f;

        //スタンプEW
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(0.9f, 0.0f, -0.05f), Quaternion.Euler(0, 0, 90));
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(-0.9f, 0.0f, -0.05f), Quaternion.Euler(0, 0, -90));

        yield return waitHalfS;
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(0.9f, 0.0f, -0.05f), Quaternion.Euler(0, 0, 90));
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(-0.9f, 0.0f, -0.05f), Quaternion.Euler(0, 0, -90));

        yield return waitOneS;

        //スタンプSS
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(-0.35f, 0.65f, -0.05f), Quaternion.identity);
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(0.35f, -0.65f, -0.05f), Quaternion.identity);

        yield return waitHalfS;
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(-0.35f, 0.65f, -0.05f), Quaternion.identity);
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(0.35f, -0.65f, -0.05f), Quaternion.identity);

        yield return waitOneS;

        //スタンプNN
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(0.65f, 0.65f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(-0.65f, -0.65f, -0.05f), Quaternion.Euler(0, 0, 180));

        yield return waitHalfS;
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(0.65f, 0.65f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(-0.65f, -0.65f, -0.05f), Quaternion.Euler(0, 0, 180));

        yield return waitOneS;

        //スタンプEEE
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(-0.65f, 0.85f, -0.05f), Quaternion.Euler(0, 0, 90));
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(-0.65f, -0.85f, -0.05f), Quaternion.Euler(0, 0, 90));
        Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(0.65f, 0.0f, -0.05f), Quaternion.Euler(0, 0, 90));

        yield return waitHalfS;
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(-0.65f, 0.85f, -0.05f), Quaternion.Euler(0, 0, 90));
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(-0.65f, -0.85f, -0.05f), Quaternion.Euler(0, 0, 90));
        Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(0.65f, 0.0f, -0.05f), Quaternion.Euler(0, 0, 90));

        yield return waitOneHalfS;
        StartCoroutine(SkillAttack0_3());
    }
    #endregion

    #region//3:パンチS、スタンプ連打S、パンチW、スタンプ連打W、パンチSE、スタンプ連打N、パンチNW
    IEnumerator SkillAttack0_3()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return new WaitForSeconds(2.0f);

        //パンチS
        player = Player.transform.position;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(player.x, -3.55f, -0.05f), Quaternion.identity);
        GSubManager.instance.BK_SkillAttack0_1PosY = -3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;

        //スタンプ連打S
        for (int i = 0;i < 10; i++)
        {
            player = Player.transform.position;
            Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(player.x, player.y, -0.05f), Quaternion.identity);
            GSubManager.instance.BK_SkillAttack0_2PosX = player.x;
            GSubManager.instance.BK_SkillAttack0_2PosY = player.y;

            yield return waitHalfS;
            Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(GSubManager.instance.BK_SkillAttack0_2PosX, GSubManager.instance.BK_SkillAttack0_2PosY, -0.05f), Quaternion.identity);

            yield return waitHalfS;
            GSubManager.instance.BK_SkillAttack0_2PosX = 0.0f;
            GSubManager.instance.BK_SkillAttack0_2PosY = 0.0f;
        }

        //パンチW
        player = Player.transform.position;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(-3.55f, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.BK_SkillAttack0_1PosX = -3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        //スタンプ連打W
        for (int i = 0; i < 10; i++)
        {
            player = Player.transform.position;
            Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(player.x, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
            GSubManager.instance.BK_SkillAttack0_2PosX = player.x;
            GSubManager.instance.BK_SkillAttack0_2PosY = player.y;

            yield return waitHalfS;
            Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(GSubManager.instance.BK_SkillAttack0_2PosX, GSubManager.instance.BK_SkillAttack0_2PosY, -0.05f), Quaternion.Euler(0, 0, -90));

            yield return waitHalfS;
            GSubManager.instance.BK_SkillAttack0_2PosX = 0.0f;
            GSubManager.instance.BK_SkillAttack0_2PosY = 0.0f;
        }

        //パンチSE
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(0.0f, -3.55f, -0.05f), Quaternion.identity);
        GSubManager.instance.BK_SkillAttack0_1PosY = -3.55f;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(3.55f, 0.0f, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.BK_SkillAttack0_1PosX = 3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        //スタンプ連打N
        for (int i = 0; i < 10; i++)
        {
            player = Player.transform.position;
            Instantiate(E_BK_SkillAttack0_0Prefab, new Vector3(player.x, player.y, -0.05f), Quaternion.Euler(0, 0, 180));
            GSubManager.instance.BK_SkillAttack0_2PosX = player.x;
            GSubManager.instance.BK_SkillAttack0_2PosY = player.y;

            yield return waitHalfS;
            Instantiate(E_BK_SkillAttack0_2Prefab, new Vector3(GSubManager.instance.BK_SkillAttack0_2PosX, GSubManager.instance.BK_SkillAttack0_2PosY, -0.05f), Quaternion.Euler(0, 0, 180));

            yield return waitHalfS;
            GSubManager.instance.BK_SkillAttack0_2PosX = 0.0f;
            GSubManager.instance.BK_SkillAttack0_2PosY = 0.0f;
        }

        //パンチNE
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(-1.0f, 3.55f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.BK_SkillAttack0_1PosY = 3.55f;
        Instantiate(E_BK_SkillAttack0_1Prefab, new Vector3(3.55f, 1.0f, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.BK_SkillAttack0_1PosX = 3.55f;

        yield return waitOneHalfS;
        GSubManager.instance.BK_SkillAttack0_1PosY = 0.0f;
        GSubManager.instance.BK_SkillAttack0_1PosX = 0.0f;

        yield return new WaitForSeconds(2.0f);
        Debug.Log("BKが大技0を終了");
    }
    #endregion
}
