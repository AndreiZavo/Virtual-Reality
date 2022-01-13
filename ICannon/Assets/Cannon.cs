using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] public Rigidbody cannonBall;
    private Camera myCamera;
    // Start is called before the first frame update


    private void Start()
    {
        myCamera = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!Input.GetMouseButton(0))
        {
            return;
        }
        var ray = myCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hit))
        {
            FireToMouse(hit.point);
        }
    }

    private void FireToMouse(Vector3 point)
    {
        var transformPosition = transform.position;
        var velocity = (point - transformPosition) * 3;
        cannonBall.transform.position = transformPosition;
        cannonBall.velocity = velocity;
    }
}
