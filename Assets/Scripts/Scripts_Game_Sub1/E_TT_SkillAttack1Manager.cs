using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_TT_SkillAttack1Manager : MonoBehaviour
{
    #region//インスペクター設定
    //Playerオブジェクトを入れる
    public GameObject Player;

    //E_TT_SkillAttack1_2Prefabを入れる
    public GameObject E_TT_SkillAttack1_2Prefab;

    //E_TT_SkillAttack1_3Prefabを入れる
    public GameObject E_TT_SkillAttack1_3Prefab;
    #endregion


    #region//プライベート設定
    //Playerの座標
    private Vector3 player;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("TTが大技1を発動!");

        //コルーチン開始
        StartCoroutine(SkillAttack1_0());
    }


    #region//0:刺突E、刺突E、刺突斬りE、刺突S、刺突S、刺突斬りN
    IEnumerator SkillAttack1_0()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return new WaitForSeconds(3.0f);

        //刺突E
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.TT_SkillAttack0_2PosX = 4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        //刺突E
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.TT_SkillAttack0_2PosX = 4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        //刺突斬りE
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_3Prefab, new Vector3(3.5f, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.TT_SkillAttack0_3PosX = 3.5f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_3PosX = 0.0f;

        //刺突S
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, -4.3f, -0.05f), Quaternion.identity);
        GSubManager.instance.TT_SkillAttack0_2PosY = -4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //刺突S
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, -4.3f, -0.05f), Quaternion.identity);
        GSubManager.instance.TT_SkillAttack0_2PosY = -4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //刺突斬りN
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_3Prefab, new Vector3(player.x, 3.5f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_3PosY = 3.5f;

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_3PosY = 0.0f;

        StartCoroutine(SkillAttack1_1());
    }
    #endregion

    #region//1:刺突斬りS、刺突斬りW、刺突斬りN、刺突斬りE、刺突N、刺突S
    IEnumerator SkillAttack1_1()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return waitHalfS;

        //刺突斬りS
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_3Prefab, new Vector3(player.x, -3.5f, -0.05f), Quaternion.identity);
        GSubManager.instance.TT_SkillAttack0_3PosY = -3.5f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_3PosY = 0.0f;

        //刺突斬りW
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_3Prefab, new Vector3(-3.5f, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.TT_SkillAttack0_3PosX = -3.5f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_3PosX = 0.0f;

        //刺突斬りN
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_3Prefab, new Vector3(player.x, 3.5f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_3PosY = 3.5f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_3PosY = 0.0f;

        //刺突斬りE
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_3Prefab, new Vector3(3.5f, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.TT_SkillAttack0_3PosX = 3.5f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_3PosX = 0.0f;

        //刺突N
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_2PosY = 4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //刺突S
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, -4.3f, -0.05f), Quaternion.identity);
        GSubManager.instance.TT_SkillAttack0_2PosY = -4.3f;

        yield return waitOneHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        StartCoroutine(SkillAttack1_2());
    }
    #endregion

    #region//2:刺突N、刺突S、刺突N、刺突S、刺突N、刺突S、刺突斬りN
    IEnumerator SkillAttack1_2()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return new WaitForSeconds(2.0f);

        //刺突N
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_2PosY = 4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //刺突S
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, -4.3f, -0.05f), Quaternion.identity);
        GSubManager.instance.TT_SkillAttack0_2PosY = -4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //刺突N
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_2PosY = 4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //刺突S
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, -4.3f, -0.05f), Quaternion.identity);
        GSubManager.instance.TT_SkillAttack0_2PosY = -4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //刺突N
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_2PosY = 4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //刺突S
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, -4.3f, -0.05f), Quaternion.identity);
        GSubManager.instance.TT_SkillAttack0_2PosY = -4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //刺突斬りN
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_3Prefab, new Vector3(player.x, 3.5f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_3PosY = 3.5f;

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_3PosY = 0.0f;

        StartCoroutine(SkillAttack1_3());
    }
    #endregion

    #region//3:刺突E、刺突W、刺突E、刺突W、刺突斬りS、刺突斬りN、刺突S、参命剣N
    IEnumerator SkillAttack1_3()
    {
        var waitHalfS = new WaitForSeconds(0.5f);
        var waitOneS = new WaitForSeconds(1.0f);
        var waitOneHalfS = new WaitForSeconds(1.5f);

        yield return waitHalfS;

        //刺突E
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.TT_SkillAttack0_2PosX = 4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        //刺突W
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(-4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.TT_SkillAttack0_2PosX = -4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        //刺突E
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, 90));
        GSubManager.instance.TT_SkillAttack0_2PosX = 4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        //刺突W
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(-4.3f, player.y, -0.05f), Quaternion.Euler(0, 0, -90));
        GSubManager.instance.TT_SkillAttack0_2PosX = -4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosX = 0.0f;

        //刺突斬りS
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_3Prefab, new Vector3(player.x, -3.5f, -0.05f), Quaternion.identity);
        GSubManager.instance.TT_SkillAttack0_3PosY = -3.5f;

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_3PosY = 0.0f;

        //刺突斬りN
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_3Prefab, new Vector3(player.x, 3.5f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_3PosY = 3.5f;

        yield return waitOneS;
        GSubManager.instance.TT_SkillAttack0_3PosY = 0.0f;

        //刺突S
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, -4.3f, -0.05f), Quaternion.identity);
        GSubManager.instance.TT_SkillAttack0_2PosY = -4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        //参命剣N
        player = Player.transform.position;
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x - 0.66f, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
        Instantiate(E_TT_SkillAttack1_2Prefab, new Vector3(player.x + 0.66f, 4.3f, -0.05f), Quaternion.Euler(0, 0, 180));
        GSubManager.instance.TT_SkillAttack0_2PosY = 4.3f;

        yield return waitHalfS;
        GSubManager.instance.TT_SkillAttack0_2PosY = 0.0f;

        yield return new WaitForSeconds(2.0f);
        Debug.Log("TTが己心解錠「白黒分明」を終了");
    }
    #endregion
}
