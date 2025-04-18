using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Se que esta mal optimizado el juego pero funciona
public class Espejos_Recolectados : MonoBehaviour
{
    //Las variables bool determinaran si el objeto esta activo o no en unity
    public bool Espejo1;
    public bool Espejo2;
    public bool Espejo3;
    public bool Espejo4;
    public bool Espejo5;

    //Asignamos desde unity que objetos seran los que se activaran o no
    public GameObject E1;
    public GameObject E2;
    public GameObject E3;
    public GameObject E4;
    public GameObject E5;

    //Al codigo Recolectar_Espejos la llamaremos Num
    public Recolectar_Espejos Num;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos que todos los objetos esten en falso para cuando se cargue de nuevo el codigo
        Espejo1 = false;
        Espejo2 = false;
        Espejo3 = false;
        Espejo4 = false;
        Espejo5 = false;

        //Inicializamos que todos los objetos comienzen desactivados
        E1.SetActive(false);
        E2.SetActive(false);
        E3.SetActive(false);
        E4.SetActive(false);
        E5.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //Busca el codigo Recolectar_Espejos
        Num = FindObjectOfType<Recolectar_Espejos>();
        //Ejecuta la funcion NumerodeEspejo
        NumerodeEspejo();
        //Ejecuta la funcion CompararEstadoEspejo
        CompararEstadoEspejo();
    }

    //La funcion CompararEstadoEspejo se encarga de comprobar si se activa o no el slot del fragmento del espejo
    void CompararEstadoEspejo()
    {
        
        if(Espejo1 == true)
        {
            E1.SetActive(true);           
        }
        if(Espejo2 == true)
        {
            E2.SetActive(true);
        }
        if (Espejo3 == true)
        {
            E3.SetActive(true);
        }
        if (Espejo4 == true)
        {
            E4.SetActive(true);
        }
        if (Espejo5 == true)
        {
            E5.SetActive(true);
        }
    }

    //La funcion NumerodeEspejo Se encarga de comprobar el numero que registra al presionar el boton y cambia el estado de la variable bool
    public void NumerodeEspejo()
    {
        if(Num != null)
        {
            if(Num.Code == 1)
            {
                Espejo1 = true;
                //Debug.Log(Num.Code);

            }
            if(Num.Code == 2)
            {
                Espejo2 = true;
                //Debug.Log(Num.Code);
            }
            if (Num.Code == 3)
            {
                Espejo3 = true;
                //Debug.Log(Num.Code);

            }
            if (Num.Code == 4)
            {
                Espejo4 = true;
                //Debug.Log(Num.Code);
            }
            if (Num.Code == 5)
            {
                Espejo5 = true;
                //Debug.Log(Num.Code);
            }
        }
    }
}
