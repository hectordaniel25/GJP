using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragmentos : MonoBehaviour
{
    public GameObject canvasToActivate;
    public GameObject FinalMalo;

    void Start()
    {
        canvasToActivate.SetActive(false);
        FinalMalo.SetActive(false);
    }

    void Update()
    {
        Cordura cordura = FindObjectOfType<Cordura>();

        if (Espejo1.locked && Espejo2.locked && Espejo3.locked && Espejo4.locked && Espejo5.locked && Espejo6.locked)
        {
            if (cordura.GradoCordura >= 0.5)
            {
                canvasToActivate.SetActive(false);
                FinalMalo.SetActive(true);

            }else if(cordura.GradoCordura <= 0.5)
            {
                canvasToActivate.SetActive(true);
                FinalMalo.SetActive(false);
            }
        }
    }
}