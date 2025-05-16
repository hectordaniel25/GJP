using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour
{
    [Tooltip("Referencia al script de Cordura que contiene el valor actual de cordura.")]
    public Cordura contadorCordura;

    [Tooltip("Variable pública para llevar el conteo de los espejos recolectados.")]
    public int espejosRecolectados = 0;

    [Tooltip("Número de espejos necesarios para ir a la escena de fragmentos.")]
    public int totalEspejosParaFragmentos = 6;

    [Tooltip("Nombre de la escena de final bueno.")]
    public string escenaFinalBueno = "Final Bueno";

    [Tooltip("Nombre de la escena de final malo.")]
    public string escenaFinalMalo = "Final Malo";

    [Tooltip("Nombre de la escena de fragmentos de espejo.")]
    public string escenaFragmentosEspejo = "Fragmentos de Espejo";

    void Update()
    {
        if (contadorCordura == null)
        {
            Debug.LogError("El script de Cordura no está asignado al script Final.");
            return;
        }

        float mitadCordura = 59f / 2f;


        if (espejosRecolectados >= totalEspejosParaFragmentos)
        {

            SceneManager.LoadScene(escenaFragmentosEspejo);
        }
        else if (contadorCordura.segundos >= 59)
        {

            SceneManager.LoadScene(escenaFinalBueno);
        }

        else if (contadorCordura.segundos < mitadCordura)
        {

            SceneManager.LoadScene(escenaFinalMalo);
        }
    }

}