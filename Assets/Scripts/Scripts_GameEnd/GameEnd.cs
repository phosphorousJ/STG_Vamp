using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //一定時間後にシーン推移
        Invoke("FadeScene", 5.0f);
    }


    void FadeScene()
    {
        FadeManager.Instance.LoadScene("TitleScene", 5.0f);
    }
}
