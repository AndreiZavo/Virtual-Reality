using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegsBehaviour : MonoBehaviour
{
    private float velocity = 30.0f;
    private float min = -5.0f;
    private float max = 90.0f;
    private float x = 0.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var deltaTime = Time.deltaTime;
        x += velocity * deltaTime;
        if (x > max)
        {
            velocity *= -1;
            x -= x - max;
        }
        if (x < min)
        {
            velocity *= -1;
            x -= x - min;
        }

        transform.localRotation = Quaternion.AngleAxis(x, Vector3.right);
    }
}
