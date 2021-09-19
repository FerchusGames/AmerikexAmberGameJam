using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int levelToUnlock = 2;
    public int completedTitleToDisplay = 1;
    public void WinLevel()
    {
        Debug.Log("Level Won");
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        PlayerPrefs.SetInt("levelCompleted", completedTitleToDisplay);
    }

  
}
