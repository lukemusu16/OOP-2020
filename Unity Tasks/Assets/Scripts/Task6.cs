using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task6 : MonoBehaviour
{
    Rigidbody2D rb;
    float moveSpeed;
    float dirX, dirY;

    private float XMin, XMax, YMin, YMax;
    public float padding;

    Vector3 newpos;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 3f;
        rb = GetComponent<Rigidbody2D>();

        Camera cam = Camera.main;
        XMin = cam.WorldToViewportPoint(new Vector3(0, 0, 0)).x + padding;
        XMax = cam.WorldToViewportPoint(new Vector3(1, 0, 0)).x - padding;
        YMin = cam.WorldToViewportPoint(new Vector3(0, 0, 0)).y + padding;
        YMax = cam.WorldToViewportPoint(new Vector3(0, 1, 0)).y - padding;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * moveSpeed;
        dirY = Input.GetAxis("Vertical") * moveSpeed;

        //newpos = Mathf.Clamp(XMin, XMax);s
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, dirY, rb.velocity.y);
    }
}
