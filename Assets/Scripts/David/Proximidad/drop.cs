using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    [SerializeField]
    private Transform imgPlace; // La única posición correcta para esta imagen
    private Vector2 PosIni; // Posicion inicial del objeto a mover
    private Vector2 mouseP; // Posicion inicial del mouse
    private float deltaX, deltaY; // Coordenadas X,Y
    public bool locked = false; // Bloqueo para esta imagen individual
    public AudioClip acertar;
    public AudioClip fallar;
    private AudioSource audioPlayer;
    public GameObject Button;
    private static int point = 0; // Se comparte entre todas las imágenes
    public AudioClip proximidad;
    private AudioSource proximidadaudio;

    void Start()
    {
        PosIni = transform.position; // Obtener coordenadas
        audioPlayer = GetComponent<AudioSource>();
        Button.SetActive(false);
        //priximidad
        proximidadaudio = gameObject.AddComponent<AudioSource>();
        proximidadaudio.clip = proximidad;
        proximidadaudio.loop = true;
        proximidadaudio.playOnAwake = false;
        proximidadaudio.spatialBlend = 0f; // Sonido 2D
    }

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


    private void OnMouseDown() // Click
    {
        if (!locked) // Solo mover si esta imagen no está bloqueada
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
            Debug.Log("¡Click detectado!");
        }
    }


    private void OnMouseDrag() // Arrastra objeto
    {
        if (!locked) // Solo arrastrar si esta imagen no está bloqueada
        {
            mouseP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mouseP.x - deltaX, mouseP.y - deltaY);
        }
    }

    private void OnMouseUp() // Al soltar
    {
        // Verificar si la imagen está cerca de su posición correcta (imgPlace)
        if (Mathf.Abs(transform.position.x - imgPlace.position.x) <= 0.9f && Mathf.Abs(transform.position.y - imgPlace.position.y) <= 0.3f)
        {
            transform.position = new Vector2(imgPlace.position.x, imgPlace.position.y); // Fijar en la posición correcta
            locked = true; // Bloquear esta imagen
            audioPlayer.clip = acertar;
            audioPlayer.Play();
            point++;
            Debug.Log("Points: " + point); // Mostrar los puntos en la consola
        }
        else
        {
            transform.position = new Vector2(PosIni.x, PosIni.y); // Volver a la posición inicial si no coincide
            audioPlayer.clip = fallar;
            audioPlayer.Play();
        }

        // Mostrar botón si todas las imágenes están en sus posiciones correctas
        if (point == 1) // Suponiendo que hay 3 imágenes en total
        {
            Button.SetActive(true);
        }
    }
}