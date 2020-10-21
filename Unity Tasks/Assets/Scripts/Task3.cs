using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    float mousePosX;
    float mousePosY;
    Vector3 p = new Vector3();
    public GameObject Circle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnOnMouse();
    }

    void SpawnOnMouse()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            mousePosX = Input.mousePosition.x;
            mousePosY = Input.mousePosition.y;

            p = Camera.main.ScreenToWorldPoint(new Vector3(mousePosX, mousePosY, Camera.main.nearClipPlane));
            Instantiate(Circle, p, Quaternion.identity);
        }
    }
}
