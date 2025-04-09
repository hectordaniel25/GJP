using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cambiar_pantalla : MonoBehaviour
{
    public void CambiardeNivel(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}
