using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FLMStory0_4 : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text textEnemy;
    [SerializeField] UnityEngine.UI.Text textPlayer;


    IEnumerator Start()
    {
        yield return new WaitForSeconds(1.5f);

        textPlayer.text = "はぁ…はぁ…";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "全て、避けた……！？\n(解錠せずにどうやって……\n いや、ありえない……対処できるわけがない！！\n 既に解錠していたのか？……ならば、いつだ！？)";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "(私が魔力の違和感に気づき始めたときか？\n 彼女が私の魔力変化に適応したときか？\n ……仮にそうだとしても、\n 解錠による空間変化に気づかないはずが…)";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "……まさか………！？";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "(なんてタフな死神なんだ…\n 私の槍を数発くらってもまだ耐えるなんて…\n まるで手応えを感じられない……)";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("GameScene0_0");
    }
}
