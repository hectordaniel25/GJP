using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orden_rompecabezas : MonoBehaviour
{

    public Transform Pz1;
    public Transform Pz2;
    public Transform Pz3;
    public Transform Pz4;

    private float rotacionZ1;
    private float rotacionZ2;
    private float rotacionZ3;
    private float rotacionZ4;

    public GameObject Llave;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Comparar();
        //Obtine el valor del angulo de rotacion del objeto
        Vector3 RotacionObjeto1 = Pz1.eulerAngles;

        //Debug.Log("Angulo de Objeto 1: " + RotacionObjeto1.z);

        //Guarda el valor del angulo dentro de la variable rotacionZ1
        rotacionZ1 = RotacionObjeto1.z;
        

        Vector3 RotacionObjeto2 = Pz2.eulerAngles;
        //Debug.Log("Angulo de Objeto 2: " + RotacionObjeto2.z);

        rotacionZ2 = RotacionObjeto2.z;

        Vector3 RotacionObjeto3 = Pz3.eulerAngles;
        //Debug.Log("Angulo de Objeto 1: " + RotacionObjeto3.z);

        rotacionZ3 = RotacionObjeto3.z;

        Vector3 RotacionObjeto4 = Pz4.eulerAngles;
        //Debug.Log("Angulo de Objeto 2: " + RotacionObjeto4.z);

        rotacionZ4 = RotacionObjeto4.z;
    }

    void Comparar()
    {
        //Compara la posicion de cada objeto para comprobar si el jugador obtiene la llave
        if (Mathf.Approximately(rotacionZ1, 90) && Mathf.Approximately(rotacionZ2, 270) && Mathf.Approximately(rotacionZ3, 270) && Mathf.Approximately(rotacionZ4, 90))
        {
            Debug.Log("obtivista la llave 1");
            Llave.SetActive(true);
        }
        else //Compara la posicion de cada objeto para comprobar si el jugador abre la puerta
        if (Mathf.Approximately(rotacionZ1, 50) && Mathf.Approximately(rotacionZ2, 50) && Mathf.Approximately(rotacionZ3, 50) && Mathf.Approximately(rotacionZ4, 50))
        {
            Debug.Log("abriste la puerta 1");
        }
        else//mientras no consiga colocar el orden correcto permanecera cerrado
        {
            Debug.Log("Bloqueado");
            Llave.SetActive(false);
        }
    }
}
