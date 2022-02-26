using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart1_2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //コルーチン開始
        StartCoroutine(FadeScene());
    }


    IEnumerator FadeScene()
    {
        yield return new WaitForSeconds(4);

        FadeManager.Instance.LoadScene("GameSubScene1_1", 1.0f);
    }
}
