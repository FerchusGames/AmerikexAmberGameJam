using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioClientes : MonoBehaviour
{
    public GameObject[] clientes;
    public int clienteSeleccionado;

    public void siguienteCliente()
    {
        clientes[clienteSeleccionado].SetActive(false);
        clienteSeleccionado = (clienteSeleccionado + 1) % clientes.Length;
        clientes[clienteSeleccionado].SetActive(true);
    }
}
