using UnityEngine;

public class SistemaComprobación : MonoBehaviour
{
    public SistemaCambios sistemaCambios;
    public Cliente cliente;

    int valorSombrero;
    int valorPlayera;
    int valorPantalon;
    int valorZapato;
    GameObject sombrero;
    GameObject playera;
    GameObject pantalon;
    GameObject zapato;

    public int valorTotal;
    public int valorComparar;

    public SceneChanger sceneChanger;

    public void Submit()
    {
        SumaVestimenta();
        Comprobar();
        cliente.PrepareClient();
    }
    public void Comprobar()
    {
        if (valorComparar == valorTotal)
        {
            Debug.Log("Yay");
        }
        else
        {
            sceneChanger.Gameover();
        }
    }

    public void SumaVestimenta()
    {
        AsignarPrendas();
        valorTotal = valorSombrero + valorPantalon + valorPlayera + valorZapato;
    }

    public void AsignarPrendas()
    {
        valorSombrero = sistemaCambios.sombreroActual.GetComponent<Vestimenta>().valorVestimenta;
        valorPlayera = sistemaCambios.playeraActual.GetComponent<Vestimenta>().valorVestimenta;
        valorPantalon = sistemaCambios.pantalonActual.GetComponent<Vestimenta>().valorVestimenta;
        valorZapato = sistemaCambios.zapatoActual.GetComponent<Vestimenta>().valorVestimenta;
    }

}
