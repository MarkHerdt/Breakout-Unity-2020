using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    Rigidbody2D paddle;
    public static int dmg = 0;

    public string inputAxisName = "Horizontal";
    public float speed = 10; // Speed, the paddle moves with

    private void Awake()
    {
        paddle = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Moves the paddel 
        paddle.velocity = Vector3.right * speed * Input.GetAxisRaw(inputAxisName);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Powerup_DMG")
        {
            dmg++;
        }
    }
}
