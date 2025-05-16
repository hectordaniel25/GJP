using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espejo6 : MonoBehaviour
{
    [SerializeField] //permite acceder al private
    private Transform imgPlace; //coordenas del receptor
    private Vector2 PosIni; //pos inicial del objeto a mover
    private Vector2 mouseP; //pos inicial del mouse
    private float deltaX, deltaY; //coordenadas x Y
    public static bool locked; //fijar cuando llega a la base
    private AudioSource coin;
    public AudioClip coin1;

    void Start()
    {
        PosIni = transform.position;
        coin = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if (!locked)
        { //! opuesto candado
            deltaX = Camera.main.ScreenToWorldPoint
                (Input.mousePosition).x
                - transform.position.x; //coordenadas
            deltaY = Camera.main.ScreenToWorldPoint
                (Input.mousePosition).y
                - transform.position.y;
        }
    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            mouseP = Camera.main.ScreenToWorldPoint
                (Input.mousePosition);
            transform.position = new Vector2
                (mouseP.x - deltaX, mouseP.y - deltaY);
        }
    }

    private void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x -
            imgPlace.position.x) <= 0.3f &&
            Mathf.Abs(transform.position.y -
            imgPlace.position.y) <= 0.3f)
        {
            transform.position =
                new Vector2(imgPlace.position.x,
                imgPlace.position.y);
            locked = true;
            coin.PlayOneShot(coin1);
        }
        else
        {
            transform.position =
                new Vector2(PosIni.x, PosIni.y);
        }
    }
}
