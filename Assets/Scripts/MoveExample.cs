using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveExample : MonoBehaviour
{
    public Vector2 moveXY;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(moveXY.normalized*speed);
    }
}
