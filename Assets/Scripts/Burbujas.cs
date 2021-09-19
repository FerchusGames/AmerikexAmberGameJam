using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Burbujas : MonoBehaviour
{

    public GameObject[] burbujas;
    public SistemaComprobación comprobacion;

    public void OcultarBurbujas()
    {
        foreach (GameObject obj in burbujas)
        {
            obj.SetActive(false);
        }
    }

    public void MostrarTraje()
    {
        if (comprobacion.valorComparar == 3185) burbujas[0].SetActive(true);
        else if (comprobacion.valorComparar == 1438) burbujas[1].SetActive(true);
        else if (comprobacion.valorComparar == 7261) burbujas[2].SetActive(true);
        else if (comprobacion.valorComparar == 4712) burbujas[3].SetActive(true);
        else if (comprobacion.valorComparar == 2857) burbujas[4].SetActive(true);
        else if (comprobacion.valorComparar == 8523) burbujas[5].SetActive(true);
        else if (comprobacion.valorComparar == 5674) burbujas[6].SetActive(true);
        else if (comprobacion.valorComparar == 6346) burbujas[7].SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
