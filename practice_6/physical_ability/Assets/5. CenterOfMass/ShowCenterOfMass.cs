using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCenterOfMass : MonoBehaviour
{
    public Vector3 centerOfMass;

    void Update()
    {
        GetComponent<Rigidbody>().centerOfMass = centerOfMass;
        GetComponent<Rigidbody>().WakeUp();
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(GetComponent<Rigidbody>().worldCenterOfMass, 0.1f);
    }
}
