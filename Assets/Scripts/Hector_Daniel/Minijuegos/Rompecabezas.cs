using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rompecabezas : MonoBehaviour
{
    //El angulo en que deveria de aparecer rotado
    public float angulo;
    //cantidad de grados que rotara al presionar el boton
    public float boton;
    //Crea una variable que puede modificar el valor de rotacion
    Quaternion rotacion = new Quaternion();

    // Update is called once per frame
    void Update()
    {
        Rotar();

        //Si el valor del angulo llega a sobrepasar los 360 grados el valor se reestablece a 0
        if(angulo == 360)
        {
            angulo = 0;
        }
    }

    void Rotar()
    {
        //Muestra la pieza rotada al iniciarel juego
        rotacion.eulerAngles = new Vector3(0, 0, angulo);
        //Actualiza el valor de rotacion
        transform.localRotation = rotacion;
    }

    public void Girar()
    {
        //Suma lo grados de rotacion al pulsar el boton
        angulo += boton;
    }
}
