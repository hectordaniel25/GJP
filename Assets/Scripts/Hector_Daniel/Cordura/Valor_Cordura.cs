using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Valor_Cordura : MonoBehaviour
{
    public Cordura contador_cordura;

    public float segundos1;

    private void Awake()
    {
       /* DontDestroyOnLoad(gameObject);*/
    }

    // Update is called once per frame
    void Update()
    {
        contador_cordura.segundos = segundos1;
    }
}
