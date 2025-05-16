using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prox_Espejo : MonoBehaviour
{
    public AudioClip proximidad;
    private AudioSource proximidadaudio;
    // Start is called before the first frame update
    void Start()
    {
        proximidadaudio = gameObject.AddComponent<AudioSource>();
        proximidadaudio.clip = proximidad;
        proximidadaudio.loop = true;
        proximidadaudio.playOnAwake = false;
        proximidadaudio.spatialBlend = 0f; // Sonido 2D
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position); // posición del objeto en pantalla
        float distance = Vector2.Distance(Input.mousePosition, screenPos);

        if (distance <= 400f)
        {
            float volume = 1f - (distance / 400f); // restar volumen
            proximidadaudio.volume = volume;

            if (!proximidadaudio.isPlaying)
                proximidadaudio.Play();
        }
        else
        {
            if (proximidadaudio.isPlaying)
                proximidadaudio.Stop();
        }
    }
}
