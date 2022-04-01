using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryBase : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] UnityEngine.UI.Text NameText;
    [SerializeField] UnityEngine.UI.Text TalkText;

    [SerializeField] [Header("名前")] public string[] names;
    [SerializeField] [Header("会話")] public string[] talks;

    //TalkButtonオブジェクトを入れる
    public GameObject talkButton;
    #endregion


    #region//プライベート設定
    //時間を計測する
    [System.NonSerialized] public float time = 0;

    //配列の要素数
    [System.NonSerialized] public int nameCount = 0;
    [System.NonSerialized] public int talkCount = 0;
    #endregion


    // Start is called before the first frame update
    public virtual void Start()
    {
        //TalkButtonを非表示にする
        talkButton.SetActive(false);
    }


    // Update is called once per frame
    public virtual void Update()
    {
        time += Time.deltaTime;

        if (1.5f <= time)
        {
            //TalkButtonを表示
            talkButton.SetActive(true);
        }

        if (talkCount == talks.Length)
        {
            //TalkButtonを非表示にする
            talkButton.SetActive(false);
        }
    }


    public virtual void OnClick()
    {
        //名前の要素数をカウントする
        NameText.text = names[nameCount];
        nameCount += 1;

        //名前の要素数をカウントする
        TalkText.text = talks[talkCount];
        talkCount += 1;
    }
}
