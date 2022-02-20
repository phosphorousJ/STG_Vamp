using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FLMStory0_3 : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text textEnemy;
    [SerializeField] UnityEngine.UI.Text textPlayer;


    IEnumerator Start()
    {
        yield return new WaitForSeconds(1.5f);

        textEnemy.text = "やはりこの魔力……天族の……！\n(なぜ放出できる？過去に吸収・蓄積したものか？\n 仮にそうなら、既に枯渇していてもおかしくない…\n なのに……なぜ……)";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "(最初は断続的だった……\n だが、徐々に放出間隔が短縮。\n いや、それどころか…\n 吸収量以上に放出している……！)";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "(単に私が放出した魔力を吸収し、\n 自身の魔力に上乗せしている \n わけではないのか……？)";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "試してみますか……\n…………………\n…………………";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "ふむ、“上書き”…の方か……\n(吸収した魔力を瞬時に分析し、生成……\n 赤、青、緑…三色をこれほどまで\n 器用かつ正確に…しかも術陣なしで……！)";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "魔力操作にかなり長けているようですね……\nさぞ、“己心(こしん)”も強力なのでしょう……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "己心……？";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "知らないのですか？\n戦争で幾多もご覧になったでしょう？\nまぁ、名称の違いもあるらしいですが……\n(見せてもらいますよ。あなたの己心……)！";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "……！？\n(この空気……あの時と同じ……)";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("GameStartScene0_1_1");
    }
}
