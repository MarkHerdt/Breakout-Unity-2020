using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    Rigidbody2D powerup;
    private Vector2 velocity;

    private void Awake()
    {
        powerup = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Moves the powerup downwards
        powerup.velocity = new Vector2(0,-5);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Destroys the powerup if the player collects it
        if (collision.gameObject.tag == "Paddle" || collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
            if(collision.gameObject.tag == "Paddle" && gameObject.tag == "Powerup_Slow")
            {
                Ball.speed -= 0.5f;
            }
        }
    }
}