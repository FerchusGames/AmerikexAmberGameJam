using UnityEngine;

public class SistemaComprobación : MonoBehaviour
{
    public SistemaCambios sistemaCambios;

    int valorTotal;

    int valorSombrero;
    int valorPlayera;
    int valorPantalon;
    int valorZapato;
    GameObject sombrero;
    GameObject playera;
    GameObject pantalon;
    GameObject zapato;


    public void Comprobar()
    {
    }
    public void SumaVestimenta()
    {
        AsignarPrendas();
        valorTotal = valorSombrero + valorPantalon + valorPlayera + valorZapato;
        Debug.Log(valorTotal);
    }

    public void AsignarPrendas()
    {
        valorSombrero = sistemaCambios.sombreroActual.GetComponent<Vestimenta>().valorVestimenta;
        valorPlayera = sistemaCambios.playeraActual.GetComponent<Vestimenta>().valorVestimenta;
        valorPantalon = sistemaCambios.pantalonActual.GetComponent<Vestimenta>().valorVestimenta;
        valorZapato = sistemaCambios.zapatoActual.GetComponent<Vestimenta>().valorVestimenta;
    }

}
