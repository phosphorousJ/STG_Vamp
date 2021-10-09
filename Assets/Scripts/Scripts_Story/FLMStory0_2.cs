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

        textEnemy.text = "あいうえお";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return null;

        textEnemy.text = "かきくけこ";
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        yield return new WaitForSeconds(1.5f);

        SceneManager.LoadScene("GameSubScene0_0");
    }
}
