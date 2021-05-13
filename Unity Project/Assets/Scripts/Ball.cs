using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigidBody;
    // Initial speed the ball moves with
    public static float speed = 7.5f;
    public static bool isMoving;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        ResetBall();
    }

    private void FixedUpdate()
    {
        // Press space to start game
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isMoving == false)
            {
                StartBall();
                isMoving = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When the ball goes out of screen
        if(collision.gameObject.tag == "Wall")
        {
            // Set the speed of the ball to 0
            rigidBody.velocity = Vector2.zero;
            speed = 7.5f;
            ResetBall();
        }
        // When the ball collides with a block
        if(collision.gameObject.tag == "Block")
        {
            // Increases speed
            speed += 0.5f;
            // Gives the ball the new speed
            rigidBody.velocity = rigidBody.velocity.normalized * speed;
        }
        // When the ball collides with the paddle
        if (collision.gameObject.tag == "Paddle")
        {
            // Increases speed
            speed += 0.25f;
            // Gives the ball the new speed
            rigidBody.velocity = rigidBody.velocity.normalized * speed;
        }
        GameObject block = GameObject.FindGameObjectWithTag("Block");
        if (block == null)
        {
            Debug.Log("sdfsdf");
            rigidBody.velocity = Vector2.zero;
            ResetBall();
        }

    }

    void StartBall()
    {
        // Gives the ball a speed value and chooses a random direction it will move to
        rigidBody.velocity = speed * Random.insideUnitCircle.normalized;
    }

    void ResetBall()
    {
        // Reset ball position
        transform.position = new Vector3(0,0,0);
    }
}
