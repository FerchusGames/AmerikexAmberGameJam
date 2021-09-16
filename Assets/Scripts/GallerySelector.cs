using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GallerySelector : MonoBehaviour
{
    public GameObject[] galleryButtons;
    public GameObject[] galleryImages;

    public void Select(int galleryLevel)
    {
        galleryImages[galleryLevel].gameObject.SetActive(true);
    }

    public void HideImage(int currentImage)
    {
        galleryImages[currentImage].gameObject.SetActive(false);
    }

    private void Start()
    {
        int levelCompleted = PlayerPrefs.GetInt("levelCompleted", 0);

        for (int i = 0; i < galleryButtons.Length; i++)
        {
            if (i + 1 > levelCompleted)
                galleryButtons[i].gameObject.SetActive(false);
        }
    }
}
