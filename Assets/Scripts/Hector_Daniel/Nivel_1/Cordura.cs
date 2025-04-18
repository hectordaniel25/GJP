using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cordura : MonoBehaviour
{
    /*Se establecen las variables que usara el codigo en donde todas las variables podran verse en unity*/
    public Text ContadorTexto;//Colocamos el objeto de texto donde se mostrara el tiempo transcurrido
    public int minutos;//Indica los minutos
    public float segundos;//Indica las horas
    public float GradoCordura;//Indicara el grado de cordura del jugador
    public float DivisorCordura;//Irve para indicar el valor que se dividira el valor de cordura (posiblemente se borro por retirar la barra de cordura)
    public static Cordura instancia;/*Esta variable estática mantiene una única instancia de la clase Cordura.
                                    Se utiliza para implementar el patrón Singleton, asegurando que solo exista 
                                    un objeto de esta clase en toda la aplicación.*/
    public GameObject Imagen1;//Imagen de cordura al 2
    public GameObject Imagen2;//imagen de cordura al 3
    public GameObject Imagen3;// imagen de cordura al 4
    public GameObject Boton;//la funcion de este boton es para poder hacer la suma de la cordura, se podra cambiar la funcion en relacion a la forma de obtener mas cordura

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
        ActualizarContador();
    }

    /*Se realizara la comparacion de los valores del contador para pasar al minuto*/
    private void Update()
    {

        Boton = GameObject.Find("SumaPuntos");/*Busca el boton que restara 5 segundos al contador*/
        segundos += Time.deltaTime;/*Forma nativa para poder generar un contador*/
        GradoCordura += Time.deltaTime/DivisorCordura;

        if (segundos >= 59) /*Cuando el contador llegue a 59 regresara a 0 y minutos agregara +1*/
        {
            segundos = 0;
            minutos += 1;
        }


        if (GradoCordura >= 0.25)/*activa la imagen 1 si a transcurrido 5 segundos o mas*/
        {
            Imagen1.SetActive(true);
        }
        else
        {
            Imagen1.SetActive(false);/*desacactiva la imagen 1 si no han transcurrido 5 segundos*/
        }

        if (GradoCordura >= 0.5)/*activa la imagen 2 si a transcurrido 10 segundos o mas*/
        {
            Imagen2.SetActive(true);
        }
        else
        {
            Imagen2.SetActive(false);/*desacactiva la imagen 2 si no han transcurrido 10 segundos*/
        }

        if (GradoCordura >= 0.75)/*activa la imagen 3 si a transcurrido 15 segundos o mas*/
        {
            Imagen3.SetActive(true);
        }
        else
        {
            Imagen3.SetActive(false);/*desacactiva la imagen 3 si no han transcurrido 15 segundos*/
        }

        if (GradoCordura <= 0)//Sirve para que al sumar mas cordura al jugador no sobrepase el nivel 0 y no tener numeros negativos
        {
            GradoCordura = 0;
        }

        ActualizarContador();
    }

    public void Suma(float cantidad) //Realiza la suma de cordura al jugador
    {
        GradoCordura -= cantidad;
    }

    public static void DestruirObjeto()//Esta funcion sirve para que el objeto persistente pueda ser destruido en la instancia que sea necesaria
    {
        if(instancia != null)
        {
            Destroy(instancia.gameObject);
            instancia = null;
        }
    }

    void ActualizarContador()//Esta funcion sirve para que el texto cuando el valor sea menor a 10 segundos no se vea 1..2..3.. sino como 01..02..03..
    {
        if( segundos < 10)
        {
            ContadorTexto.text = minutos.ToString() + ":0" + segundos.ToString("f0");
        }
        else
        {
            ContadorTexto.text = minutos.ToString() + ":" + segundos.ToString("f0");
        }
    }

}
