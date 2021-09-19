using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    public GameObject[] backgrounds;
    public int backgroundSeleccionado;

    public void SiguienteBackground()
    {
        backgrounds[backgroundSeleccionado].SetActive(false);
        backgroundSeleccionado = (backgroundSeleccionado + 1) % backgrounds.Length;
        backgrounds[backgroundSeleccionado].SetActive(true);
        GuardarBackground();
    }

    public void AnteriorBackground()
    {
        backgrounds[backgroundSeleccionado].SetActive(false);
        backgroundSeleccionado--;
        if (backgroundSeleccionado < 0)
        {
            backgroundSeleccionado += backgrounds.Length;
        }
        backgrounds[backgroundSeleccionado].SetActive(true);
        GuardarBackground();
    }

    private void Start()
    {
        backgroundSeleccionado = 0;
        if (PlayerPrefs.HasKey("Background"))
        {
            backgroundSeleccionado = PlayerPrefs.GetInt("Background");
            backgrounds[backgroundSeleccionado].SetActive(true);
        } else
        {
            PlayerPrefs.SetInt("Background", backgroundSeleccionado);
            backgrounds[backgroundSeleccionado].SetActive(true);
        }
    }

    public void GuardarBackground()
    {
        PlayerPrefs.SetInt("Background", backgroundSeleccionado);
    }


}
