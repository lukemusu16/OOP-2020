using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Task4 : MonoBehaviour
{
    bool canMove;
    bool isDragging;
    Collider2D collider;


    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider2D>();
        canMove = false;
        isDragging = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (collider == Physics2D.OverlapPoint(mousePos))
            {
                canMove = true;
            }
            else
            {
                canMove = false;
            }
            if (canMove)
            {
                isDragging = true;
            }


        }
        if (isDragging)
        {
            this.transform.position = mousePos;
        }
        if (Input.GetMouseButtonUp(0))
        {
            canMove = false;
            isDragging = false;
        }
    }
}
