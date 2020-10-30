using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    public float thrust = 1.0f;
    Rigidbody2D rb;
    GameObject ball;

    float alpha = 1f;

    int hp = 100;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(thrust, thrust));
    }

    // Update is called once per frame
    void Update()
    {
        health();
    }

    void health()
    {
        if (hp <= 0)
        {
            Destroy(ball);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        hp -= 10;

        alpha -= 0.1f;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha);
    }
}
