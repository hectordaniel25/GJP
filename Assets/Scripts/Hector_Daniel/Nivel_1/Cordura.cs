using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cordura : MonoBehaviour
{
    /*Se establecen las variables que usara el codigo en donde todas las variables podran verse en unity*/
    public int minutos;
    public float segundos;
    public static Cordura instancia;/*Esta variable estática mantiene una única instancia de la clase Cordura.
                                    Se utiliza para implementar el patrón Singleton, asegurando que solo exista 
                                    un objeto de esta clase en toda la aplicación.*/
    public GameObject Imagen1;
    public GameObject Imagen2;
    public GameObject Imagen3;
    public GameObject Boton;

    private void Awake()
    {
        if(instancia == null)
        {
            instancia = this;/*compara si existe otro objeto con este codico*/
            DontDestroyOnLoad(gameObject);/*Permanece el objeto en el que se encuentre el codigo*/
        }
        else
        {
            Destroy(gameObject);/*Destruye cualquier duplicado del objeto en el que se encuentre este codigo*/
        }
    }

    private void Start()
    {
        
    }

    /*Se realizara la comparacion de los valores del contador para pasar al minuto*/
    private void Update()
    {

        Boton = GameObject.Find("SumaPuntos");/*Busca el boton que restara 5 segundos al contador*/
        segundos += Time.deltaTime;/*Forma nativa para poder generar un contador*/

        if (segundos >= 59) /*Cuando el contador llegue a 59 regresara a 0 y minutos agregara +1*/
        {
            segundos = 0;
            minutos += 1;
        }

        if (segundos >= 5)/*activa la imagen 1 si a transcurrido 5 segundos o mas*/
        {
            Imagen1.SetActive(true);
        }
        else
        {
            Imagen1.SetActive(false);/*desacactiva la imagen 1 si no han transcurrido 5 segundos*/
        }

        if (segundos >= 10)/*activa la imagen 2 si a transcurrido 10 segundos o mas*/
        {
            Imagen2.SetActive(true);
        }
        else
        {
            Imagen2.SetActive(false);/*desacactiva la imagen 2 si no han transcurrido 10 segundos*/
        }

        if (segundos >= 15)/*activa la imagen 3 si a transcurrido 15 segundos o mas*/
        {
            Imagen3.SetActive(true);
        }
        else
        {
            Imagen3.SetActive(false);/*desacactiva la imagen 3 si no han transcurrido 15 segundos*/
        }

        if (segundos <= 0)
        {
            segundos = 0;
        }
    }

    public void Suma(float cantidad) /*realiza la operacion de resta al contador global*/
    {
        segundos -= cantidad;
    }

    public static void DestruirObjeto()
    {
        if(instancia != null)
        {
            Destroy(instancia.gameObject);
            instancia = null;
        }
    }

}
