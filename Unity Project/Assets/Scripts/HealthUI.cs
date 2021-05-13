using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    Text textRef;

    public WallBottom lifeRef;

    private void Awake()
    {
        textRef = GetComponent<Text>();
        if (textRef == null)
        {
            Debug.LogError("Please attach a Text component.");
            enabled = false;
        }
        if (lifeRef == null)
        {
            Debug.LogError("Please assign a Goal reference.");
            enabled = false;
        }
        else
        {
            lifeRef.OnLifeChange += WallRef_OnLifeChange;
        }
    }

    private void WallRef_OnLifeChange(int newLife)
    {
        textRef.text = "Life: " + newLife;
    }

    private void Start()
    {
        textRef.text = "Life: 3";
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && WallBottom.life == 0)
        {
            WallBottom.life = 3;
            WallRef_OnLifeChange(3);
        }
    }
}
