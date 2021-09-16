using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameButtons : MonoBehaviour
{
    public SceneFader sceneFader;
    public void Menu()
    {
        sceneFader.FadeTo(("Menu"));
    }
}
