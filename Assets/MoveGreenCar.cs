using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGreenCar : MonoBehaviour
{
    private Touch touch;
    private float speed;
    private bool gameStarted;

    void Start()
    {
        speed = 0.06f;
        gameStarted = false;
    }

    void Update()
    {
        if (gameStarted == true)
        {
            transform.position = new Vector3(
                transform.position.x - speed,
                transform.position.y,
                transform.position.z);

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