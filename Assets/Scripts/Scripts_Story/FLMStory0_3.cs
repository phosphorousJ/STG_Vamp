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

        textEnemy.text = "あいうえお";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "あいうえお";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "かきくけこ";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textPlayer.text = "かきくけこ";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene("GameStartScene0_1_1");
    }
}
