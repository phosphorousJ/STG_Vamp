using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSubController : MonoBehaviour
{
    #region//インスペクター設定
    [SerializeField] [Header("縦移動速度")] float verticalSpeed;
    [SerializeField] [Header("横移動速度")] float horizontalSpeed;
    #endregion

    #region//プライベート設定
    //縦移動できる範囲
    private float moveVerticalRange = 1.43f;

    //横移動できる範囲
    private float moveHorizontalRange = 1.43f;
    #endregion

    //キーと速度のセット
    Dictionary<string, bool> move = new Dictionary<string, bool>
    {
        {"up", false},
        {"down", false},
        {"right", false},
        {"left", false},
    };


    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //矢印キーに応じた移動
        move["up"] = Input.GetKey(KeyCode.UpArrow);
        move["down"] = Input.GetKey(KeyCode.DownArrow);
        move["right"] = Input.GetKey(KeyCode.RightArrow);
        move["left"] = Input.GetKey(KeyCode.LeftArrow);
    }


    void FixedUpdate()
    {
        //Playerを移動させる
        if (move["up"] && this.transform.position.y < this.moveVerticalRange)
        {
            transform.Translate(0f, 0f, verticalSpeed);
        }
        if (move["down"] && -this.moveVerticalRange < this.transform.position.y)
        {
            transform.Translate(0f, 0f, -verticalSpeed);
        }
        if (move["right"] && this.transform.position.x < this.moveHorizontalRange)
        {
            transform.Translate(horizontalSpeed, 0f, 0f);
        }
        if (move["left"] && -this.moveHorizontalRange < this.transform.position.x)
        {
            transform.Translate(-horizontalSpeed, 0f, 0f);
        }
    }


    //被弾処理
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "E_FLM_SkillAttack0Tag")
        {
            SceneManager.LoadScene("GameOverSubScene0_0");
            Debug.Log("大鎌に衝突");
        }

        if (other.gameObject.tag == "E_FLM_SkillAttack1Tag")
        {
            SceneManager.LoadScene("GameOverSubScene0_1");
            Debug.Log("羽に衝突");
        }
    }
}
