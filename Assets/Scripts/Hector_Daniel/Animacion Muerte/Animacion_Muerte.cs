using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Animacion_Muerte : MonoBehaviour
{
    public Animator Muerte;
    public string AnimacionAReproducir;
    private AudioSource EfectoSmuerte;
    public AudioClip SonidoMuerte;
    public GameObject BMenu;

    private void Start()
    {
        Muerte.enabled = false;
        EfectoSmuerte = GetComponent<AudioSource>();
    }

    private void Update()
    {
        Cordura cordura = FindObjectOfType<Cordura>();

        if (cordura.GradoCordura >= 1)
        {
            BMenu.SetActive(false);
            Muerte.enabled = true;
            Muerte.Play(AnimacionAReproducir);
            Invoke("Sonido", 2f);
            Invoke("CambiarEscena", 5f);
        }
        
    }

    void CambiarEscena()
    {
        SceneManager.LoadScene("Muerte");
    }

    void Sonido()
    {
        EfectoSmuerte.PlayOneShot(SonidoMuerte);
    }
}
