using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveCamera : MonoBehaviour
{
    private Touch touch;
    private float speed;
    private bool gameStarted;
    float posCounter;


    void Start()
    {
        speed = 0.1f;
        posCounter = 0f;
        gameStarted = false;
    }


    void Update()
    {
        if (transform.position.z < 38.65)
        {
            if (gameStarted == true)
            {
                if (Input.touchCount > 0)
                {
                    if (Input.GetTouch(0).phase == TouchPhase.Stationary)
                    {
                        speed = 0;
                    }
                    else
                    {
                        speed = 0.1f;
                    }
                }
                transform.position = new Vector3(
                    transform.position.x,
                    transform.position.y,
                    transform.position.z + speed);

            }
            else
            {
                if (Input.touchCount > 0)
                {
                    gameStarted = true;
                }
            }
        }
    }
}
