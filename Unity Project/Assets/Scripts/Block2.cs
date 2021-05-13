using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block2 : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When ball hits "Block2" destroy it
        if(collision.gameObject.tag == "Ball")
        {
            Destroy(gameObject);
            if (Paddle.dmg > 0)
            {
                Paddle.dmg--;
            }
        }
    }
}
