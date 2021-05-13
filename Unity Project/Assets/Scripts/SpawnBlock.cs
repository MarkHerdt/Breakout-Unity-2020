using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    public Transform block1;

    // Start is called before the first frame update
    void Start()
    {
        for(float y = 3.5f; y >= 1.5; y--)
        {
            for(float x = -4.5f; x <= 4.5; x++)
            {
                // Spawns the object at coordinates specified in the for loop
                Instantiate(block1, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }

    private void FixedUpdate()
    {
        GameObject block = GameObject.FindGameObjectWithTag("Block");

        if (Input.GetKeyDown(KeyCode.Space) && Ball.isMoving == false && WallBottom.life == 0)
        {
            for (float y = 3.5f; y >= 1.5; y--)
            {
                for (float x = -4.5f; x <= 4.5; x++)
                {
                    // Spawns the object at coordinates specified in the for loop
                    Instantiate(block1, new Vector3(x, y, 0), Quaternion.identity);
                }
            }
        }
    }
}
