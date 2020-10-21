using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{
    public GameObject Circle;
    // Start is called before the first frame update
    void Start()
    {
        setBoundaries();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setBoundaries()
    {
        float XMin = 0.1f;
        float XMax = 0.9f;
        float YMin = 0.1f;
        float YMax = 0.9f;
        float z = 0f;

        var BottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(XMin, YMin, z));
        var TopLeft = Camera.main.ViewportToWorldPoint(new Vector3(XMin, YMax, z));
        var BottomRight = Camera.main.ViewportToWorldPoint(new Vector3(XMax, YMin, z));
        var TopRight = Camera.main.ViewportToWorldPoint(new Vector3(XMax, YMax, z));

        Instantiate(Circle , BottomLeft, Quaternion.identity);
        Instantiate(Circle, TopLeft, Quaternion.identity);
        Instantiate(Circle, BottomRight, Quaternion.identity);
        Instantiate(Circle, TopRight, Quaternion.identity);
    }
}
