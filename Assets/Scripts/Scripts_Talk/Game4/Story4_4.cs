using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //一定時間後にシーン推移
        Invoke("FadeScene", 3.0f);
    }


    void FadeScene()
    {
        FadeManager.Instance.LoadScene("TalkScene4_5", 2.0f);
    }
}
