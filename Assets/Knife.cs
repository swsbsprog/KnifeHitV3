using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : MonoBehaviour
{
    public new Rigidbody2D rigidbody2D;
    public Vector2 force = new Vector2(0, 10f);
    void Start()
    {
        print("Start");
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.bodyType = RigidbodyType2D.Dynamic;
        rigidbody2D.AddForce(force, ForceMode2D.Impulse);
    }
}
