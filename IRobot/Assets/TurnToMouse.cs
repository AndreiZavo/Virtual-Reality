using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToMouse : MonoBehaviour
{
    private Camera myCamera;
    void Start()
    {
        myCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        var mouse = Input.mousePosition;
        var fieldOfView = myCamera.fieldOfView;
        var numerator = (float)Mathf.Sin(Mathf.PI / 180 * (90 - fieldOfView / 2));
        var denominator = (float)Mathf.Sin(Mathf.PI / 180 * (fieldOfView / 2));
        mouse.z = numerator / denominator;
        var world = myCamera.ScreenToWorldPoint(mouse);
        transform.LookAt(world);
    }
}
 