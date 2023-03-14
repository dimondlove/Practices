using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnCollision : MonoBehaviour
{
    public AudioSource AudioSource;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.impulse.magnitude);
        AudioSource.volume = collision.impulse.magnitude * 0.01f;
        AudioSource.Play();
    }
}
