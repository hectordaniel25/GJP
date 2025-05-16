using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    //este codigo es para las imagenes que se mueven sin lugar correcto
    private Vector2 mouseP;
    private float deltaX, deltaY;

    void OnMouseDown()
    {
        deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
        deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    }

    void OnMouseDrag()
    {
        mouseP = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(mouseP.x - deltaX, mouseP.y - deltaY);
    }
}
