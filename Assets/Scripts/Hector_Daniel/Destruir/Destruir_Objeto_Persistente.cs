using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir_Objeto_Persistente : MonoBehaviour
{
    // Cada que se inicia el codigo ejecuta la orden
    void Start()
    {
        Cordura.DestruirObjeto();/*Destruye el objeto persistente que es el contador de la cordura en el menu principal*/
    }


}
