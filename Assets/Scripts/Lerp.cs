using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{
    public Vector2 A;
    public Vector2 B;
    public float step;
    private float progress;
    void Start()
    {
        transform.position = A;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(A, B, progress);
        progress += step;
    }
}
