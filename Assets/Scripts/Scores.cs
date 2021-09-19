using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    public int current_score;
    public int high_score;
    public int delete_score_cheat;

    public Text current_score_text;
    public Text high_score_text;
    // Start is called before the first frame update
    void Start()
    {
        current_score = 0;

        if (PlayerPrefs.HasKey("HiScore"))
        {
            high_score = PlayerPrefs.GetInt("HiScore");
            high_score_text.text = high_score.ToString();
        } 
        else
        {
            PlayerPrefs.SetInt("HiScore", 0);
            high_score_text.text = high_score.ToString();
        }
    }

    public void AddScore()
    {
        current_score += 1;
        current_score_text.text = current_score.ToString();

        if (current_score > high_score)
        {
            high_score_text.text = current_score.ToString();
        } 
    }

    public void SubmitScores()
    {
        if (current_score > high_score)
        {
            PlayerPrefs.SetInt("HiScore", current_score);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
            delete_score_cheat++;

        if (delete_score_cheat == 10)
            PlayerPrefs.DeleteKey("HiScore");
    }
}
