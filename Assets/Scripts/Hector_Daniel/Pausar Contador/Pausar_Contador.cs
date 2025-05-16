using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausar_Contador : MonoBehaviour
{
    [SerializeField] private GameObject botonpausa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Pausarjuego", 2f);
    }

    void Pausarjuego()
    {
        Time.timeScale = 0f;
        botonpausa.SetActive(true);
    }
}
