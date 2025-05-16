using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L_Globos : MonoBehaviour
{
    public List<int> Buenos; 
    private HashSet<int> Punto = new HashSet<int>();
    //private int cordura = 0;
    public GameObject SigNivel;
    


    public void Tronar (int tronado)
    {
        if (Buenos.Contains(tronado))
        {
            if (!Punto.Contains(tronado))
            {
                Punto.Add(tronado);

                if (Punto.Count == Buenos.Count)
                {
                    SigNivel.SetActive(true);
                    Debug.Log("gano");//Activa boton
                }
            }
        }else
        {
            Cordura cordura = FindObjectOfType<Cordura>();
            //cordura++;
            if (cordura != null)
            {
                cordura.Resta(0.05f);/*suma 5 segungus cada que se active*/
            }
            //Debug.Log(" ({indice}) - Cordura");
        }
    }
}
