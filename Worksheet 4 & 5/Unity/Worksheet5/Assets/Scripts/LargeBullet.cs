using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargeBullet : Bullet
{
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        speed = 0.5f;
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }
}
