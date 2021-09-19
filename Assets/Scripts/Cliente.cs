using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cliente : MonoBehaviour
{
    public SistemaComprobación comprobacion;
    public List<int> clientes = new List<int>();
    public int random_number;
    public int previous_random_number;
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
