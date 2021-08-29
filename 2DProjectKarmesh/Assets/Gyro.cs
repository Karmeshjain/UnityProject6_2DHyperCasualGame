using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour
{
    Rigidbody2D rb;
    float dirX;
    float moveSpeed = 20f;
    
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 50;
       
       
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.acceleration.x * moveSpeed;
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -15.5f, 15.5f), transform.position.y);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);
    }
}
