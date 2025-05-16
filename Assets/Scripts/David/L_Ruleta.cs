using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class L_Ruleta : MonoBehaviour
{
    public Transform ruleta;
    public Button botonGirar;
    private bool girando = false;
    private float velocidadInicial;
    private float desaceleracion;
    private int cordura = 50; 
    public int espejos; //para escoger la ruleta que sera
    //public GameObject imagen1;
    // distintas ruletas
    public GameObject ruleta1;
    public GameObject ruleta2;
    public GameObject ruleta3;
    public GameObject ruleta4;
    public GameObject ruleta5;

    //Para activar el fragmento del espejo y la puerta de salida
    public GameObject Llave;
    public GameObject Puerta;
    public Todos_los_Fragmentos Dificultad;

    void Start()
    {
        botonGirar.onClick.AddListener(Girar);
        ruleta1.SetActive(false);
        ruleta2.SetActive(false);
        ruleta3.SetActive(false);
        ruleta4.SetActive(false);
        ruleta5.SetActive(false);

        Llave.SetActive(false);
        Puerta.SetActive(false);

        
    }
    void Update()
    {
        Dificultad = FindObjectOfType<Todos_los_Fragmentos>();
        espejos = Dificultad.Condicion;
        Debug.Log(espejos);
        if (girando)
        {
            float deltaVelocidad = desaceleracion * Time.deltaTime;
            velocidadInicial -= deltaVelocidad;

            if (velocidadInicial <= 0)
            {
                girando = false;
                Puntos();
            }else
            {
                ruleta.Rotate(0, 0, -velocidadInicial * Time.deltaTime);
            }
        }
        switch (espejos)
        {
            case 0:
                ruleta1.SetActive(true);
                break;
            case 1:
                ruleta2.SetActive(true);
                break;
            case 2:
                ruleta3.SetActive(true);
                break;
            case 3:
                ruleta4.SetActive(true);
                break;
            case 4:
                ruleta5.SetActive(true);
                break;
        }
    }
    void Girar()
    {
        if (girando) return;
        velocidadInicial = Random.Range(500f, 800f);
        desaceleracion = Random.Range(100f, 200f);
        girando = true;
    }
    void Puntos()
    {
        Cordura corduranivel = FindObjectOfType<Cordura>();
        float angulo = ruleta.eulerAngles.z % 360;
        int seccion = Mathf.FloorToInt(angulo / 60f);
        switch (espejos)
        { 
            case 0:
                //ruleta1.SetActive(true);
                switch (seccion)
            {
                case 0:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 10;
                    break;
                case 1:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 5;
                    break;
                case 2:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 15;
                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                case 3:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 10;
                    break;
                case 4:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 5;
                    break;
                case 5:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 20;
                    break;
            }
                break;
            case 1:
                //ruleta2.SetActive(true);
                switch (seccion)
                {
                    case 0:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 10;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*restara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 1:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 5;
                        break;
                    case 2:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 15;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 3:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 10;
                        break;
                    case 4:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 5;
                        break;
                    case 5:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 20;
                        break;
                }
                break;
            case 2:
                //ruleta3.SetActive(true);
                switch (seccion)
                {
                    case 0:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 10;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 1:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 5;
                        break;
                    case 2:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 15;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 3:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 10;
                        break;
                    case 4:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 5;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 5:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 20;
                        break;
                }
                break;
            case 3:
                //ruleta4.SetActive(true);
                switch (seccion)
                {
                    case 0:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 10;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 1:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 5;
                        break;
                    case 2:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 15;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 3:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 10;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 4:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 5;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 5:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 20;
                        break;
                }
                break;
            case 4:
                //ruleta5.SetActive(true);
                switch (seccion)
                {
                    case 0:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 10;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 1:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 5;
                        break;
                    case 2:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 15;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 3:
                        if (corduranivel != null)
                        {
                            corduranivel.Resta(0.05f);/*restara cada que se active*/
                        }
                        //cordura -= 10;
                        break;
                    case 4:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 5;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                    case 5:
                        if (Llave != null)
                        {
                            Debug.Log("obtivista la llave 1");
                            Llave.SetActive(true);
                        }
                        botonGirar.gameObject.SetActive(false);
                        //cordura += 20;

                        if (corduranivel != null)
                        {
                            corduranivel.Suma(0.05f);/*sumara cada que se active*/
                        }
                        Puerta.SetActive(true);

                        break;
                }
                break;
        }
        
        Debug.Log("Sección: " + seccion + " | Cordura actual: " + cordura);
    }

    public void destruir()
    {
        Destroy(Llave);
    }
}