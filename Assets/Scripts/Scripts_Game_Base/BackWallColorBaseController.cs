using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackWallColorBaseController : MonoBehaviour
{
    //Materialを入れる
    protected Material myMaterial;

    //色が変わる時間間隔
    protected float intervalTime = 10f;

    //経過時間
    protected float time = 0f;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        //オブジェクトにアタッチしているMaterialを取得
        myMaterial = GetComponent<Renderer>().material;
    }


    // Update is called once per frame
    protected virtual void Update()
    {
        //時間計測
        time += Time.deltaTime;
    }
}
