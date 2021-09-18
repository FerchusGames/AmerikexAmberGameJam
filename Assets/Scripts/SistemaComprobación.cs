using UnityEngine;

public class SistemaComprobación : MonoBehaviour
{
    public Vestimenta vestimenta;
    public SistemaCambios sistemaCambios;

    int valorSombrero;
    int valorPlayera;
    int valorPantalon;
    int valorZapato;
    GameObject sombrero;
    GameObject playera;
    GameObject pantalon;
    GameObject zapato;

    public void SumaVestimenta()
    {
        sombrero = sistemaCambios.sombreroActual;
        
    }
}
