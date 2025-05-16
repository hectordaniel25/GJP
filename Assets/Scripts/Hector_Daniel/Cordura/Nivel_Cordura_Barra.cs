using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nivel_Cordura_Barra : MonoBehaviour
{
    public Image BarraCordura;
    public Cordura cordura; 

    // Update is called once per frame
    void Update()
    {
        cordura = FindObjectOfType<Cordura>();
        if( cordura != null)
        {
            //BarraCordura.fillAmount = cordura.GradoCordura;
        }
    }
}
