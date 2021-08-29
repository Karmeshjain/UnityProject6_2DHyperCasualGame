﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D myBody;
    public float moveSpeed = 2f;
     void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        if(Input.GetAxisRaw("Horizontal")>0f)
        {
            myBody.velocity = new Vector2(moveSpeed, myBody.velocity.y);
        }

        if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            myBody.velocity = new Vector2(-moveSpeed, myBody.velocity.y);
        }
    }
    public void PlatformMove(float x)
    {
        myBody.velocity = new Vector2(x, myBody.velocity.y);
    }
}
