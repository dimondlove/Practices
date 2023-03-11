using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BangAtPosition : MonoBehaviour
{
    public Rigidbody TargetRigidbody;
    public float ForceValue = 100f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            TargetRigidbody.AddForceAtPosition(transform.up * ForceValue, transform.position);
        }
    }
}
