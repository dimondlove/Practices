using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public void OnHit()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 200f);
        GetComponent<Rigidbody>().AddTorque(100f, 0f, 0f);
    }
}
