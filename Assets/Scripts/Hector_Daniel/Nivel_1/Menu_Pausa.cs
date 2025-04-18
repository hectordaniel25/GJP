using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Pausa : MonoBehaviour
{
    [SerializeField] private GameObject botonpausa;/*se inicializa el boton de pausa del juego*/

    [SerializeField] private GameObject menupausa;/*se inicializa el boton de reanudar el juego*/

    public AudioSource audiosource;

    public void Pausa()
    {
        Time.timeScale = 0f;/*detiene el tiempo del juego*/
        botonpausa.SetActive(false);/*oculta el boton de pausa*/
        menupausa.SetActive(true);/*activa el menu de pausa*/
        audiosource.Pause();//Pausa la musica de fondo
    }

    public void Continuar()
    {
        Time.timeScale = 1;/*reanuda el tiempo del juego*/
        botonpausa.SetActive(true);/*activa el boton de pausa*/
        menupausa.SetActive(false);/*oculta em menu de pausa*/
        audiosource.Play();//Reanuda la musica de fondo
    }
}
