using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftControl : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float Speed = 5f;
    public float RotationSpeed = 1f;

    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.maxAngularVelocity = Mathf.Infinity;
    }

    void FixedUpdate()
    {
        float sideForce = Input.GetAxis("Horizontal") * RotationSpeed;
        float forwardForce = Input.GetAxis("Vertical") * Speed;

        _rigidbody.AddRelativeForce(0f, 0f, forwardForce);
        _rigidbody.AddRelativeTorque(0f, sideForce, 0f);
    }
}
