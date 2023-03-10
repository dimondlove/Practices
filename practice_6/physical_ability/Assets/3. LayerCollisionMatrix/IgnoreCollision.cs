using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour
{
    public Collider ColliderA;
    public Collider ColliderB;

    void Start()
    {
        Physics.IgnoreCollision(ColliderA, ColliderB);
    }

}
