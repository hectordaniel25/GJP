using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sala_Secreta : MonoBehaviour
{
    public Todos_los_Fragmentos Secreto;

    public GameObject SalaSecreta;
    public GameObject SalaMala;

    // Start is called before the first frame update
    void Start()
    {
        Secreto = FindObjectOfType<Todos_los_Fragmentos>();
        SalaMala.SetActive(false);
        SalaSecreta.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Secreto.Condicion == 5)
        {
            SalaSecreta.SetActive(true);
            SalaMala.SetActive(false);
        }
        else
        {
            SalaMala.SetActive(true);
            SalaSecreta.SetActive(false);
        }
    }
}
