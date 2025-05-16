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
    public GameObject Puerta;


    // Start is called before the first frame update
    void Start()
    {
        
        Llave.SetActive(false);
        Puerta.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        
        Comparar();
        //Obtine el valor del angulo de rotacion del objeto
        Vector3 RotacionObjeto1 = Pz1.eulerAngles;


        //Guarda el valor del angulo dentro de la variable rotacionZ1
        rotacionZ1 = RotacionObjeto1.z;
        

        Vector3 RotacionObjeto2 = Pz2.eulerAngles;

        rotacionZ2 = RotacionObjeto2.z;

        Vector3 RotacionObjeto3 = Pz3.eulerAngles;

        rotacionZ3 = RotacionObjeto3.z;

        Vector3 RotacionObjeto4 = Pz4.eulerAngles;

        rotacionZ4 = RotacionObjeto4.z;
    }

    void Comparar()
    {
        //Compara la posicion de cada objeto para comprobar si el jugador obtiene la llave
        if (Mathf.Approximately(rotacionZ1, 90) && Mathf.Approximately(rotacionZ2, 270) && Mathf.Approximately(rotacionZ3, 270) && Mathf.Approximately(rotacionZ4, 90))
        {
            if (Llave != null)
            {
                //Debug.Log("obtivista la llave 1");
                Llave.SetActive(true);
            }
            
        }
        else //Compara la posicion de cada objeto para comprobar si el jugador abre la puerta
        if (Mathf.Approximately(rotacionZ1, 180) && Mathf.Approximately(rotacionZ2, 180) && Mathf.Approximately(rotacionZ3, 180) && Mathf.Approximately(rotacionZ4, 180))
        {
            //Debug.Log("abriste la puerta 1");
            Puerta.SetActive(true);
        }
        else//mientras no consiga colocar el orden correcto permanecera cerrado
        {
            //Debug.Log("Bloqueado");
            if (Llave != null)
            {
                //Debug.Log("obtivista la llave 1");
                Llave.SetActive(false);
            }
            
            Puerta.SetActive(false);
        }
    }

    public void destruir()
    {
        Destroy(Llave);
    }
}
