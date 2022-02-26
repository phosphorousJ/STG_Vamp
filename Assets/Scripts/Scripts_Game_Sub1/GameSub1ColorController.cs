using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSub1ColorController : MonoBehaviour
{
    //Materialを入れる
    protected Material myMaterial;

    //色が変わる時間間隔
    protected float intervalTime = 2.5f;

    //経過時間
    protected float time = 0f;


    // Start is called before the first frame update
    void Start()
    {
        //オブジェクトにアタッチしているMaterialを取得
        myMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        //時間計測
        time += Time.deltaTime;

        if (time > intervalTime)
        {
            changePlayerColor();

            //経過時間をリセット
            time = 0f;
        }
    }


    //PlayerまたはStageの色を変える
    void changePlayerColor()
    {
        //変化させたい色の候補
        Color[] colors = new Color[] { Color.white, Color.black };

        //色をランダムに取得
        Color color = colors[Random.Range(0, colors.Length)];

        //取得した色に設定
        myMaterial.color = color;
    }
}
