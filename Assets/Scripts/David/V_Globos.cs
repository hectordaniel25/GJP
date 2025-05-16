using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class V_Globos : MonoBehaviour
{
    public int globo;
    public Sprite seleccionada;
    public Sprite normal;
    private bool tronado = false;
    private Button boton;
    private Image imagen;
    private L_Globos lGlobos;

    void Start()
    {
        boton = GetComponent<Button>();
        imagen = GetComponent<Image>();
        lGlobos = FindObjectOfType<L_Globos>();
        boton.onClick.AddListener(ToggleSeleccion);
        imagen.sprite = normal;
    }
    void ToggleSeleccion()
    {
        if (tronado) return;
        tronado = true;
        ActualizarVisual();
        boton.interactable = false;
        if (lGlobos != null)
        {
            lGlobos.Tronar(globo);
        }
    }
    void ActualizarVisual()
    {
        imagen.sprite = seleccionada;
    }
}
