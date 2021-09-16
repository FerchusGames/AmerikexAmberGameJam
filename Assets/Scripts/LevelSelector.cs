using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour
{
    public SceneFader fader;

    public Button[] levelButtons;

    public GameObject[] completedTitles;
    public GameObject[] percentages;

    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);

        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
                levelButtons[i].gameObject.SetActive(false);
        }

        int levelCompleted = PlayerPrefs.GetInt("levelCompleted", 0);

        for (int i = 0; i < completedTitles.Length; i++)
        {
            if (i + 1 > levelCompleted)
                completedTitles[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < percentages.Length; i++)
        {
            if (i + 1 > levelCompleted)
                percentages[i].gameObject.SetActive(true);
        }
    }

    public void Select (string levelName)
    {
        fader.FadeTo(levelName);
    }
}
