using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block1 : MonoBehaviour
{
    public Transform block2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When ball hits "Block1", destroy it and spawn "Block2" on its position
        if(collision.gameObject.tag == "Ball" && Paddle.dmg > 0)
        {
            Destroy(gameObject);
            if(Paddle.dmg > 0)
            {
                Paddle.dmg--;
            }
        }
        else
        {
            Destroy(gameObject);
            Instantiate(block2, transform.position, Quaternion.identity);
        }
    }
}
