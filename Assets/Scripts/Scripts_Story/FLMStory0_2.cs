using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FLMStory0_2 : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text textEnemy;


    IEnumerator Start()
    {
        yield return new WaitForSeconds(1.5f);

        textEnemy.text = "思った以上に厄介ですね……\n“夜の王”と呼ばれている種族だけのことはある。\n(それに……妙な魔力だ……\n 流動的というか…不安定というか……)";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "少し本気を出しますか……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("GameSubScene0_0");
    }
}
