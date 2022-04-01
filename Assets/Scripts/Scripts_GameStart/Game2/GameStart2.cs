using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //コルーチン開始
        StartCoroutine(FadeScene());
    }


    IEnumerator FadeScene()
    {
        yield return new WaitForSeconds(3);

        FadeManager.Instance.LoadScene("TalkScene2_1", 2.0f);
    }
}
