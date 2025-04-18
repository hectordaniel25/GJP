using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sumar_Tiempo : MonoBehaviour
{

    public void Restar()
    {
        Cordura cordura = FindObjectOfType<Cordura>();/*Busca el objeto en donde se encuatra alojado el codigo de Cordura*/

        if (cordura != null)
        {
            cordura.Suma(0.05f);/*restara 5 segungus cada que se active*/
        }
    }

}
