using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recolectar_Espejos : MonoBehaviour
{
    //NumEspejo se utilizara para indicar que fragmento del espejo es
    public int NumEspejo;
    //Code es la variablle que utilizara el Script Espejos Recolectados
    public int Code;
    //Boton servira para indicar que objeto sera desactivado
    public GameObject Boton;
    
    public void RecolectarEspejos()//Al precionar el boton se guarda el valor que se estable desde unity
    {
        //Code sera igual igual al fragmanto del espejo
        Code = NumEspejo;
    }


    public void DesactivarBoton()
    {
        //Desactiva el objeto Boton
        Boton.SetActive(false);
    }
}
