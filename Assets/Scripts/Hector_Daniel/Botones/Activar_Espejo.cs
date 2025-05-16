using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activar_Espejo : MonoBehaviour
{
    public GameObject Llave;
    // Start is called before the first frame update
    void Start()
    {
        Llave.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarEspejo()
    {
        Llave.SetActive(true);
    }
}
