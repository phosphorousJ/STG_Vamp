using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart4 : MonoBehaviour
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

        FadeManager.Instance.LoadScene("TalkScene4_2", 2.0f);
    }
}
