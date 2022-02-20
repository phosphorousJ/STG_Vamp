using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart0 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //コルーチン開始
        StartCoroutine(FadeScene());
    }


    //フェードイン処理
    IEnumerator FadeScene()
    {
        yield return new WaitForSeconds(3);

        FadeManager.Instance.LoadScene("TalkScene0_1", 2.0f);
    }
}
