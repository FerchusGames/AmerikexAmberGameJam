using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public string gameoverScene;
    public GameObject fadeout;
    void Start()
    {
        gameoverScene = "GameOver"; //Default Gameover scene
    }
    public void Gameover()// Changes to Gameover scene when it's called
    {
        StartCoroutine(FadeOut(gameoverScene));
    }

    public void ChangeLevel(string levelToLoad) //Changes scene to whatever scene is passed into the function
    {
        StartCoroutine( FadeOut(levelToLoad));
    }

    public IEnumerator FadeOut(string _levelName)
    {
        fadeout.GetComponent<Animator>().Play("Base Layer.Fade Out", 0, 0.3f);

        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(_levelName);
    }

}