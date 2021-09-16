using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFader : MonoBehaviour
{
    public Image img;

    private void Start()
    {
        StartCoroutine(FadeIn());
    }

    public void FadeTo(string scene)
    {
        StartCoroutine(FadeOut(scene));
    }

    public void FadeApplicationQuit()
    {
        StartCoroutine(FadeQuit());
    }

    IEnumerator FadeIn()
    {
        float t = 1f;

        while (t > 0)
        {
            t -= Time.deltaTime / 3f;
            img.color = new Color(0f, 0f, 0f, t);
            yield return 0;
        }
    }

    IEnumerator FadeOut(string scene)
    {
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime / 3f;
            img.color = new Color(0f, 0f, 0f, t);
            yield return 0;
        }

        SceneManager.LoadScene(scene);
    }

    IEnumerator FadeQuit()
    {
        float t = 0f;

        while (t < 1f)
        {
            t += Time.deltaTime / 3f;
            img.color = new Color(0f, 0f, 0f, t);
            yield return 0;
        }
        Application.Quit();
        Debug.Log("Application quit");
    }
}
