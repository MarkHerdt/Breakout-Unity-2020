using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBottom : MonoBehaviour
{
    public static int life = 3;

    public int Life
    {
        get
        {
            return life;
        }
    }

    public event System.Action<int> OnLifeChange;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        life--;
        OnLifeChange?.Invoke(life);
        if (collision.gameObject.tag == "Ball")
        {
            Ball.isMoving = false;
        }
        if(life == 0)
        {
            GameObject[] block = GameObject.FindGameObjectsWithTag("Block");
            foreach (GameObject obj in block)
            GameObject.Destroy(obj);
        }
    }
}
