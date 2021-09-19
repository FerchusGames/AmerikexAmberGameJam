using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cliente : MonoBehaviour
{
    public SistemaComprobación comprobacion;
    public List<int> clientes = new List<int>();
    public Burbujas burbujas;
    public int random_number;
    public int previous_random_number;

    //GameObject leonaVicario = GameObject.Find("BurbujaLeonaVicario");
    //GameObject miguelHidalgo = GameObject.Find("BurbujaMiguelHidalgo");
    //GameObject elSanto = GameObject.Find("BurbujaElSanto");
    //GameObject sorJuana = GameObject.Find("BurbujaSorJuana");
    //GameObject josefaOrtiz = GameObject.Find("BurbujaJosefaOrtiz");
    //GameObject benitoJuarez = GameObject.Find("BurbujaBenitoJuarez");
    //GameObject fridaKahlo = GameObject.Find("BurbujaFridaKahlo");
    //GameObject joseMaria = GameObject.Find("BurbujaJoseMaria");


    // Start is called before the first frame update
    void Start()
    {
        PrepareClient();  
    }


    public void PrepareClient()
    {
        ChooseRandomOutfit();
        DressClient();
    }

    public void DressClient()
    {
        burbujas.OcultarBurbujas();
        burbujas.MostrarTraje();
        //if (comprobacion.valorComparar == 3185) leonaVicario.SetActive(true);
        //else if (comprobacion.valorComparar == 1438) miguelHidalgo.SetActive(true);
        //else if (comprobacion.valorComparar == 7261) elSanto.SetActive(true);
        //else if (comprobacion.valorComparar == 4712) sorJuana.SetActive(true);
        //else if (comprobacion.valorComparar == 2857) josefaOrtiz.SetActive(true);
        //else if (comprobacion.valorComparar == 8523) benitoJuarez.SetActive(true);
        //else if (comprobacion.valorComparar == 5674) fridaKahlo.SetActive(true);
        //else if (comprobacion.valorComparar == 6346) joseMaria.SetActive(true);
    }

    public void ChooseRandomOutfit()
    {
        while (random_number == previous_random_number)
        {
            random_number = Random.Range(1, 8);
        }

        previous_random_number = random_number;
        comprobacion.valorComparar = clientes[random_number];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
