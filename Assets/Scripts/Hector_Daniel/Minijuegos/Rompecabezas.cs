using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class Rompecabezas : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler

{
    public GameObject Pieza;
    //El angulo en que deveria de aparecer rotado
    public float angulo;
    //cantidad de grados que rotara al presionar el boton
    public float boton;
    //Crea una variable que puede modificar el valor de rotacion
    Quaternion rotacion = new Quaternion();

    //private bool mouseEncima = false;

    // Update is called once per frame
    void Update()
    {
        Rotar();

        //Si el valor del angulo llega a sobrepasar los 360 grados el valor se reestablece a 0
        if (angulo == 360)
        {
            angulo = 0;
        }

        if (angulo <= 0)
        {
            angulo = 360;
        }
    }

    void Rotar()
    {
        //Muestra la pieza rotada al iniciarel juego
        rotacion.eulerAngles = new Vector3(0, 0, angulo);

        //Actualiza el valor de rotacion
        Pieza.transform.localRotation = rotacion;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //mouseEncima = true;
        //Debug.Log("Mouse sobre la imagen UI");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //mouseEncima = false;
       //Debug.Log("Mouse fuera de la imagen UI");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //Debug.Log("Imagen UI clickeada");
        // Aquí puedes ejecutar la acción deseada
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            angulo += boton;
            //Debug.Log("Izquierda");
        }

        if (eventData.button == PointerEventData.InputButton.Right)
        {
            angulo -= boton;
            //Debug.Log("Derecha");
        }
    }
}
