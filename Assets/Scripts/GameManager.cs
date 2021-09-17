using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int levelToUnlock = 2;
    public int completedTitleToDisplay = 1;

    public bool gameDone;
    public float timer;
    public float current_time;
    public Text timer_text;
    public Image timer_image;

    public void SetTimer()
    {
        current_time = timer;
    }

    public void AddToTimer(float _time_to_add)
    {
        current_time += _time_to_add; 
    }

    public void SubstractToTimer(float _time_to_substract)
    {
        current_time -= Time.deltaTime * 1.0f;
        timer_text.text = current_time.ToString("F2").Replace(".", ":");
        timer_image.fillAmount =  current_time / (timer);
    }
    public void WinLevel()
    {
        Debug.Log("Level Won");
        PlayerPrefs.SetInt("levelReached", levelToUnlock);
        PlayerPrefs.SetInt("levelCompleted", completedTitleToDisplay);
    }

    public void Start()
    {
        gameDone = false;
        SetTimer();
    }

    public void Update()
    {
        if (!gameDone)
            SubstractToTimer(0.0f);
        if (current_time <= 0)
            gameDone = true;
    }
}
