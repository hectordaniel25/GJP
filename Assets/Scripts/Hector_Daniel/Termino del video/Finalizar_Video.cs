using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finalizar_Video : MonoBehaviour
{
    public Animator Transiciones;

    private void Start()
    {
        Invoke("CambiarEscena", 40f);
        Invoke("FadeOut", 39f);
    }
    void CambiarEscena()
    {
        SceneManager.LoadScene("Nivel_1");
    }

    void FadeOut()
    {
        Transiciones = GetComponentInChildren<Animator>();
        Transiciones.SetTrigger("IniciarTrancision");

    }
}
