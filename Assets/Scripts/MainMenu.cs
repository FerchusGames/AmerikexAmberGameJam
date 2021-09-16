using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public SceneFader sceneFader;
    public void LevelSelect()
    {
        sceneFader.FadeTo(("LevelSelect"));
    }

    public void Gallery()
    {
        sceneFader.FadeTo(("Gallery"));
    }
    public void Exit()
    {
        sceneFader.FadeApplicationQuit();
    }
}
