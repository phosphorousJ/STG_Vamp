using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackWall0ColorController : BackWallColorBaseController
{
    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        if (time > intervalTime)
        {
            changeWallColor();
            //経過時間をリセット
            time = 0f;
        }
    }


    //BackWallの色を変える
    void changeWallColor()
    {
        //変化させたい色の候補
        Color[] colors = new Color[] { Color.black, Color.blue, Color.red, Color.green };

        //色をランダムに取得
        Color color = colors[Random.Range(0, colors.Length)];

        //取得した色に設定
        myMaterial.color = color;
    }
}
