using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    //public Animator TrancisionAnimacion;

    private void Start()
    {
        //TrancisionAnimacion = GetComponentInChildren<Animator>();

    }

    public void CambiardeNivel(string nombre)
    {
        SceneManager.LoadScene(nombre);
        //StartCoroutine(Animacion(nombre));
    }
    
    //public IEnumerator Animacion(string nombre)
    //{
        //TrancisionAnimacion.SetTrigger("IT");
        //yield return new WaitForSeconds(1f);
       // SceneManager.LoadScene(nombre);/*se ejecuta el cambio de pantalla*/
    //}
}
