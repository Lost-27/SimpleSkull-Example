using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMover : MonoBehaviour
{
    public Vector2 direction;
    public float acceleration;
    public Rigidbody2D rb;

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(1))
        {
            rb.AddForce(direction.normalized * acceleration, ForceMode2D.Impulse);
        }
        
    }
}
