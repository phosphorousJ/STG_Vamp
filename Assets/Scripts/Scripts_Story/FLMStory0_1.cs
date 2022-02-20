using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FLMStory0_1 : MonoBehaviour
{
    [SerializeField] UnityEngine.UI.Text textEnemy;
    [SerializeField] UnityEngine.UI.Text textPlayer;


    IEnumerator Start()
    {
        yield return new WaitForSeconds(3.5f);

        textEnemy.text = "ふむ、まだ生き残りがいたとは…";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "どこへ行くのです？こんな夜中に…\nいや、あなたからすれば活動時間でしたね。";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "復讐でもしに行くのですか？……\n“天界(ディユージュ)”に……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "……！";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "やっと反応した！\nまぁ、気持ちはわかりますが…\nはっきり言って愚行ですよ。";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "嫌というほど思い知ったでしょう？\n彼らとの力の差……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "三・四・五の種族戦争に勝利し、\n天族が三界を制して3000と5年余り。\n停滞どころか、他種族の生き残りを\n滅するのに日々を費やす。\n天使という名には程遠い、殺伐とした種族ですよ……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "あなたも時期に狙われるでしょうが、\n身を潜めれば生き長らえることができる。\nだというのに、自ら命を投げ出しに行…";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "私が何をしようがお前には関係ない。";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "それが関係大ありなんですよ……\nあなたのような種族の生き残りは、\n後世に大きな影響を及ぼす。\nいい意味でも…悪い意味でも……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "危険因子の排除か……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "察しがよろしいですね。\nしかし、我々は違います。";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "……？";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "うんざりなんですよ………\n大量の戦死者を捌くのに手一杯だというのに、\n彼らに滅せられた者たちが問答無用にやってくる……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "やめるよう説得を促しましたが、聞く耳持たず。\n数による武力行使は再戦の引き金となり、\n我々の首を絞めることになる。";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "苦渋の判断の末、長が下したのは……\n「天族より先に処せ」";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "フフッ…奴らと変わらないじゃないか。";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "我々が行えば諸々の処理が省かれますからね……\n加えて、彼らの暴挙を沈静化することもできます。";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "ですので………\nディユージュでいざこざを起こす前に、\n大人しく処されてください……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "……";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("GameScene0_0");
    }
}
