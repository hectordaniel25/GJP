using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animaciones : MonoBehaviour
{
    [Tooltip("Lista de Raw Images que se mostrarán en secuencia.")]
    public RawImage[] imagenesAnimacion;

    [Tooltip("Tiempo en segundos que cada imagen se mostrará.")]
    public float tiempoPorImagen = 8f;

    [Tooltip("Duración de la transición de opacidad en segundos.")]
    public float duracionTransicion = 0.5f;

    private int indiceImagenActual = 0;
    private float tiempoTranscurrido = 0f;
    private bool animacionEnProgreso = false;
    private float tiempoTransicionActual = 0f;
    private RawImage imagenMostrandose;
    private RawImage imagenSiguiente;

    void Start()
    {

        foreach (var imagen in imagenesAnimacion)
        {
            if (imagen != null)
            {
                imagen.gameObject.SetActive(false);
                SetAlpha(imagen, 0f);
            }
        }


        if (imagenesAnimacion.Length > 0 && imagenesAnimacion[0] != null)
        {
            imagenesAnimacion[0].gameObject.SetActive(true);
            SetAlpha(imagenesAnimacion[0], 1f);
            imagenMostrandose = imagenesAnimacion[0];
            animacionEnProgreso = true;
        }
        else
        {
            Debug.LogWarning("No hay Raw Images");
            enabled = false;
        }
    }

    void Update()
    {
        if (animacionEnProgreso)
        {
            tiempoTranscurrido += Time.deltaTime;

            if (tiempoTranscurrido >= tiempoPorImagen)
            {

                if (indiceImagenActual < imagenesAnimacion.Length - 1)
                {
                    indiceImagenActual++;
                    imagenSiguiente = imagenesAnimacion[indiceImagenActual];
                    imagenSiguiente.gameObject.SetActive(true);
                    SetAlpha(imagenSiguiente, 0f);
                    tiempoTransicionActual = 0f;
                    tiempoTranscurrido = 0f;
                }
                else
                {

                    animacionEnProgreso = false;
                    Debug.Log("Animación en Canvas completada");
                }
            }


            if (imagenMostrandose != null && imagenSiguiente != null)
            {
                tiempoTransicionActual += Time.deltaTime;
                float progresoTransicion = Mathf.Clamp01(tiempoTransicionActual / duracionTransicion);

                SetAlpha(imagenMostrandose, 1f - progresoTransicion);
                SetAlpha(imagenSiguiente, progresoTransicion);

                if (progresoTransicion >= 1f)
                {
                    imagenMostrandose.gameObject.SetActive(false);
                    imagenMostrandose = imagenSiguiente;
                    imagenSiguiente = null;
                }
            }
        }
    }


    void SetAlpha(RawImage image, float alpha)
    {
        if (image != null && image.color != null)
        {
            Color color = image.color;
            color.a = alpha;
            image.color = color;
        }
    }
}