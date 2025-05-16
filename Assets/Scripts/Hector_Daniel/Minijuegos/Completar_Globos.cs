using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Completar_Globos : MonoBehaviour
{

    public int PasarNivel;

    public GameObject SigNivel;

    private void Update()
    {
        if(PasarNivel >= 5)
        {
            SigNivel.SetActive(true);
        }
    }

    public void GloboCorrecto()
    {
        Cordura cordura = FindObjectOfType<Cordura>();

        if (cordura != null)
        {
            cordura.Suma(0.05f);/*restara 5 segungus cada que se active*/
            PasarNivel += 1;
        }
    }

    public void GloboIncorrecto()
    {
        Cordura cordura = FindObjectOfType<Cordura>();

        if (cordura != null)
        {
            cordura.Resta(0.05f);/*suma 5 segungus cada que se active*/
        }
    }
}
