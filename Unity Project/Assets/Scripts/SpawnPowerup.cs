using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPowerup : MonoBehaviour
{

    public Transform powerup_dmg;
    public Transform powerup_slow;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ball")
        {
            // 25% chance to spawn a "powerup_DMG"
            if (Random.value < 0.25)
            {
                Instantiate(powerup_dmg, transform.position, Quaternion.identity);
            }
            // 25% chance to spawn a "powerup_Slow"
            else if(Random.value < 0.5)
            {
                Instantiate(powerup_slow, transform.position, Quaternion.identity);
            }
        }
    }
}
