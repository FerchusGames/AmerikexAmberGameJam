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
    }

}
