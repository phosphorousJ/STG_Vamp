using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FLMStory0_5 : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text textEnemy;
    [SerializeField] UnityEngine.UI.Text textPlayer;


    IEnumerator Start()
    {
        yield return new WaitForSeconds(1.5f);

        textPlayer.text = "魔力を……消耗しすぎたか……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "クッ……これは……想定外……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "……なっ！？\n(羽！？)";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "分身がやられたのは久しぶりですよ…";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "分身……\n(手応えがないわけだ…じゃあ本体は)";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "そう身構えなくていいですよ。\n処すのはまたの機会にします……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "………";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "あなたにとって有益な情報をひとつ……\nここからずっと真西へ向かってください。\nいずれディユージュに辿り着くでしょう……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "真西……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "あなたの覚悟は伝わりました。\n彼らに滅せられないことを祈っています…\nあなたを処すのは私ですから……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "………";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("TalkScene0_6");
    }
}
