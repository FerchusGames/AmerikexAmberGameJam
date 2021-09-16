using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SistemaCambios : MonoBehaviour
{
    public GameObject[] sombreros;
    public GameObject[] playeras;
    public GameObject[] pantalones;
    public GameObject[] zapatos;
    public int sombreroSeleccionado = 0;
    public int playeraSeleccionada = 0;
    public int pantalonSeleccionado = 0;
    public int zapatoSeleccionado = 0;

    public void SiguienteSombrero()
    {
        sombreros[sombreroSeleccionado].SetActive(false);
        sombreroSeleccionado = (sombreroSeleccionado++) % sombreros.Length;
        sombreros[sombreroSeleccionado].SetActive(true);
    }

    public void AnteriorSombrero()
    {
        sombreros[sombreroSeleccionado].SetActive(false);
        sombreroSeleccionado--;
        if (sombreroSeleccionado < 0)
        {
            sombreroSeleccionado += sombreros.Length;
        }
        sombreros[sombreroSeleccionado].SetActive(true);
    }

    public void SiguientePlayera()
    {
        playeras[playeraSeleccionada].SetActive(false);
        playeraSeleccionada = (playeraSeleccionada++) % playeras.Length;
        playeras[playeraSeleccionada].SetActive(true);
    }

    public void AnteriorPlayera()
    {
        playeras[playeraSeleccionada].SetActive(false);
        playeraSeleccionada--;
        if (playeraSeleccionada < 0)
        {
            playeraSeleccionada += playeras.Length;
        }
        playeras[playeraSeleccionada].SetActive(true);
    }

    public void SiguientePrenda(GameObject[] prenda, int prendaSeleccionada)
    {

    }

}
