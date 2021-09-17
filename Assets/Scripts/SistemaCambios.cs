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
        sombreroSeleccionado = (sombreroSeleccionado + 1) % sombreros.Length;
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
        playeraSeleccionada = (playeraSeleccionada + 1) % playeras.Length;
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

    public void SiguientePantalon()
    {
        pantalones[pantalonSeleccionado].SetActive(false);
        pantalonSeleccionado = (pantalonSeleccionado + 1) % pantalones.Length;
        pantalones[pantalonSeleccionado].SetActive(true);
    }

    public void AnteriorPantalon()
    {

        pantalones[pantalonSeleccionado].SetActive(false);
        pantalonSeleccionado--;
        if (pantalonSeleccionado < 0)
        {
            pantalonSeleccionado += pantalones.Length;
        }
        pantalones[pantalonSeleccionado].SetActive(true);
    }

    public void SiguienteZapato()
    {
        zapatos[zapatoSeleccionado].SetActive(false);
        zapatoSeleccionado = (zapatoSeleccionado + 1) % zapatos.Length;
        zapatos[zapatoSeleccionado].SetActive(true);
    }

    public void AnteriorZapato()
    {

        zapatos[zapatoSeleccionado].SetActive(false);
        zapatoSeleccionado--;
        if (zapatoSeleccionado < 0)
        {
            zapatoSeleccionado += zapatos.Length;
        }
        zapatos[zapatoSeleccionado].SetActive(true);
    }
}