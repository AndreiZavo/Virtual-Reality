using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clapper : MonoBehaviour
{
    private AudioSource bellSound;
    void Start()
    {
        bellSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        bellSound.Play();
    }
}
