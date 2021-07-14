using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    private Touch touch;
    private float speed;
    private bool gameStarted;
    private UnityEngine.Vector3 obstaclePos;


  
    void Start()
    {
        speed = 0.1f;
        gameStarted = false;
        obstaclePos = GameObject.Find("green_car").transform.position;
    }

  
    void Update()
    {
        if (transform.position.z < 40)
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
