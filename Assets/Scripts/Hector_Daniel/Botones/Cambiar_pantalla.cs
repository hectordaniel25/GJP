using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Este codigo funciona para realizar el cambio de pantallas por medio de un boton*/

public class Cambiar_pantalla : MonoBehaviour
{
    public Animator Transiciones;
    private void Start()
    {
        Transiciones = GetComponentInChildren<Animator>();
    }

    public void CambiardeNivel(string Escena)/*Se da la orden a que pantalla se quiere cambiar*/
    {
        StartCoroutine(RetrasarEjecucion(Escena));
        
    }

    public IEnumerator RetrasarEjecucion(string nombre)
    {

        Transiciones.SetTrigger("IniciarTrancision");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(nombre);/*se ejecuta el cambio de pantalla*/
        
    }
}
