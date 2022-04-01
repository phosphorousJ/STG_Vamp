using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart1_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //コルーチン開始
        StartCoroutine(FadeScene());
    }


    IEnumerator FadeScene()
    {
        yield return new WaitForSeconds(1.5f);

        FadeManager.Instance.LoadScene("GameStartScene1_2", 1.0f);
    }
}
