using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*Este codigo funciona para realizar el cambio de pantallas por medio de un boton*/

public class Cambiar_pantalla : MonoBehaviour
{
    public void CambiardeNivel(string nombre)/*Se da la orden a que pantalla se quiere cambiar*/
    {
        SceneManager.LoadScene(nombre);/*se ejecuta el cambio de pantalla*/
    }
}
